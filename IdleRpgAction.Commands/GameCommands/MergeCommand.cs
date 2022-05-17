using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class MergeCommand : Implementations.IdleRpgActionBase
    {
        public MergeCommand()
        {
            ActionCommand = ActionCommandEnum.Merge;
            Cooldown = new TimeSpan(0, 0, 4);
        }
    }
}
