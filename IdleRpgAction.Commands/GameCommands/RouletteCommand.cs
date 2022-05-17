using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class RouletteCommand : Implementations.IdleRpgActionBase
    {
        public RouletteCommand()
        {
            ActionCommand = ActionCommandEnum.Roulette;
            Cooldown = new TimeSpan(0, 0, 15);
        }
    }
}
