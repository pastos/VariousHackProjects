using IdleRpgAction.Domain.Enumerations;
using IdleRpgAction.Domain.Interfaces;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class BlackjackCommand : ICommand
    {
        public string RandomText { get; set; }
        public int BetAmount { get; set; }
        public TimeSpan Cooldown { get; set; }
        public ActionCommandEnum ActionCommand { get; private set; }

        public BlackjackCommand()
        {
            ActionCommand = ActionCommandEnum.BlackJack;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
