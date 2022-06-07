using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class ActivateBonusCommand : Implementations.IdleRpgActionBase
    {
        public ActivateBonusCommand()
        {
            ActionCommand = ActionCommandEnum.Activate;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
