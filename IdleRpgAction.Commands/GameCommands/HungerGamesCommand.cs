using IdleRpgAction.Domain.Enumerations;
using IdleRpgAction.Domain.Interfaces;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class HungerGamesCommand : ICommand
    {
        public TimeSpan Cooldown { get; set; }
        public ActionCommandEnum ActionCommand { get; private set; }
        public string RandomText { get; set; }

        public HungerGamesCommand()
        {
            ActionCommand = ActionCommandEnum.Hungergames;
            Cooldown = new TimeSpan(0, 3, 0);
        }
    }
}
