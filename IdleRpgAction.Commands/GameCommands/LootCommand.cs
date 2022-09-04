using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    ///////////////////////////////////    

    ////////////Adventuring
    public class LootCommand : Implementations.IdleRpgActionBase  //: ICommand
    {
        public LootCommand()
        {
            ActionCommand = ActionCommandEnum.Loot;
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
