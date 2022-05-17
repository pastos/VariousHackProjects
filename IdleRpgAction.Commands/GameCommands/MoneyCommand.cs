using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class MoneyCommand : Implementations.IdleRpgActionBase
    {
        public MoneyCommand()
        {
            ActionCommand = ActionCommandEnum.Money;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
