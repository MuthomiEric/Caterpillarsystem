using Shared.Helpers;
using Shared.Interfaces;
using Shared.Models;

namespace Shared.Commands.Direction
{
    public class DownCommand : ICommand
    {
        public DownCommand(int steps)
        {
            Steps = steps;            
        }
        public int Steps { get; set; }

        public void Execute()
        {
            var _caterPillar = CaterPillarFactory.GetCaterPillar();
        }
    }
}
