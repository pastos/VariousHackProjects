namespace IdleRpgAction.Domain.Interfaces
{
    public interface ICommandHandler<T> where T : ICommand
    {
        string BuildCommand(T command);
    }

    //public interface ICommandHandler
    //{
        
    //}

    //public interface IIdleRpgAction
    //{
    //    string Name { get; }
    //    DateTime CooldownEnd { get; }
    //    bool IsCooldown { get; }

    //    string Build();
    //    IIdleRpgAction SetName(string name);
    //    IIdleRpgAction SetActionCommand(ActionCommandEnum actionCommand);
    //    IIdleRpgAction SetAmount(int amount);
    //    IIdleRpgAction SetFirstItem(int item);
    //    IIdleRpgAction SetSecondItem(int item);
    //    IIdleRpgAction SetActor(string actor);
    //    IIdleRpgAction SetCooldown(TimeSpan time);
    //    IIdleRpgAction SetRandomText(string text);
    //}

    //public interface IHandler<T>
    //{

    //}
    //public class Command
    //{

    //}

    //public interface ICommandParameters
    //{
    //    string Name { get; set; }
    //    ActionCommandEnum ActionCommand { get; set; }
    //    int Amount { get; set; }
    //    int ItemId1 { get; set; }
    //    int ItemId2 { get; set; }
    //    string Actor { get; set; }
    //    TimeSpan Time { get; set; }
    //    string Text { get; set; }
    //}

    //public class MyClass : IIdleRpgAction<Command>
    //{

    //}
}
