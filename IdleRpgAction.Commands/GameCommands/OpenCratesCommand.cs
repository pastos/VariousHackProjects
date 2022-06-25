using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class OpenCratesCommand : Implementations.IdleRpgActionBase
    {
        public OpenCratesCommand()
        {
            ActionCommand = ActionCommandEnum.Open;
            Cooldown = new TimeSpan(0, 0, 4);
        }
    }
}
