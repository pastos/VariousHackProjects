using IdleRpgAction.Domain.Enumerations;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IdleRpgAction.Application.Implementations
{
    public abstract class IdleRpgActionBase //: IIdleRpgAction
    {
        protected StringBuilder _executableCommand = new StringBuilder();
        protected string TriggerCommand { get; } = "/msg @IdleRPG\r$"; //keep the whitespace
        protected Dictionary<string, Dictionary<string, string>> _randomTexts;

        protected string Name { get; set; }

        public TimeSpan Cooldown { get; set; }
        public ActionCommandEnum ActionCommand { get; protected set; }
        protected string RandomText { get; set; }
        protected DateTime CooldownEnd { get; private set; }

        protected bool IsCooldown
        {
            get
            {
                return (CooldownEnd - DateTime.Now).TotalSeconds > 0;
            }
        }

        protected IdleRpgActionBase()
        {
            //_itemIds = new LinkedList<int>();
            _randomTexts = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(File.ReadAllText(@"RandomTexts.json"));
        }
        public IdleRpgActionBase SetActionCommand()
        {
            _executableCommand.Append(TriggerCommand);
            _executableCommand.Append(ActionCommand.ToString().Replace("_", " "));
            return this;
        }

        public virtual string Build()
        {
            StringBuilder execCommand = new StringBuilder();            
            execCommand = execCommand.AppendJoin("", _executableCommand);
            _executableCommand.Clear();
            return execCommand.ToString();
        }

        public IdleRpgActionBase SetName(string name)
        {
            Name = name;
            return this;
        }


        public IdleRpgActionBase SetAmount(int amount)
        {
            _executableCommand.Append(" ");
            _executableCommand.Append(amount);
            return this;
        }

        public IdleRpgActionBase SetFirstItem(int item)
        {
            _executableCommand.Append(" ");
            _executableCommand.Append(item);
            return this;
        }

        public IdleRpgActionBase SetSecondItem(int item)
        {
            _executableCommand.Append(" ");
            _executableCommand.Append(item);
            return this;
        }

        public IdleRpgActionBase SetActor(string actor)
        {
            _executableCommand.Append(" ");
            _executableCommand.Append(actor);
            return this;
        }

        public IdleRpgActionBase SetCooldown(TimeSpan time)
        {
            CooldownEnd = DateTime.Now.Add(time);
            return this;
        }

        public IdleRpgActionBase SetRandomText()
        {
            string text = SelectRandomText();
            _executableCommand.Append(" ");
            _executableCommand.Append(text);
            return this;
        }

        private string SelectRandomText()
        {
            string result = string.Empty;
            if (_randomTexts != null)
            {
                string actionCommand = ActionCommand.ToString();
                if (_randomTexts.ContainsKey(actionCommand))
                {
                    int index = new Random().Next(1, _randomTexts[actionCommand].Count + 1);
                    result = _randomTexts[actionCommand][index.ToString()];
                }
            }
            return result;
        }

        public IdleRpgActionBase SetItemId(int itemId)
        {
            //_itemIds.AddLast(itemId);
            _executableCommand.Append(" ");
            _executableCommand.Append(itemId);
            return this;
        }

        public IdleRpgActionBase SetParameter(string param)
        {
            _executableCommand.Append(" ");
            _executableCommand.Append(param);
            return this;
        }
    }
}
