using IdleRpgAction.Domain.Enumerations;
using IdleRpgAction.Domain.Interfaces;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    ///////////////////////////////////    

    ////////////Adventuring
    public class StatusCommand : Implementations.IdleRpgActionBase  //: ICommand
    {
        public StatusCommand()
        {
            ActionCommand = ActionCommandEnum.Status;
            Cooldown = new TimeSpan(0, 0, 5);
        }

        

        //public override string Build()
        //{
        //    SetActionCommand(ActionCommand);
        //    SetRandomText();
        //    return base.Build();
        //}
    }
}
