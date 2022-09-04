using IdleRpgAction.Domain.Enumerations;
using IdleRpgActionWinForm.Buttons.BaseClass;
using System;

namespace IdleRpgActionWinForm.Buttons
{
    public partial class ActionButtonWithTwoChoicesAndText : ActionButtonBase
    {
        private bool _isRunning;
        IdleRpgAction.Application.Implementations.IdleRpgActionBase _actionCommand;
        public ActionButtonWithTwoChoicesAndText(IdleRpgAction.Application.Implementations.IdleRpgActionBase command)
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
                double hours = (int)txtItemId1.Value;
                int mins = (int)txtItemId2.Value;
                mins = hours == (int)txtItemId1.Maximum ? 0 : mins;
                double minsAsDecimal = (double)mins / 60;

                double total = hours + minsAsDecimal;

                string comm = _actionCommand.SetActionCommand()
                                            .SetParameter(total.ToString("0.00") + "h")
                                            .SetParameter(txtNote.Text)
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
