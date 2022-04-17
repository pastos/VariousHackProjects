using IdleRpgAction.Domain.Enumerations;
using IdleRpgAction.Domain.Interfaces;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class UpgradeCommand : ICommand
    {
        public TimeSpan Cooldown { get; set; }
        public ActionCommandEnum ActionCommand { get; private set; }
        public string RandomText { get; set; }
        public int ItemId { get; set; }

        public UpgradeCommand()
        {
            ActionCommand = ActionCommandEnum.Upgrade;
            Cooldown = new TimeSpan(0, 0, 4);
        }
    }
}
