using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class InventoryCommand : Implementations.IdleRpgActionBase
    {
        public InventoryCommand()
        {
            ActionCommand = ActionCommandEnum.Inventory;
            Cooldown = new TimeSpan(0, 0, 4);
        }
    }
}
