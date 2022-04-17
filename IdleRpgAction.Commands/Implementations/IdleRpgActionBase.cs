using IdleRpgAction.Domain.Enumerations;
using IdleRpgAction.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdleRpgAction.Application.Implementations
{
    public class IdleRpgActionBase : IIdleRpgAction
    {
        private StringBuilder _executableCommand = new StringBuilder();
        //private LinkedList<int> _itemIds;

        public string Name { get; set; }
        public DateTime CooldownEnd { get; private set; }
        public bool IsCooldown
        {
            get
            {
                return (CooldownEnd - DateTime.Now).TotalSeconds > 0;
            }
        }

        public IdleRpgActionBase()
        {
            //_itemIds = new LinkedList<int>();
        }

        public string Build()
        {
            StringBuilder execCommand = new StringBuilder();
            execCommand = execCommand.AppendJoin(' ', _executableCommand);
            _executableCommand.Clear();
            return execCommand.ToString();
        }

        public IIdleRpgAction SetName(string name)
        {
            Name = name;
            return this;
        }

        public IIdleRpgAction SetActionCommand(ActionCommandEnum actionEnum)
        {
            _executableCommand.Append(actionEnum);
            return this;
        }

        public IIdleRpgAction SetAmount(int amount)
        {
            _executableCommand.Append(" ");
            _executableCommand.Append(amount);
            return this;
        }

        public IIdleRpgAction SetFirstItem(int item)
        {
            _executableCommand.Append(" ");
            _executableCommand.Append(item);
            return this;
        }

        public IIdleRpgAction SetSecondItem(int item)
        {
            _executableCommand.Append(" ");
            _executableCommand.Append(item);
            return this;
        }

        public IIdleRpgAction SetActor(string actor)
        {
            _executableCommand.Append(" ");
            _executableCommand.Append(actor);
            return this;
        }

        public IIdleRpgAction SetCooldown(TimeSpan time)
        {
            CooldownEnd = DateTime.Now.Add(time);
            return this;
        }

        public IIdleRpgAction SetRandomText(string text)
        {
            _executableCommand.Append(" ");
            _executableCommand.Append(text);
            return this;
        }

        public IIdleRpgAction SetItemId(int itemId)
        {
            //_itemIds.AddLast(itemId);
            _executableCommand.Append(" ");
            _executableCommand.Append(itemId);
            return this;
        }

        public IIdleRpgAction SetParameter(string param)
        {
            _executableCommand.Append(" ");
            _executableCommand.Append(param);
            return this;
        }
    }
}
