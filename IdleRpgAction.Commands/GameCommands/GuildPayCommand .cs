using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class GuildPayCommand : Implementations.IdleRpgActionBase
    {
        public GuildPayCommand()
        {
            ActionCommand = ActionCommandEnum.Guild_Pay;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
