using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    /// <summary>
    /// $[doubleorsteal|dos] [user]
    /// </summary>
    public class DoubleOrStealCommand : Implementations.IdleRpgActionBase
    {
        public DoubleOrStealCommand()
        {
            ActionCommand = ActionCommandEnum.Dos;
            Cooldown = new TimeSpan(0, 0, 5);
        }
    }
}
