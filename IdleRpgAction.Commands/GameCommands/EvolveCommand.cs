using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class EvolveCommand : Implementations.IdleRpgActionBase  //: ICommand
    {
        public EvolveCommand()
        {
            ActionCommand = ActionCommandEnum.Evolve;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
