using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class StealCommand : Implementations.IdleRpgActionBase
    {
        public StealCommand()
        {
            ActionCommand = ActionCommandEnum.Steal;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
