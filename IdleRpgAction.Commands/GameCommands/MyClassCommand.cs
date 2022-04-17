using IdleRpgAction.Domain.Enumerations;
using IdleRpgAction.Domain.Interfaces;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class MyClassCommand : ICommand
    {
        public TimeSpan Cooldown { get; set; }
        public ActionCommandEnum ActionCommand { get; private set; }
        public string RandomText { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public MyClassCommand()
        {
            ActionCommand = ActionCommandEnum.MyClass;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
