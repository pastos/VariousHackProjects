using IdleRpgAction.Domain.Enumerations;
using IdleRpgAction.Domain.Interfaces;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    ///////////////////////////////////    

    ////////////Adventuring
    public class BoostersCommand : Implementations.IdleRpgActionBase  //: ICommand
    {
        public BoostersCommand()
        {
            ActionCommand = ActionCommandEnum.Boosters;
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
