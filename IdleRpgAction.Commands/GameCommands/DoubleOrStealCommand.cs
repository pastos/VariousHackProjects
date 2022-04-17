using IdleRpgAction.Domain.Enumerations;
using IdleRpgAction.Domain.Interfaces;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    /// <summary>
    /// $[doubleorsteal|dos] [user]
    /// </summary>
    public class DoubleOrStealCommand : ICommand
    {
        public string RandomText { get; set; }
        public int BetAmount { get; set; }
        public string Actor { get; set; }
        public TimeSpan Cooldown { get; set; }
        public ActionCommandEnum ActionCommand { get; private set; }

        public DoubleOrStealCommand()
        {
            ActionCommand = ActionCommandEnum.Dos;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
