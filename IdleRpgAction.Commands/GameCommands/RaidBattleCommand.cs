using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class RaidBattleCommand : Implementations.IdleRpgActionBase
    {
        public RaidBattleCommand()
        {
            ActionCommand = ActionCommandEnum.RaidBattle;
            Cooldown = new TimeSpan(0, 3, 0);
        }
    }
}
