using IdleRpgAction.Domain.Enumerations;
using IdleRpgAction.Domain.Interfaces;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class RouletteCommand : ICommand
    {
        public string RandomText { get; set; }
        public int Number { get; set; }
        public int BetAmount { get; set; }
        public RouletteGameEnum RouletteGame { get; set; }
        public TimeSpan Cooldown { get; set; }
        public ActionCommandEnum ActionCommand { get; private set; }

        public RouletteCommand()
        {
            ActionCommand = ActionCommandEnum.Roulette;
            Cooldown = new TimeSpan(0, 0, 15);
        }
    }
}
