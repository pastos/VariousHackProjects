using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class Profile2Command : Implementations.IdleRpgActionBase
    {
        public Profile2Command()
        {
            ActionCommand = ActionCommandEnum.Profile2;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
