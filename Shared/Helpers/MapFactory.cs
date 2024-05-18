using Shared.Models;

namespace Shared.Helpers
{
    public static class MapFactory
    {
        private static char[,]? Map { get; set; }
        public static char[,] GetMap()
        {
            Semaphore semaphore = new Semaphore(1, 1);

            semaphore.WaitOne();

            if (Map == null)
            {
                var mapObj = new Map(30, 30);

                Map = mapObj.InitializeMap();
            }

            semaphore.Release();

            return Map;
        }
    }
}
