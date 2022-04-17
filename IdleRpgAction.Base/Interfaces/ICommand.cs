using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Domain.Interfaces
{
    //public interface IIdleRpgAction<T> : IHandler<T>  where T : Command
    //{
    //    //string Name { get; }
    //    //DateTime CooldownEnd { get; }
    //    //bool IsCooldown { get; }        

    //    void Build(T obj, CommandParameters a);
    //    //IIdleRpgAction<T> SetName(string name);
    //    //IIdleRpgAction<T> SetActionCommand(ActionCommandEnum actionCommand);
    //    //IIdleRpgAction<T> SetAmount(int amount);
    //    //IIdleRpgAction<T> SetFirstItem(int item);
    //    //IIdleRpgAction<T> SetSecondItem(int item);
    //    //IIdleRpgAction<T> SetActor(string actor);
    //    //IIdleRpgAction<T> SetCooldown(TimeSpan time);
    //    //IIdleRpgAction<T> SetRandomText(string text);
    //}

    public interface ICommand
    {
        string RandomText { get; set; }
        ActionCommandEnum ActionCommand { get; }
        TimeSpan Cooldown { get; set; }
    }

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
