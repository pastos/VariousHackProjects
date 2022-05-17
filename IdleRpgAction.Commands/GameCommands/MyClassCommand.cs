using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class MyClassCommand : Implementations.IdleRpgActionBase
    {
        public MyClassCommand()
        {
            ActionCommand = ActionCommandEnum.MyClass;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
