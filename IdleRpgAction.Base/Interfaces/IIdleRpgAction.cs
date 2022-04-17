using IdleRpgAction.Domain.Enumerations;
using System;

namespace IdleRpgAction.Domain.Interfaces
{

    //public abstract class AbstractCommand : ICommand
    //{
    //    protected abstract ActionCommandEnum ActionCommand { get; set; }
    //    public TimeSpan Cooldown { get; set; }

    //    protected string BaseQuery;

    //    public virtual string Build()
    //    {
    //        BaseQuery = "$" + ActionCommand.ToString();
    //        return BaseQuery;
    //    }
    //}




    /////Profiling



    public interface IIdleRpgAction
    {
        string Name { get; }
        DateTime CooldownEnd { get; }
        bool IsCooldown { get; }

        string Build();
        IIdleRpgAction SetName(string name);
        IIdleRpgAction SetActionCommand(ActionCommandEnum actionCommand);
        IIdleRpgAction SetParameter(string param);
        IIdleRpgAction SetAmount(int amount);
        IIdleRpgAction SetItemId(int itemId);
        IIdleRpgAction SetFirstItem(int item);
        IIdleRpgAction SetSecondItem(int item);
        IIdleRpgAction SetActor(string actor);
        IIdleRpgAction SetCooldown(TimeSpan time);
        IIdleRpgAction SetRandomText(string text);
    }

    public interface IHandler<T>
    {

    }
    public class Command
    {

    }

    public interface ICommandParameters
    {
        string Name { get; set; }
        ActionCommandEnum ActionCommand { get; set; }
        int Amount { get; set; }
        int ItemId1 { get; set; }
        int ItemId2 { get; set; }
        string Actor { get; set; }
        TimeSpan Time { get; set; }
        string Text { get; set; }
    }

    //public class MyClass : IIdleRpgAction<Command>
    //{

    //}
}
