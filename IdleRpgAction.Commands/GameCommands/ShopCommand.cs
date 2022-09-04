using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class ShopCommand : Implementations.IdleRpgActionBase
    {
        public ShopCommand()
        {
            ActionCommand = ActionCommandEnum.Shop;
            Cooldown = new TimeSpan(0, 0, 4);
        }
    }
}
