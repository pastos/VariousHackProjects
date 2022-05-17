using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class HungerGamesCommand : Implementations.IdleRpgActionBase
    {        
        public HungerGamesCommand()
        {
            ActionCommand = ActionCommandEnum.Hungergames;
            Cooldown = new TimeSpan(0, 3, 0);
        }
    }
}
