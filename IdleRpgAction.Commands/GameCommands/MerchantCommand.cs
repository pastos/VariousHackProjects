using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class MerchantCommand : Implementations.IdleRpgActionBase
    {
        public MerchantCommand()
        {
            ActionCommand = ActionCommandEnum.Merchant;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
