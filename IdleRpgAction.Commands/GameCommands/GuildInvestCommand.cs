using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class GuildInvestCommand : Implementations.IdleRpgActionBase
    {
        public GuildInvestCommand()
        {
            ActionCommand = ActionCommandEnum.Guild_Invest;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
