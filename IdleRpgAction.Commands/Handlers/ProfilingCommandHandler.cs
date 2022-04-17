using IdleRpgAction.Application.GameCommands;
using IdleRpgAction.Domain.Interfaces;

namespace IdleRpgAction.Application.Handlers
{
    public class ProfilingCommandHandler : ICommandHandler<ProfileCommand>, ICommandHandler<Profile2Command>, ICommandHandler<MyClassCommand>, ICommandHandler<MoneyCommand>
    {
        public string BuildCommand(ProfileCommand command)
        {
            return "$" + command.ActionCommand + " " + command.Actor;
        }

        public string BuildCommand(Profile2Command command)
        {
            return "$" + command.ActionCommand + " " + command.Actor;
        }

        public string BuildCommand(MyClassCommand command)
        {
            return "$" + command.ActionCommand;
        }

        public string BuildCommand(MoneyCommand command)
        {
            return "$" + command.ActionCommand + " " + command.RandomText;
        }
    }
}
