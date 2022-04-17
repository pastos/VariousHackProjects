using IdleRpgAction.Application.GameCommands;
using IdleRpgAction.Domain.Interfaces;

namespace IdleRpgAction.Application.Handlers
{
    public class InventoringCommandHandler : ICommandHandler<InventoryCommand>,
                                             ICommandHandler<SellCommand>,
                                             ICommandHandler<MerchantCommand>,
                                             ICommandHandler<UpgradeCommand>,
                                             ICommandHandler<MergeCommand>,
                                             ICommandHandler<CratesCommand>
    {
        public string BuildCommand(InventoryCommand command)
        {
            return "$" + command.ActionCommand;
        }

        public string BuildCommand(SellCommand command)
        {
            return "$" + command.ActionCommand + command.ItemId + " " + command.Price;
        }

        public string BuildCommand(MerchantCommand command)
        {
            return "$" + command.ActionCommand + " " + command.ItemId;
        }

        public string BuildCommand(UpgradeCommand command)
        {
            return "$" + command.ActionCommand + " " + command.ItemId;
        }

        public string BuildCommand(MergeCommand command)
        {
            return "$" + command.ActionCommand + " " + command.ItemId1 + " " + command.ItemId2;
        }

        public string BuildCommand(CratesCommand command)
        {
            return "$" + command.ActionCommand;
        }
    }
}
