using IdleRpgAction.Domain.Enumerations;
using IdleRpgAction.Domain.Interfaces;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    /// <summary>
    /// $bet [maximum=6] [tip=6] [money=0]
    /// </summary>
    public class BetCommand : ICommand
    {
        public string RandomText { get; set; }
        /// <summary>
        /// Must be greater than 1
        /// </summary>
        public int DiceSides { get; set; }
        /// <summary>
        /// Must be a number from 0 to 6
        /// </summary>
        public int BetNumber { get; set; }
        public int BetAmount { get; set; }
        public TimeSpan Cooldown { get; set; }
        public ActionCommandEnum ActionCommand { get; private set; }

        public BetCommand()
        {
            ActionCommand = ActionCommandEnum.Bet;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
