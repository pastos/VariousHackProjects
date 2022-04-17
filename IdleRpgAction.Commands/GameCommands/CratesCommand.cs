using IdleRpgAction.Domain.Enumerations;
using IdleRpgAction.Domain.Interfaces;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class CratesCommand : ICommand
    {
        public TimeSpan Cooldown { get; set; }
        public ActionCommandEnum ActionCommand { get; private set; }
        public string RandomText { get; set; }

        public CratesCommand()
        {
            ActionCommand = ActionCommandEnum.Crates;
            Cooldown = new TimeSpan(0, 0, 4);
        }
    }
}
