using System.ComponentModel;

namespace IdleRpgAction.Domain.Enumerations
{
    public enum ActionCommandEnum
    {
        [Description("$status")]
        Status,
        [Description("$adventure")]
        Adventure,
        [Description("$adventures")]
        Adventures,
        [Description("$timings")]
        Cooldowns,
        [Description("$pray")]
        Pray,
        [Description("$favor")]
        Favor,
        [Description("$money")]
        Money,
        [Description("$daily")]
        Daily,
        [Description("$vote")]
        Vote,
        [Description("$battle")]
        Battle,
        [Description("$raidbattle")]
        RaidBattle,
        [Description("$tournament")]
        Tournament,
        [Description("$hungergames")]
        Hungergames,
        [Description("$profile")]
        Profile,
        [Description("$profile2")]
        Profile2,
        [Description("$blackjack")]
        BlackJack,
        [Description("$roulette")]
        Roulette,
        [Description("$flip")]
        Flip,
        [Description("$merge")]
        Merge,
        [Description("$upgrade")]
        Upgrade,
        [Description("$steal")]
        Steal,
        [Description("$inventory")]
        Inventory,
        [Description("$crates")]
        Crates,
        [Description("$sell")]
        Sell,
        [Description("$merchant")]
        Merchant,
        [Description("$shop")]
        Shop,
        [Description("$trade")]
        Trade,
        [Description("$card")]
        Card,
        [Description("$myclass")]
        MyClass,
        [Description("$bet")]
        Bet,
        [Description("$dos")]
        Dos,
        [Description("$roulette table")]
        Roulette_Table,
        [Description("$cancel")]
        Cancel,
        [Description("$activeadventure")]
        ActiveAdventure
    }
    public class Profiling
    {
        [Description("$profile")]
        public static ActionCommandEnum Profile { get; } = ActionCommandEnum.Profile;
        [Description("$profile2")]
        public static ActionCommandEnum Profile2 { get; } = ActionCommandEnum.Profile2;
        public static ActionCommandEnum MyClass { get; } = ActionCommandEnum.MyClass;
        [Description("$money")]
        public static ActionCommandEnum Money { get; } = ActionCommandEnum.Money;
    }

    public class Adventuring
    {
        [Description("$status")]
        public static ActionCommandEnum Status { get; } = ActionCommandEnum.Status;
        [Description("$adventure")]
        public static ActionCommandEnum Adventure { get; } = ActionCommandEnum.Adventure;
        public static ActionCommandEnum ActiveAdventure { get; } = ActionCommandEnum.ActiveAdventure;
        [Description("$adventures")]
        public static ActionCommandEnum Adventures { get; } = ActionCommandEnum.Adventures;
        [Description("$timings")]
        public static ActionCommandEnum Cooldowns { get; } = ActionCommandEnum.Cooldowns;        
        public static ActionCommandEnum Cancel { get; } = ActionCommandEnum.Cancel;
    }
    
    public class DailyQuest
    {
        [Description("$pray")]
        public static ActionCommandEnum Pray { get; } = ActionCommandEnum.Pray;
        [Description("$favor")]
        public static ActionCommandEnum Favor { get; } = ActionCommandEnum.Favor;
        [Description("$daily")]
        public static ActionCommandEnum Daily { get; } = ActionCommandEnum.Daily;
        [Description("$vote")]
        public static ActionCommandEnum Vote { get; } = ActionCommandEnum.Vote;
        public static ActionCommandEnum Steal { get; } = ActionCommandEnum.Steal;
    }

    public class Battles
    {
        [Description("$battle")]
        public static ActionCommandEnum Battle { get; } = ActionCommandEnum.Battle;
        [Description("$raidbattle")]
        public static ActionCommandEnum RaidBattle { get; } = ActionCommandEnum.RaidBattle;
        public static ActionCommandEnum Hungergames { get; } = ActionCommandEnum.Hungergames;
        public static ActionCommandEnum Tournament { get; } = ActionCommandEnum.Tournament;
    }

    public class Inventoring
    {
        [Description("$merge")]
        public static ActionCommandEnum Merge { get; } = ActionCommandEnum.Merge;
        [Description("$upgrade")]
        public static ActionCommandEnum Upgrade { get; } = ActionCommandEnum.Upgrade;
        [Description("$inventory")]
        public static ActionCommandEnum Inventory { get; } = ActionCommandEnum.Inventory;
        public static ActionCommandEnum Crates { get; } = ActionCommandEnum.Crates; 
    }

    public class Shopping
    {
        [Description("$sell")]
        public static ActionCommandEnum Sell { get; } = ActionCommandEnum.Sell;
        [Description("$merchant")]
        public static ActionCommandEnum Merchant { get; } = ActionCommandEnum.Merchant;
        [Description("$shop")]
        public static ActionCommandEnum Shop { get; } = ActionCommandEnum.Shop;
        [Description("$trade")]
        public static ActionCommandEnum Trade { get; } = ActionCommandEnum.Trade;
    }

    public class Gamble
    {
        [Description("$blackjack")]
        public static ActionCommandEnum Blackjack { get; } = ActionCommandEnum.BlackJack;
        [Description("$roulette")]
        public static ActionCommandEnum Roulette { get; } = ActionCommandEnum.Roulette;
        [Description("$flip")]
        public static ActionCommandEnum Flip { get; } = ActionCommandEnum.Flip;
        [Description("$card")]
        public static ActionCommandEnum Card { get; } = ActionCommandEnum.Card;
        public static ActionCommandEnum Bet { get; } = ActionCommandEnum.Bet;
        public static ActionCommandEnum Dos { get; } = ActionCommandEnum.Dos;
        public static ActionCommandEnum Roulette_Table { get; } = ActionCommandEnum.Roulette_Table;
    }


}
