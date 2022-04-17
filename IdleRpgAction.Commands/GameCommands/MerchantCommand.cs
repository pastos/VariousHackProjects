using IdleRpgAction.Domain.Enumerations;
using IdleRpgAction.Domain.Interfaces;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class MerchantCommand : ICommand
    {
        public TimeSpan Cooldown { get; set; }
        public ActionCommandEnum ActionCommand { get; private set; }
        public string RandomText { get; set; }
        public int ItemId { get; set; }

        public MerchantCommand()
        {
            ActionCommand = ActionCommandEnum.Merchant;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
