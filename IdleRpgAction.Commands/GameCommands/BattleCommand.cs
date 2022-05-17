using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class BattleCommand : Implementations.IdleRpgActionBase
    {
        public BattleCommand()
        {
            ActionCommand = ActionCommandEnum.Battle;
            Cooldown = new TimeSpan(0, 3, 0);
        }
    }
}
