using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class AdventuresCommand : Implementations.IdleRpgActionBase
    {
        public AdventuresCommand()
        {
            ActionCommand = ActionCommandEnum.Adventures;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
