using IdleRpgAction.Domain.Enumerations;
using IdleRpgAction.Domain.Interfaces;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class FlipCommand : ICommand
    {
        public string RandomText { get; set; }
        public int BetAmount { get; set; }
        public TimeSpan Cooldown { get; set; }
        public ActionCommandEnum ActionCommand { get; private set; }
        public CoinSideEnum CoinSide { get; set; }

        public FlipCommand()
        {
            ActionCommand = ActionCommandEnum.Flip;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
