using IdleRpgAction.Domain.Enumerations;
using System;
using System.Windows.Forms;

namespace IdleRpgActionWinForm.Buttons
{
    public partial class ActionButtonWithDropdownChoice : UserControl
    {
        private bool _isRunning;
        private string _targetApplicationName;
        IdleRpgAction.Application.Implementations.IdleRpgActionBase _actionCommand;
        public ActionButtonWithDropdownChoice(IdleRpgAction.Application.Implementations.IdleRpgActionBase command, EnumerationChoserEnum enumChoser)
        {
            InitializeComponent();
            _actionCommand = command;
            SetButtonText(command.ActionCommand);
            SetDropdown(enumChoser);
        }

        public void UpdateTargetApplication(string targetApplicationName)
        {
            _targetApplicationName = targetApplicationName;
        }

        private void SetButtonText(ActionCommandEnum actionEnum)
        {
            btnAction.Text = actionEnum.ToString();
        }

        private void SetDropdown(EnumerationChoserEnum enumChoser)
        {
            string[] enumItems = null;
            switch (enumChoser)
            {
                case EnumerationChoserEnum.ActionCommandEnum:
                    enumItems = Enum.GetNames<ActionCommandEnum>();
                    break;
                case EnumerationChoserEnum.CoinSideEnum:
                    enumItems = Enum.GetNames<CoinSideEnum>();
                    break;
                case EnumerationChoserEnum.RouletteGameEnum:
                    enumItems = Enum.GetNames<RouletteGameEnum>();
                    break;
                case EnumerationChoserEnum.BonusChoicesEnum:
                    enumItems = Enum.GetNames<BonusChoicesEnum>();
                    break;
                default:
                    break;
            }
            ddl.Items.AddRange(enumItems);
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (!_isRunning)
            {
                _isRunning = !_isRunning;
                string comm = _actionCommand.SetActionCommand()
                                            .SetParameter(ddl.SelectedItem.ToString().Replace("_", String.Empty))
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
