using IdleRpgAction.Application.GameCommands;
using IdleRpgAction.Domain.Interfaces;

namespace IdleRpgAction.Application.Handlers
{
    public class DailyQuestCommandHandler : ICommandHandler<DailyCommand>,
                                            ICommandHandler<PrayCommand>,
                                            ICommandHandler<VoteCommand>,
                                            ICommandHandler<StealCommand>
    {
        public string BuildCommand(DailyCommand command)
        {
            return "$" + command.ActionCommand + " " + command.RandomText;
        }

        public string BuildCommand(PrayCommand command)
        {
            return "$" + command.ActionCommand + " " + command.RandomText;
        }

        public string BuildCommand(VoteCommand command)
        {
            return "$" + command.ActionCommand + " " + command.RandomText;
        }

        public string BuildCommand(StealCommand command)
        {
            return "$" + command.ActionCommand + " " + command.RandomText;
        }
    }
}
