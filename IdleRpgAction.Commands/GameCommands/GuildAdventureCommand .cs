using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class GuildAdventureCommand : Implementations.IdleRpgActionBase
    {
        public GuildAdventureCommand()
        {
            ActionCommand = ActionCommandEnum.Guild_Adventure;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
