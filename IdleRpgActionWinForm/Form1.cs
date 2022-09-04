using IdleRpgAction.Application.GameCommands;
using IdleRpgAction.Domain.Enumerations;
using IdleRpgActionWinForm.Buttons;
using System.Windows.Forms;

namespace IdleRpgActionWinForm
{
    public partial class Form1 : Form
    {
        public delegate void UpdateTargetApplicationPublishEvent(string targetApplication);
        public UpdateTargetApplicationPublishEvent UpdateTargetAppEvent = delegate { };

        public Form1()
        {
            InitializeComponent();
            //RandomTexts = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(File.ReadAllText(@"RandomTexts.json"));
            PopulateControls();
            UpdateTargetAppEvent(txtApplicationName.Text);
        }

        private void txtApplicationName_TextChanged(object sender, System.EventArgs e)
        {
            UpdateTargetAppEvent(txtApplicationName.Text);
        }

        //Dictionary<string, Dictionary<string, string>> RandomTexts;

        private void PopulateControls()
        {
            PopulateTabProfile();
            PopulateTabAdventure();
            PopulateTabDailyQuest();
            PopulateTabBattles();
            PopulateTabInventoring();
            PopulateTabShopping();
            PopulateTabGamble();
            PopulateTabGuild();
        }

        private void PopulateTabProfile()
        {
            var action1 = new ActionButton(new ProfileCommand());
            var action2 = new ActionButton(new Profile2Command());
            var action3 = new ActionButton(new MyClassCommand());
            var action4 = new ActionButton(new MoneyCommand());
            var action5 = new ActionButton(new XpCommand());
            var action6 = new ActionButton(new EvolveCommand());

            UpdateTargetAppEvent += action1.UpdateTargetApplication;
            UpdateTargetAppEvent += action2.UpdateTargetApplication;
            UpdateTargetAppEvent += action3.UpdateTargetApplication;
            UpdateTargetAppEvent += action4.UpdateTargetApplication;
            UpdateTargetAppEvent += action5.UpdateTargetApplication;
            UpdateTargetAppEvent += action6.UpdateTargetApplication;

            flowLayoutProfile.Controls.Add(action1);
            flowLayoutProfile.Controls.Add(action2);
            flowLayoutProfile.Controls.Add(action3);
            flowLayoutProfile.Controls.Add(action4);
            flowLayoutProfile.Controls.Add(action5);
            flowLayoutProfile.Controls.Add(action6);
        }

        private void PopulateTabAdventure()
        {
            var statusAction = new ActionButton(new StatusCommand());
            var action1 = new ActionButtonWithOneChoice(new AdventureCommand());
            var action2 = new ActionButton(new ActiveAdventureCommand());
            var action3 = new ActionButtonWithDropdownChoice(new PurchaseBonusCommand(), EnumerationChoserEnum.BonusChoicesEnum);
            var action4 = new ActionButtonWithDropdownChoice(new ActivateBonusCommand(), EnumerationChoserEnum.BonusChoicesEnum);
            var action5 = new ActionButton(new BoostersCommand());

            UpdateTargetAppEvent += statusAction.UpdateTargetApplication;
            UpdateTargetAppEvent += action1.UpdateTargetApplication;
            UpdateTargetAppEvent += action3.UpdateTargetApplication;
            UpdateTargetAppEvent += action4.UpdateTargetApplication;
            UpdateTargetAppEvent += action5.UpdateTargetApplication;

            flowLayoutAdventure.Controls.Add(statusAction);
            flowLayoutAdventure.Controls.Add(action1);
            flowLayoutAdventure.Controls.Add(action2);
            flowLayoutAdventure.Controls.Add(action3);
            flowLayoutAdventure.Controls.Add(action4);
            flowLayoutAdventure.Controls.Add(action5);
        }

        private void PopulateTabDailyQuest()
        {
            var action1 = new ActionButton(new CooldownsCommand());
            var action2 = new ActionButtonWithReminder(new DailyCommand());
            var action3 = new ActionButton(new FavorCommand());
            var action4 = new ActionButtonWithReminder(new PrayCommand());
            var action5 = new ActionButtonWithReminder(new VoteCommand());
            var action6 = new ActionButtonWithReminder(new StealCommand());
            var action7 = new ActionButtonWithTwoChoicesAndText(new ReminderCommand());

            UpdateTargetAppEvent += action1.UpdateTargetApplication;
            UpdateTargetAppEvent += action2.UpdateTargetApplication;
            UpdateTargetAppEvent += action3.UpdateTargetApplication;
            UpdateTargetAppEvent += action4.UpdateTargetApplication;
            UpdateTargetAppEvent += action5.UpdateTargetApplication;
            UpdateTargetAppEvent += action6.UpdateTargetApplication;
            UpdateTargetAppEvent += action7.UpdateTargetApplication;

            flowLayoutDailyQuest.Controls.Add(action1);
            flowLayoutDailyQuest.Controls.Add(action2);
            flowLayoutDailyQuest.Controls.Add(action3);
            flowLayoutDailyQuest.Controls.Add(action4);
            flowLayoutDailyQuest.Controls.Add(action5);
            flowLayoutDailyQuest.Controls.Add(action6);
            flowLayoutDailyQuest.Controls.Add(action7);
        }

