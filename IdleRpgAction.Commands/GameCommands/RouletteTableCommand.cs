using IdleRpgAction.Domain.Enumerations;
using IdleRpgAction.Domain.Interfaces;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class RouletteTableCommand : ICommand
    {
        public string RandomText { get; set; }
        public TimeSpan Cooldown { get; set; }
        public ActionCommandEnum ActionCommand { get; private set; }

        public RouletteTableCommand()
        {
            ActionCommand = ActionCommandEnum.Roulette_Table;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
