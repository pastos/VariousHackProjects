using IdleRpgAction.Domain.Enumerations;
using IdleRpgAction.Domain.Interfaces;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class StealCommand : ICommand
    {
        public TimeSpan Cooldown { get; set; }
        public ActionCommandEnum ActionCommand { get; private set; }
        public string RandomText { get; set; }

        public StealCommand()
        {
            ActionCommand = ActionCommandEnum.Steal;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
