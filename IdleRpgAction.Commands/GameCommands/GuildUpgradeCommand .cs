using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class GuildUpgradeCommand : Implementations.IdleRpgActionBase
    {
        public GuildUpgradeCommand()
        {
            ActionCommand = ActionCommandEnum.Guild_Upgrade;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
