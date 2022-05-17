using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class VoteCommand : Implementations.IdleRpgActionBase
    {
        public VoteCommand()
        {
            ActionCommand = ActionCommandEnum.Vote;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
