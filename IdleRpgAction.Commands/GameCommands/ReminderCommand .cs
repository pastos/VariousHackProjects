using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class ReminderCommand : Implementations.IdleRpgActionBase
    {
        public ReminderCommand()
        {
            ActionCommand = ActionCommandEnum.Reminder;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
