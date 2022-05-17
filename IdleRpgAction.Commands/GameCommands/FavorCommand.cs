using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class FavorCommand : Implementations.IdleRpgActionBase
    {
        public FavorCommand()
        {
            ActionCommand = ActionCommandEnum.Favor;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
