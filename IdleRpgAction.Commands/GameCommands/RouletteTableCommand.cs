using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class RouletteTableCommand : Implementations.IdleRpgActionBase
    {
        public RouletteTableCommand()
        {
            ActionCommand = ActionCommandEnum.Roulette_Table;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
