using IdleRpgAction.Domain.Enumerations;
using IdleRpgAction.Domain.Interfaces;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    /// <summary>
    /// $[card|draw] [enemy] [money=0]
    /// </summary>
    public class CardCommand : ICommand
    {
        public string RandomText { get; set; }
        public int BetAmount { get; set; }
        public TimeSpan Cooldown { get; set; }
        public ActionCommandEnum ActionCommand { get; private set; }

        public CardCommand()
        {
            ActionCommand = ActionCommandEnum.Card;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
