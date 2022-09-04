using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class DailyCommand : Implementations.IdleRpgActionBase
    {
        public DailyCommand()
        {
            ActionCommand = ActionCommandEnum.Daily;
            Cooldown = new TimeSpan(14, 30, 0);
        }
    }
}
