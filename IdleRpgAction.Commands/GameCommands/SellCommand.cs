using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class SellCommand : Implementations.IdleRpgActionBase
    {
        public SellCommand()
        {
            ActionCommand = ActionCommandEnum.Sell;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
