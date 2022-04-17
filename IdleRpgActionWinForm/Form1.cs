using IdleRpgAction.Application.GameCommands;
using IdleRpgAction.Application.Handlers;
using IdleRpgAction.Domain.Interfaces;
using IdleRpgActionWinForm.Buttons;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace IdleRpgActionWinForm
{
    public partial class Form1 : Form
    {
        //private IIdleRpgAction _idleRpgAction;
        public Form1()
        {
            InitializeComponent();
            //_idleRpgAction = idleRpgAction;
            RandomTexts = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(File.ReadAllText(@"RandomTexts.json"));
            PopulateControls();

            // deserialize JSON directly from a file

        }

        Dictionary<string, Dictionary<string, string>> RandomTexts;

        private void PopulateControls()
        {
            //PopulateTabProfile();
            PopulateTabAdventure();
            //PopulateTabDailyQuest();
            //PopulateTabBattles();
            //PopulateTabInventoring();
            //PopulateTabShopping();
            //PopulateTabGamble();
        }

        //private void PopulateTabProfile()
        //{
        //    var commandHandler = new BattleCommandHandler();
        //    var command = new BattleCommand();
        //    commandHandler.BuildCommand(command);

        //    var profileAction = new ActionButton(command);
        //    profileAction.IdleRpgAction = _idleRpgAction;
        //    var profile2Action = new ActionButton(Profiling.Profile2);
        //    profile2Action.IdleRpgAction = _idleRpgAction;
        //    var myclassAction = new ActionButton(Profiling.MyClass);
        //    myclassAction.IdleRpgAction = _idleRpgAction;
        //    var money = new ActionButton(Profiling.Money);
        //    money.IdleRpgAction = _idleRpgAction;

        //    flowLayoutProfile.Controls.Add(profileAction);
        //    flowLayoutProfile.Controls.Add(profile2Action);
        //    flowLayoutProfile.Controls.Add(myclassAction);
        //    flowLayoutProfile.Controls.Add(money);
        //}

        //private ICommandHandler<StatusCommand> commandHandler;
        ICommandHandler<ICommand> commandHandler;
        private void PopulateTabAdventure()
        {
            //    //List<UserControl> controls = new List<UserControl>();
            //    //controls.Add(new ActionButton(Adventuring.Status));
            //    //controls.Add( new ActionButtonWithOneChoice(Adventuring.Adventure));
            //    //controls.Add( new ActionButton(Adventuring.Cooldowns));
            //    //controls.Add( new ActionButton(Adventuring.Adventures));
            //    //controls.Add( new ActionButton(Adventuring.Money));
            //    //controls.Add(new ActionButton(Adventuring.ActiveAdventure));

            //    //foreach (var item in controls)
            //    //{
            //    //    var temp = item as ActionButton;
            //    //    temp.IdleRpgAction = _idleRpgAction;
            //    //    flowLayoutAdventure.Controls.Add(temp);
            //    //}

            //commandHandler = new AdventureCommandHandler();
            StatusCommand command = new StatusCommand();
            //    //ICommandHandler<StatusCommand> commandHandler = new AdventureCommandHandler();
            //    //ICommandHandler<ICommand> commandHandler2 = new AdventureCommandHandler();
            //    AdventureCommandHandler commandHandler = new AdventureCommandHandler();
            //commandHandler = new AdventureCommandHandler();
            var action1 = new ActionButton( IdleRpgAction.Domain.Enumerations.ActionCommandEnum.Status);
            //var action1a = new ActionButton(commandHandler, command);



            //    var action2 = new ActionButtonWithOneChoice(Adventuring.Adventure);
            //    var action3 = new ActionButton(Adventuring.Cooldowns);
            //    var action4 = new ActionButton(Adventuring.Adventures);
            //    var action5 = new ActionButton(Adventuring.ActiveAdventure);

            //    action1.IdleRpgAction = _idleRpgAction;
            //    action2.IdleRpgAction = _idleRpgAction;
            //    action3.IdleRpgAction = _idleRpgAction;
            //    action4.IdleRpgAction = _idleRpgAction;
            //    action5.IdleRpgAction = _idleRpgAction;

            flowLayoutAdventure.Controls.Add(action1);
            //    flowLayoutAdventure.Controls.Add(action2);
            //    flowLayoutAdventure.Controls.Add(action3);
            //    flowLayoutAdventure.Controls.Add(action4);
            //    flowLayoutAdventure.Controls.Add(action5);
            //}

            //private void PopulateTabDailyQuest()
            //{
            //    var action1 = new ActionButton(DailyQuest.Daily);
            //    var action2 = new ActionButton(DailyQuest.Favor);
            //    var action3 = new ActionButton(DailyQuest.Pray, RandomTexts);
            //    var action4 = new ActionButton(DailyQuest.Vote);
            //    var action5 = new ActionButton(DailyQuest.Steal, RandomTexts);

            //    action1.IdleRpgAction = _idleRpgAction;
            //    action2.IdleRpgAction = _idleRpgAction;
            //    action3.IdleRpgAction = _idleRpgAction;
            //    action4.IdleRpgAction = _idleRpgAction;
            //    action5.IdleRpgAction = _idleRpgAction;

            //    flowLayoutDailyQuest.Controls.Add(action1);
            //    flowLayoutDailyQuest.Controls.Add(action2);
            //    flowLayoutDailyQuest.Controls.Add(action3);
            //    flowLayoutDailyQuest.Controls.Add(action4);
            //    flowLayoutDailyQuest.Controls.Add(action5);
        }

        //private void PopulateTabBattles()
        //{
        //    var action1 = new ActionButtonWithOneChoiceAndActor(Battles.Battle);
        //    var action2 = new ActionButtonWithOneChoiceAndActor(Battles.RaidBattle);
        //    var action3 = new ActionButtonWithOneChoiceAndActor(Battles.Hungergames);
        //    var action4 = new ActionButtonWithOneChoice(Battles.Tournament);

        //    action1.IdleRpgAction = _idleRpgAction;
        //    action2.IdleRpgAction = _idleRpgAction;
        //    action3.IdleRpgAction = _idleRpgAction;
        //    action4.IdleRpgAction = _idleRpgAction;

        //    flowLayoutBattle.Controls.Add(action1);
        //    flowLayoutBattle.Controls.Add(action2);
        //    flowLayoutBattle.Controls.Add(action3);
        //    flowLayoutBattle.Controls.Add(action4);
        //}

        //private void PopulateTabInventoring()
        //{
        //    var action1 = new ActionButton(Inventoring.Inventory);
        //    var action2 = new ActionButtonWithTwoChoices(Inventoring.Merge);
        //    var action3 = new ActionButtonWithOneChoice(Inventoring.Upgrade);
        //    var action4 = new ActionButtonWithOneChoice(Inventoring.Crates);

        //    action1.IdleRpgAction = _idleRpgAction;
        //    action2.IdleRpgAction = _idleRpgAction;
        //    action3.IdleRpgAction = _idleRpgAction;
        //    action4.IdleRpgAction = _idleRpgAction;

        //    flowLayoutInventoring.Controls.Add(action1);
        //    flowLayoutInventoring.Controls.Add(action2);
        //    flowLayoutInventoring.Controls.Add(action3);
        //    flowLayoutInventoring.Controls.Add(action4);
        //}

        //private void PopulateTabShopping()
        //{
        //    var action1 = new ActionButtonWithOneChoice(Shopping.Merchant);
        //    var action2 = new ActionButtonWithTwoChoices(Shopping.Sell);
        //    var action3 = new ActionButtonWithOneChoice(Inventoring.Upgrade);

        //    action1.IdleRpgAction = _idleRpgAction;
        //    action2.IdleRpgAction = _idleRpgAction;
        //    action3.IdleRpgAction = _idleRpgAction;

        //    flowLayoutShopping.Controls.Add(action1);
        //    flowLayoutShopping.Controls.Add(action2);
        //    flowLayoutShopping.Controls.Add(action3);
        //}

        //private void PopulateTabGamble()
        //{
        //    var action1 = new ActionButtonWithOneChoice(Gamble.Blackjack);
        //    var action2 = new ActionButtonWithOneChoiceAndActor(Gamble.Card);
        //    var action3 = new ActionButtonWithOneChoice(Gamble.Flip);
        //    var action4 = new ActionButtonWithTwoChoices(Gamble.Roulette);
        //    var action5 = new ActionButtonWithOneChoiceAndActor(Gamble.Bet);
        //    var action6 = new ActionButtonWithOneChoiceAndActor(Gamble.Dos);
        //    var action7 = new ActionButton(Gamble.Roulette_Table);

        //    action1.IdleRpgAction = _idleRpgAction;
        //    action2.IdleRpgAction = _idleRpgAction;
        //    action3.IdleRpgAction = _idleRpgAction;
        //    action4.IdleRpgAction = _idleRpgAction;
        //    action5.IdleRpgAction = _idleRpgAction;
        //    action6.IdleRpgAction = _idleRpgAction;
        //    action7.IdleRpgAction = _idleRpgAction;

        //    flowLayoutGamble.Controls.Add(action1);
        //    flowLayoutGamble.Controls.Add(action2);
        //    flowLayoutGamble.Controls.Add(action3);
        //    flowLayoutGamble.Controls.Add(action4);
        //    flowLayoutGamble.Controls.Add(action5);
        //    flowLayoutGamble.Controls.Add(action6);
        //    flowLayoutGamble.Controls.Add(action7);
        //}
    }
}
