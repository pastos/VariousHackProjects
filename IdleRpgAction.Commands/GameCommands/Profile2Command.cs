using IdleRpgAction.Domain.Enumerations;
using IdleRpgAction.Domain.Interfaces;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class Profile2Command : ICommand
    {
        public string Actor { get; set; }
        public TimeSpan Cooldown { get; set; }
        public ActionCommandEnum ActionCommand { get; private set; }
        public string RandomText { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Profile2Command()
        {
            ActionCommand = ActionCommandEnum.Profile2;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
