using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class BlackjackCommand : Implementations.IdleRpgActionBase
    {
        public BlackjackCommand()
        {
            ActionCommand = ActionCommandEnum.BlackJack;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
