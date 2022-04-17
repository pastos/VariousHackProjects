using IdleRpgAction.Application.GameCommands;
using IdleRpgAction.Domain.Interfaces;

namespace IdleRpgAction.Application.Handlers
{
    public class AdventureCommandHandler : ICommandHandler<CooldownsCommand>, ICommandHandler<AdventuresCommand>, ICommandHandler<ActiveAdventureCommand>, ICommandHandler<StatusCommand>
    {
        public string BuildCommand(StatusCommand command)
        {
            return "$" + command.ActionCommand + " " + command.RandomText;
        }

        public string BuildCommand(CooldownsCommand command)
        {
            return "$" + command.ActionCommand + " " + command.RandomText;
        }

        public string BuildCommand(AdventuresCommand command)
        {
            return "$" + command.ActionCommand + " " + command.RandomText;
        }

        public string BuildCommand(ActiveAdventureCommand command)
        {
            return "$" + command.ActionCommand + " " + command.RandomText;
        }
    }
}
