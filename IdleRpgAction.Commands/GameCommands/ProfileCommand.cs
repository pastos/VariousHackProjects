using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class ProfileCommand : Implementations.IdleRpgActionBase
    {
        public ProfileCommand()
        {
            ActionCommand = ActionCommandEnum.Profile;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
