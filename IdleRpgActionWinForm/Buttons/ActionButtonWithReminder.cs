using IdleRpgAction.Application.GameCommands;
using IdleRpgAction.Domain.Enumerations;
using System.Windows.Forms;

namespace IdleRpgActionWinForm.Buttons
{
    public partial class ActionButtonWithReminder : UserControl
    {
        private bool _isRunning;
        private string _targetApplicationName;
        private IdleRpgAction.Application.Implementations.IdleRpgActionBase _actionCommand;
        
        public ActionButtonWithReminder(IdleRpgAction.Application.Implementations.IdleRpgActionBase command)
        {
            InitializeComponent();
            _actionCommand = command;
            SetButtonText(command.ActionCommand);
        }

        public void UpdateTargetApplication(string targetApplicationName)
        {
            _targetApplicationName = targetApplicationName;
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

        private void btnReminder_Click(object sender, System.EventArgs e)
        {
            ReminderCommand reminderCommand = new ReminderCommand();
            double hours = _actionCommand.Cooldown.Hours;
            int mins = _actionCommand.Cooldown.Minutes;
            //mins = hours == 59 ? 0 : mins;
            double minsAsDecimal = (double)mins / 60;

            double total = hours + minsAsDecimal;

            string comm = reminderCommand.SetActionCommand()
                                         .SetParameter(total.ToString("0.00000") + "h")
                                         .SetParameter(_actionCommand.ActionCommand.ToString())
                                         .Build();

            InputActivityMonitor.ExternalWindowHelper.BringWindowToFront(_targetApplicationName);
            if (InputActivityMonitor.ExternalWindowHelper.IsWindowAtFront)
            {
                KeyboardInputEvent.CaligraphyHelper.TextToKeystrokes(comm);
            }
        }
    }
}
