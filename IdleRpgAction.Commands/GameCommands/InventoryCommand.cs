using IdleRpgAction.Domain.Enumerations;
using IdleRpgAction.Domain.Interfaces;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class InventoryCommand : ICommand
    {
        public TimeSpan Cooldown { get; set; }
        public ActionCommandEnum ActionCommand { get; private set; }
        public string RandomText { get; set; }

        public InventoryCommand()
        {
            ActionCommand = ActionCommandEnum.Inventory;
            Cooldown = new TimeSpan(0, 0, 4);
        }
    }
}
