using IdleRpgAction.Application.GameCommands;
using IdleRpgAction.Application.Handlers;
using IdleRpgAction.Domain.Enumerations;
using IdleRpgAction.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IdleRpgActionWinForm.Buttons
{
    public partial class ActionButton : UserControl
    {
        //public IIdleRpgAction IdleRpgAction;
        private IIdleRpgAction _idleRpgAction;
        private bool _isRunning;
        private Dictionary<string, Dictionary<string, string>> _randomTexts;

        public ActionCommandEnum _commandEnum { get; set; }

        //public ActionButton(ActionCommandEnum actionEnum, Dictionary<string, Dictionary<string, string>> randomTexts)
        //{
        //    InitializeComponent();
        //    _idleRpgAction = new IdleRpgActionBase();
        //    _commandEnum = actionEnum;
        //    _randomTexts = randomTexts;
        //    SetButtonText(actionEnum);
        //    //_idleRpgAction.SetActionCommand(actionEnum);
        //}

        //public ActionButton(ActionCommandEnum actionEnum)
        //{
        //    InitializeComponent();
        //    _idleRpgAction = new IdleRpgActionBase();
        //    _commandEnum = actionEnum;
        //    SetButtonText(actionEnum);
        //    //_idleRpgAction.SetActionCommand(actionEnum);
        //}

        
        //private AdventureCommandHandler _commandHandler;
        
        private ICommand _command;
        //public ActionButton(ICommandHandler<ICommand> commandHandler, ICommand command)
        //{
        //    _commandHandler = commandHandler;
        //    _commandHandler.BuildCommand(command);
        //}

        private AdventureCommandHandler _commandHandler;

        public ActionButton(AdventureCommandHandler commandHandler)
        {
            _commandHandler = commandHandler;
        }
        //public ActionButton(AdventureCommandHandler commandHandler, StatusCommand command) : this(commandHandler)
        //{
        //    //_command = command;
        //    _commandHandler.BuildCommand(command);
        //}

        private ICommandHandler<ICommand> _commandHandler2;
        public ActionButton(ICommandHandler<ICommand> _commandHandler, ICommand command)
        {
            _command = command;
            _commandHandler2.BuildCommand(_command);
        }

        //private ICommandHandler<StatusCommand> _commandHandler;
        
        private AdventureCommandHandler _commandHandler12;
        private StatusCommand _command2;


        //public ActionButton(AdventureCommandHandler commandHandler, StatusCommand command) : this(commandHandler)
        //{
        //    _command2 = command;
        //    _commandHandler12 = commandHandler;
        //    commandHandler.BuildCommand(_command2);
        //}

        
        public ActionButton(ActionCommandEnum commandEnum)
        {
            _commandEnum = commandEnum;
            ICommandHandler<ICommand> commHandler;
            //Koukou<StatusCommand>(new StatusCommand());
    }

        public delegate string Koukou2(StatusCommand comm);
        public Koukou2 Runner;

        //private void Koukou<ICommand>(ICommand comm)
        //{
        //    AdventureCommandHandler ccc = new AdventureCommandHandler();
        //    Runner = ccc.BuildCommand;
        //    Runner(_command2);
            
        //}

        //ICommandHandler<CooldownsCommand>, ICommandHandler<AdventuresCommand>, ICommandHandler<ActiveAdventureCommand>, ICommandHandler<StatusCommand>

        private void SetButtonText(ActionCommandEnum actionEnum)
        {
            btnAction.Text = _commandEnum.ToString();
        }

        private string SelectRandomText()
        {
            string result = string.Empty;
            if (_randomTexts != null)
            {
                int index = new Random().Next(1, _randomTexts[_command.ActionCommand.ToString()].Count + 1);
                result = _randomTexts[_command.ActionCommand.ToString()][index.ToString()];
            }
            return result;
        }

        private void btnAction_Click(object sender, System.EventArgs e)
        {
            if (!_isRunning)
            {
                _isRunning = !_isRunning;
                string text = SelectRandomText();
                string comm = _idleRpgAction.SetActionCommand(_commandEnum)
                                            .SetRandomText(text)
                                            .SetCooldown(new System.TimeSpan(0, 0, 2))
                                            .Build();

                //string comm = _commandHandler.BuildCommand(_command2);

                InputActivityMonitor.ExternalWindowHelper.BringWindowToFront("Notepad++");
                KeyboardInputEvent.CaligraphyHelper.TextToKeystrokes(comm);
            }
            _isRunning = !_isRunning;
        }
    }
}
