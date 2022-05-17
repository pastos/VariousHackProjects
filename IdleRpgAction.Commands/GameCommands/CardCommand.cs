using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    /// <summary>
    /// $[card|draw] [enemy] [money=0]
    /// </summary>
    public class CardCommand : Implementations.IdleRpgActionBase
    {
        public CardCommand()
        {
            ActionCommand = ActionCommandEnum.Card;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
