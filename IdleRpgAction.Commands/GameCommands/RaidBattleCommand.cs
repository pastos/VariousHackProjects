﻿using IdleRpgAction.Domain.Enumerations;
using IdleRpgAction.Domain.Interfaces;
using System;

namespace IdleRpgAction.Application.GameCommands
{
    public class RaidBattleCommand : ICommand
    {
        public TimeSpan Cooldown { get; set; }
        public ActionCommandEnum ActionCommand { get; private set; }
        public string RandomText { get; set; }
        public int Amount { get; set; }
        public string EnemyActor { get; set; }

        public RaidBattleCommand()
        {
            ActionCommand = ActionCommandEnum.RaidBattle;
            Cooldown = new TimeSpan(0, 3, 0);
        }
    }
}
