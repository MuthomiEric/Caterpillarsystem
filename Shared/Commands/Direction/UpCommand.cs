using Shared.Helpers;
using Shared.Interfaces;

namespace Shared.Commands.Direction
{
    public class UpCommand : ICommand
    {
        public int Steps { get; set; }
        public UpCommand(int steps)
        {
            Steps = steps;
        }
        public void Execute()
        {
            var caterPillar = CaterPillarFactory.GetCaterPillar();

            caterPillar.MoveUp(Steps);
        }
    }
}
