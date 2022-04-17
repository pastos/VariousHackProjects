using IdleRpgAction.Domain.Enumerations;
using IdleRpgAction.Domain.Interfaces;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    ///////////////////////////////////    

    ////////////Adventuring
    public class StatusCommand :  //: ICommand
    {
        public TimeSpan Cooldown { get; set; }
        public ActionCommandEnum ActionCommand { get; private set; }
        public string RandomText { get; set; }

        public StatusCommand()
        {
            ActionCommand = ActionCommandEnum.Status;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
