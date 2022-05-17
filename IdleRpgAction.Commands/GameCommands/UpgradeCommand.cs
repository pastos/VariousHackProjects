using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class UpgradeCommand : Implementations.IdleRpgActionBase
    {
        public UpgradeCommand()
        {
            ActionCommand = ActionCommandEnum.Upgrade;
            Cooldown = new TimeSpan(0, 0, 4);
        }
    }
}
