using IdleRpgAction.Domain.Enumerations;
using IdleRpgAction.Domain.Interfaces;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class AdventureCommand : ICommand
    {
        public TimeSpan Cooldown { get; set; }
        public ActionCommandEnum ActionCommand { get; private set; }
        public string RandomText { get; set; }
        public int Level { get; set; }

        public AdventureCommand()
        {
            ActionCommand = ActionCommandEnum.Adventure;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
