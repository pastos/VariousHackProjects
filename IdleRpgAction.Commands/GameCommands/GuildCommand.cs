using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class GuildCommand : Implementations.IdleRpgActionBase
    {
        public GuildCommand()
        {
            ActionCommand = ActionCommandEnum.Guild;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
