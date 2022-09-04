using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    ///////////////////////////////////    

    ////////////Adventuring
    public class ExchangeCommand : Implementations.IdleRpgActionBase  //: ICommand
    {
        public ExchangeCommand()
        {
            ActionCommand = ActionCommandEnum.Exchange;
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
