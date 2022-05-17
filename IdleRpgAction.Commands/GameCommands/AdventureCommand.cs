using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class AdventureCommand : Implementations.IdleRpgActionBase
    {
        public AdventureCommand()
        {
            ActionCommand = ActionCommandEnum.Adventure;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
