//using IdleRpgAction.Application.Enumerations;
//using IdleRpgAction.Application.Implementations;
//using IdleRpgAction.Base.Interfaces;
//using System;
//using System.Collections.Generic;

//namespace IdleRpgAction.Application
//{
//    public abstract class CommandBase
//    {
//        protected IIdleRpgAction _idleRpgAction;
//        protected ActionCommandEnum _actionCommand;
//        protected Dictionary<string, Dictionary<string, string>> _randomTexts;
//        protected TimeSpan _cooldown;
//        public CommandBase(ActionCommandEnum actionCommand, TimeSpan cooldown)
//        {
//            _idleRpgAction = new IdleRpgActionBase();
//            _actionCommand = actionCommand;
//            _cooldown = cooldown;
//        }
//        protected void ConstructCommand()
//        {
//            string text = SelectRandomText();
//            string comm = _idleRpgAction.SetActionCommand(_actionCommand)
//                                        .SetRandomText(text)
//                                        .SetCooldown(_cooldown)
//                                        .Build();
//        }

//        protected string SelectRandomText()
//        {
//            string result = string.Empty;
//            if (_randomTexts != null)
//            {
//                int index = new Random().Next(1, _randomTexts[_actionCommand.ToString()].Count + 1);
//                result = _randomTexts[_actionCommand.ToString()][index.ToString()];
//            }
//            return result;
//        }
//    }
//    //public class StatusCommand : CommandBase
//    //{
//    //    //public StatusCommand(ActionCommandEnum actionCommand, TimeSpan cooldown) : base(actionCommand, cooldown)
//    //    //public StatusCommand()
//    //    //{
//    //    //    base(new, cooldown);
//    //    //}
//    //}
//}
