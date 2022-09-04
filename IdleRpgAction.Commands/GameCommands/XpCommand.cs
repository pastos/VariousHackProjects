using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    ///////////////////////////////////    

    ////////////Adventuring
    public class XpCommand : Implementations.IdleRpgActionBase  //: ICommand
    {
        public XpCommand()
        {
            ActionCommand = ActionCommandEnum.Xp;
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
