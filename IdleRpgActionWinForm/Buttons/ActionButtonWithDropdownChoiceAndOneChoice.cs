using IdleRpgAction.Domain.Enumerations;
using IdleRpgActionWinForm.Buttons.BaseClass;
using System;

namespace IdleRpgActionWinForm.Buttons
{
    public partial class ActionButtonWithDropdownChoiceAndOneChoice : ActionButtonBase
    {
        private bool _isRunning;
        IdleRpgAction.Application.Implementations.IdleRpgActionBase _actionCommand;
        public ActionButtonWithDropdownChoiceAndOneChoice(IdleRpgAction.Application.Implementations.IdleRpgActionBase command, EnumerationChoserEnum enumChoser)
        {
            InitializeComponent();
            _actionCommand = command;
            SetButtonText(command.ActionCommand);
            SetDropdown(enumChoser);
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
                case EnumerationChoserEnum.CratesRarityEnum:
                    enumItems = Enum.GetNames<CratesRarityEnum>();
                    break;
                case EnumerationChoserEnum.WeaponEnum:
                    enumItems = Enum.GetNames<WeaponEnum>();
                    break;
                default:
                    break;
            }

            for (int i = enumItems.Length - 1; i > -1; --i)
            {
                enumItems[i] = enumItems[i].Replace("_", String.Empty);
            }
            ddl.Items.AddRange(enumItems);
            if (ddl.Items.Count > 0)
            {
                ddl.SelectedIndex = 0;
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (!_isRunning)
            {
                _isRunning = !_isRunning;
                string comm = _actionCommand.SetActionCommand()
                                            .SetParameter(ddl.SelectedItem.ToString())
                                            .SetAmount((int)txtNumber.Value)
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