        private void PopulateTabBattles()
        {
            var action1 = new ActionButtonWithOneChoiceAndActor(new BattleCommand());
            var action2 = new ActionButtonWithOneChoiceAndActor(new RaidBattleCommand());
            var action3 = new ActionButtonWithOneChoiceAndActor(new HungerGamesCommand());
            var action4 = new ActionButtonWithOneChoice(new TournamentCommand());

            UpdateTargetAppEvent += action1.UpdateTargetApplication;
            UpdateTargetAppEvent += action2.UpdateTargetApplication;
            UpdateTargetAppEvent += action3.UpdateTargetApplication;
            UpdateTargetAppEvent += action4.UpdateTargetApplication;

            flowLayoutBattle.Controls.Add(action1);
            flowLayoutBattle.Controls.Add(action2);
            flowLayoutBattle.Controls.Add(action3);
            flowLayoutBattle.Controls.Add(action4);
        }

        private void PopulateTabInventoring()
        {
            var action1 = new ActionButton(new InventoryCommand());
            var action2 = new ActionButtonWithTwoChoices(new MergeCommand());
            var action3 = new ActionButtonWithOneChoice(new UpgradeCommand());
            var action4 = new ActionButton(new CratesCommand());
            var action5 = new ActionButtonWithDropdownChoiceAndOneChoice(new OpenCratesCommand(), EnumerationChoserEnum.CratesRarityEnum);

            UpdateTargetAppEvent += action1.UpdateTargetApplication;
            UpdateTargetAppEvent += action2.UpdateTargetApplication;
            UpdateTargetAppEvent += action3.UpdateTargetApplication;
            UpdateTargetAppEvent += action4.UpdateTargetApplication;
            UpdateTargetAppEvent += action5.UpdateTargetApplication;

            flowLayoutInventoring.Controls.Add(action1);
            flowLayoutInventoring.Controls.Add(action2);
            flowLayoutInventoring.Controls.Add(action3);
            flowLayoutInventoring.Controls.Add(action4);
            flowLayoutInventoring.Controls.Add(action5);
        }

        private void PopulateTabShopping()
        {
            var action1 = new ActionButtonWithOneChoice(new MerchantCommand());
            var action2 = new ActionButtonWithTwoChoices(new SellCommand());
            var action3 = new ActionButtonWithOneChoice(new UpgradeCommand());
            var action4 = new ActionButtonWithDropdownChoiceAndOneChoice(new ShopCommand(), EnumerationChoserEnum.WeaponEnum);

            UpdateTargetAppEvent += action1.UpdateTargetApplication;
            UpdateTargetAppEvent += action2.UpdateTargetApplication;
            UpdateTargetAppEvent += action3.UpdateTargetApplication;
            UpdateTargetAppEvent += action4.UpdateTargetApplication;

            flowLayoutShopping.Controls.Add(action1);
            flowLayoutShopping.Controls.Add(action2);
            flowLayoutShopping.Controls.Add(action3);
            flowLayoutShopping.Controls.Add(action4);
        }

        private void PopulateTabGamble()
        {
            var action1 = new ActionButtonWithOneChoice(new BlackjackCommand());
            var action2 = new ActionButtonWithOneChoiceAndActor(new CardCommand());
            var action3 = new ActionButtonWithDropdownChoiceAndOneChoice(new FlipCommand(), EnumerationChoserEnum.CoinSideEnum);
            var action4 = new ActionButtonWithOneChoiceAndDropdownChoiceAndOneChoice(new RouletteCommand(), EnumerationChoserEnum.RouletteGameEnum);
            var action5 = new ActionButtonWithOneChoiceAndActor(new BetCommand());
            var action6 = new ActionButtonWithOneChoiceAndActor(new DoubleOrStealCommand());
            var action7 = new ActionButton(new RouletteTableCommand());

            UpdateTargetAppEvent += action1.UpdateTargetApplication;
            UpdateTargetAppEvent += action2.UpdateTargetApplication;
            UpdateTargetAppEvent += action3.UpdateTargetApplication;
            UpdateTargetAppEvent += action4.UpdateTargetApplication;
            UpdateTargetAppEvent += action5.UpdateTargetApplication;
            UpdateTargetAppEvent += action6.UpdateTargetApplication;
            UpdateTargetAppEvent += action7.UpdateTargetApplication;

            flowLayoutGamble.Controls.Add(action1);
            flowLayoutGamble.Controls.Add(action2);
            flowLayoutGamble.Controls.Add(action3);
            flowLayoutGamble.Controls.Add(action4);
            flowLayoutGamble.Controls.Add(action5);
            flowLayoutGamble.Controls.Add(action6);
            flowLayoutGamble.Controls.Add(action7);
        }

        private void PopulateTabGuild()
        {
            var action1 = new ActionButton(new GuildCommand());
            var action2 = new ActionButtonWithOneChoice(new GuildInvestCommand());
            var action3 = new ActionButtonWithOneChoiceAndActor(new GuildPayCommand());
            var action4 = new ActionButton(new GuildUpgradeCommand());
            var action5 = new ActionButton(new GuildAdventureCommand());


            UpdateTargetAppEvent += action1.UpdateTargetApplication;
            UpdateTargetAppEvent += action2.UpdateTargetApplication;
            UpdateTargetAppEvent += action3.UpdateTargetApplication;
            UpdateTargetAppEvent += action4.UpdateTargetApplication;
            UpdateTargetAppEvent += action5.UpdateTargetApplication;

            flowLayoutGuild.Controls.Add(action1);
            flowLayoutGuild.Controls.Add(action2);
            flowLayoutGuild.Controls.Add(action3);
            flowLayoutGuild.Controls.Add(action4);
            flowLayoutGuild.Controls.Add(action5);
        }
    }
}
