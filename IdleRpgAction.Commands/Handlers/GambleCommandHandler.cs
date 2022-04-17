using IdleRpgAction.Application.GameCommands;
using IdleRpgAction.Domain.Interfaces;

namespace IdleRpgAction.Application.Handlers
{
    public class GambleCommandHandler : ICommandHandler<BlackjackCommand>, ICommandHandler<CardCommand>, ICommandHandler<FlipCommand>, ICommandHandler<RouletteCommand>,
                                        ICommandHandler<BetCommand>, ICommandHandler<DoubleOrStealCommand>, ICommandHandler<RouletteTableCommand>
    {
        public string BuildCommand(BlackjackCommand command)
        {
            return "$" + command.ActionCommand + " " + command.BetAmount.ToString();
        }

        public string BuildCommand(CardCommand command)
        {
            return "$" + command.ActionCommand + " " + command.BetAmount.ToString();
        }

        public string BuildCommand(FlipCommand command)
        {
            return "$" + command.ActionCommand + " " + command.CoinSide.ToString() + " " + command.BetAmount.ToString();
        }

        public string BuildCommand(RouletteCommand command)
        {
            return "$" + command.ActionCommand + " " + command.BetAmount.ToString() + " " + command.RouletteGame.ToString() + " " + command.BetAmount.ToString();
        }

        public string BuildCommand(BetCommand command)
        {
            return "$" + command.ActionCommand + " " + command.DiceSides + " " + command.BetNumber.ToString() + " " + command.BetAmount.ToString();
        }

        public string BuildCommand(DoubleOrStealCommand command)
        {
            return "$" + command.ActionCommand + " " + command.Actor + " " + command.BetAmount.ToString();
        }

        public string BuildCommand(RouletteTableCommand command)
        {
            return "$" + command.ActionCommand;
        }
    }
}
