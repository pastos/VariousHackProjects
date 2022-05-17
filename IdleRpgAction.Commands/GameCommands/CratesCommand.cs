using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class CratesCommand : Implementations.IdleRpgActionBase
    {
        public CratesCommand()
        {
            ActionCommand = ActionCommandEnum.Crates;
            Cooldown = new TimeSpan(0, 0, 4);
        }
    }
}
