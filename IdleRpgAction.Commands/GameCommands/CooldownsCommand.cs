using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class CooldownsCommand : Implementations.IdleRpgActionBase
    {
        public CooldownsCommand()
        {
            ActionCommand = ActionCommandEnum.Cooldowns;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
