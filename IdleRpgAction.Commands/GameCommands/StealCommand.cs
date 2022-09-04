using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class StealCommand : Implementations.IdleRpgActionBase
    {
        public StealCommand()
        {
            ActionCommand = ActionCommandEnum.Steal;
            Cooldown = new TimeSpan(1, 0, 0);
        }
    }
}
