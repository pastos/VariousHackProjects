using IdleRpgAction.Domain.Enumerations;
using IdleRpgAction.Domain.Interfaces;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class MergeCommand : ICommand
    {
        public TimeSpan Cooldown { get; set; }
        public ActionCommandEnum ActionCommand { get; private set; }
        public string RandomText { get; set; }
        public int ItemId1 { get; set; }
        public int ItemId2 { get; set; }

        public MergeCommand()
        {
            ActionCommand = ActionCommandEnum.Inventory;
            Cooldown = new TimeSpan(0, 0, 4);
        }
    }
}
