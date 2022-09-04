using IdleRpgAction.Application.GameCommands;
using IdleRpgAction.Domain.Enumerations;
using IdleRpgActionWinForm.Buttons;
using IdleRpgActionWinForm.Buttons.BaseClass;
using System.Collections.Generic;
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
            List<ActionButtonBase> controls = new List<ActionButtonBase>();
            controls.Add(new ActionButton(new ProfileCommand()));
            controls.Add(new ActionButton(new Profile2Command()));
            controls.Add(new ActionButton(new MyClassCommand()));
            controls.Add(new ActionButton(new MoneyCommand()));
            controls.Add(new ActionButton(new XpCommand()));
            controls.Add(new ActionButton(new EvolveCommand()));

            foreach (var item in controls)
            {
                UpdateTargetAppEvent += item.UpdateTargetApplication;
                flowLayoutProfile.Controls.Add(item);
            }
        }

        private void PopulateTabAdventure()
        {
            List<ActionButtonBase> controls = new List<ActionButtonBase>();
            controls.Add(new ActionButton(new StatusCommand()));
            controls.Add(new ActionButtonWithOneChoice(new AdventureCommand()));
            controls.Add(new ActionButton(new ActiveAdventureCommand()));
            controls.Add(new ActionButtonWithDropdownChoice(new PurchaseBonusCommand(), EnumerationChoserEnum.BonusChoicesEnum));
            controls.Add(new ActionButtonWithDropdownChoice(new ActivateBonusCommand(), EnumerationChoserEnum.BonusChoicesEnum));
            controls.Add(new ActionButton(new BoostersCommand()));

            foreach (var item in controls)
            {
                UpdateTargetAppEvent += item.UpdateTargetApplication;
                flowLayoutAdventure.Controls.Add(item);
            }
        }

        private void PopulateTabDailyQuest()
        {
            List<ActionButtonBase> controls = new List<ActionButtonBase>();
            controls.Add(new ActionButton(new CooldownsCommand()));
            controls.Add(new ActionButtonWithReminder(new DailyCommand()));
            controls.Add(new ActionButton(new FavorCommand()));
            controls.Add(new ActionButtonWithReminder(new PrayCommand()));
            controls.Add(new ActionButtonWithReminder(new VoteCommand()));
            controls.Add(new ActionButtonWithReminder(new StealCommand()));
            controls.Add(new ActionButtonWithTwoChoicesAndText(new ReminderCommand()));

            foreach (var item in controls)
            {
                UpdateTargetAppEvent += item.UpdateTargetApplication;
                flowLayoutDailyQuest.Controls.Add(item);
            }
        }

        private void PopulateTabBattles()
        {
            List<ActionButtonBase> controls = new List<ActionButtonBase>();
            controls.Add(new ActionButtonWithOneChoiceAndActor(new BattleCommand()));
            controls.Add(new ActionButtonWithOneChoiceAndActor(new RaidBattleCommand()));
            controls.Add(new ActionButtonWithOneChoiceAndActor(new HungerGamesCommand()));
            controls.Add(new ActionButtonWithOneChoice(new TournamentCommand()));

            foreach (var item in controls)
            {
                UpdateTargetAppEvent += item.UpdateTargetApplication;
                flowLayoutBattle.Controls.Add(item);
            }
        }

        private void PopulateTabInventoring()
        {
            List<ActionButtonBase> controls = new List<ActionButtonBase>();
            controls.Add(new ActionButton(new InventoryCommand()));
            controls.Add(new ActionButtonWithTwoChoices(new MergeCommand()));
            controls.Add(new ActionButtonWithOneChoice(new UpgradeCommand()));
            controls.Add(new ActionButton(new CratesCommand()));
            controls.Add(new ActionButtonWithDropdownChoiceAndOneChoice(new OpenCratesCommand(), EnumerationChoserEnum.CratesRarityEnum));
            controls.Add(new ActionButton(new LootCommand()));
            controls.Add(new ActionButton(new ExchangeCommand()));

            foreach (var item in controls)
            {
                UpdateTargetAppEvent += item.UpdateTargetApplication;
                flowLayoutInventoring.Controls.Add(item);
            }
        }

        private void PopulateTabShopping()
        {
            List<ActionButtonBase> controls = new List<ActionButtonBase>();
            controls.Add(new ActionButtonWithOneChoice(new MerchantCommand()));
            controls.Add(new ActionButtonWithTwoChoices(new SellCommand()));
            controls.Add(new ActionButtonWithOneChoice(new UpgradeCommand()));
            controls.Add(new ActionButtonWithDropdownChoiceAndOneChoice(new ShopCommand(), EnumerationChoserEnum.WeaponEnum));

            foreach (var item in controls)
            {
                UpdateTargetAppEvent += item.UpdateTargetApplication;
                flowLayoutShopping.Controls.Add(item);
            }
        }

        private void PopulateTabGamble()
        {
            List<ActionButtonBase> controls = new List<ActionButtonBase>();
            controls.Add(new ActionButtonWithOneChoice(new BlackjackCommand()));
            controls.Add(new ActionButtonWithOneChoiceAndActor(new CardCommand()));
            controls.Add(new ActionButtonWithDropdownChoiceAndOneChoice(new FlipCommand(), EnumerationChoserEnum.CoinSideEnum));
            controls.Add(new ActionButtonWithOneChoiceAndDropdownChoiceAndOneChoice(new RouletteCommand(), EnumerationChoserEnum.RouletteGameEnum));
            controls.Add(new ActionButtonWithOneChoiceAndActor(new BetCommand()));
            controls.Add(new ActionButtonWithOneChoiceAndActor(new DoubleOrStealCommand()));
            controls.Add(new ActionButton(new RouletteTableCommand()));

            foreach (var item in controls)
            {
                UpdateTargetAppEvent += item.UpdateTargetApplication;
                flowLayoutGamble.Controls.Add(item);
            }
        }

        private void PopulateTabGuild()
        {
            List<ActionButtonBase> controls = new List<ActionButtonBase>();
            controls.Add(new ActionButton(new GuildCommand()));
            controls.Add(new ActionButtonWithOneChoice(new GuildInvestCommand()));
            controls.Add(new ActionButtonWithOneChoiceAndActor(new GuildPayCommand()));
            controls.Add(new ActionButton(new GuildUpgradeCommand()));
            controls.Add(new ActionButton(new GuildAdventureCommand()));

            foreach (var item in controls)
            {
                UpdateTargetAppEvent += item.UpdateTargetApplication;
                flowLayoutGuild.Controls.Add(item);
            }
        }
    }
}