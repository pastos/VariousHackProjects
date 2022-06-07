using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class PurchaseBonusCommand : Implementations.IdleRpgActionBase
    {
        public PurchaseBonusCommand()
        {
            ActionCommand = ActionCommandEnum.Purchase;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
