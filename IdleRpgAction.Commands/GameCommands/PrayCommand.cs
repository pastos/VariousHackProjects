using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class PrayCommand : Implementations.IdleRpgActionBase
    {
        public PrayCommand()
        {
            ActionCommand = ActionCommandEnum.Pray;
            Cooldown = new TimeSpan(14, 30, 0);
        }
    }
}
