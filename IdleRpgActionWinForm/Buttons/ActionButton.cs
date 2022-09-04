using IdleRpgAction.Domain.Enumerations;
using IdleRpgActionWinForm.Buttons.BaseClass;

namespace IdleRpgActionWinForm.Buttons
{
    public partial class ActionButton : ActionButtonBase
    {
        private bool _isRunning;
        
        private IdleRpgAction.Application.Implementations.IdleRpgActionBase _actionCommand;
        
        public ActionButton(IdleRpgAction.Application.Implementations.IdleRpgActionBase command)
        {
            InitializeComponent();
            _actionCommand = command;
            SetButtonText(command.ActionCommand);
        }

        private void SetButtonText(ActionCommandEnum actionEnum)
        {
            btnAction.Text = actionEnum.ToString();
        }

        private void btnAction_Click(object sender, System.EventArgs e)
        {
            if (!_isRunning)
            {
                _isRunning = !_isRunning;
                string comm = _actionCommand.SetActionCommand()
                                            .SetRandomText()
                                            .Build();
                
                InputActivityMonitor.ExternalWindowHelper.BringWindowToFront(_targetApplicationName);
                if (InputActivityMonitor.ExternalWindowHelper.IsWindowAtFront)
                {
                    KeyboardInputEvent.CaligraphyHelper.TextToKeystrokes(comm);
                }
            }
            _isRunning = !_isRunning;
        }
    }
}
