using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class FlipCommand : Implementations.IdleRpgActionBase
    {
        public FlipCommand()
        {
            ActionCommand = ActionCommandEnum.Flip;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
