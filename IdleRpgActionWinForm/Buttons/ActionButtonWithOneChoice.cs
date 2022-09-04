using IdleRpgAction.Domain.Enumerations;
using IdleRpgActionWinForm.Buttons.BaseClass;
using System;

namespace IdleRpgActionWinForm.Buttons
{
    public partial class ActionButtonWithOneChoice : ActionButtonBase
    {
        private bool _isRunning;
        IdleRpgAction.Application.Implementations.IdleRpgActionBase _actionCommand;
        public ActionButtonWithOneChoice(IdleRpgAction.Application.Implementations.IdleRpgActionBase command)
        {
            InitializeComponent();
            _actionCommand = command;
            SetButtonText(command.ActionCommand);
        }


        private void SetButtonText(ActionCommandEnum actionEnum)
        {
            btnAction.Text = actionEnum.ToString();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (!_isRunning)
            {
                _isRunning = !_isRunning;
                string comm = _actionCommand.SetActionCommand()
                                            .SetAmount((int)txtAmount.Value)
                                            .Build();

                //InputActivityMonitor.ExternalWindowHelper.BringWindowToFront("Discord");
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
