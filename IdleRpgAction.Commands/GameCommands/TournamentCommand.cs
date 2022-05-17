using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class TournamentCommand : Implementations.IdleRpgActionBase
    {
        public TournamentCommand()
        {
            ActionCommand = ActionCommandEnum.Tournament;
            Cooldown = new TimeSpan(0, 3, 0);
        }
    }
}
