using IdleRpgAction.Application.GameCommands;
using IdleRpgAction.Domain.Interfaces;

namespace IdleRpgAction.Application.Handlers
{
    public class BattleCommandHandler : ICommandHandler<BattleCommand>,
                                        ICommandHandler<RaidBattleCommand>,
                                        ICommandHandler<TournamentCommand>,
                                        ICommandHandler<HungerGamesCommand>
    {
        public string BuildCommand(BattleCommand command)
        {
            return "$" + command.ActionCommand + " " + command.Amount + " " + command.EnemyActor;
        }

        public string BuildCommand(RaidBattleCommand command)
        {
            return "$" + command.ActionCommand + " " + command.Amount + " " + command.EnemyActor;
        }

        public string BuildCommand(TournamentCommand command)
        {
            return "$" + command.ActionCommand + " " + command.Amount;
        }

        public string BuildCommand(HungerGamesCommand command)
        {
            return "$" + command.ActionCommand;
        }
    }
}
