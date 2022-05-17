using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class ActiveAdventureCommand : Implementations.IdleRpgActionBase
    {
        public ActiveAdventureCommand()
        {
            ActionCommand = ActionCommandEnum.ActiveAdventure;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
