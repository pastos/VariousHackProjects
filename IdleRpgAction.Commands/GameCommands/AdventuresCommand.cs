using IdleRpgAction.Domain.Enumerations;
using IdleRpgAction.Domain.Interfaces;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class AdventuresCommand : ICommand
    {
        public TimeSpan Cooldown { get; set; }
        public ActionCommandEnum ActionCommand { get; private set; }
        public string RandomText { get; set; }

        public AdventuresCommand()
        {
            ActionCommand = ActionCommandEnum.Adventures;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
