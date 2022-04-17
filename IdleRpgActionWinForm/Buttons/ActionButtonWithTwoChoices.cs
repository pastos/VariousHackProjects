using IdleRpgAction.Base.Enumerations;
using IdleRpgAction.Base.Interfaces;
using System;
using System.Windows.Forms;

namespace IdleRpgActionWinForm.Buttons
{
    public partial class ActionButtonWithTwoChoices : UserControl
    {
        private bool _isRunning;
        public IIdleRpgAction IdleRpgAction;
        public ActionCommandEnum _commandEnum { get; set; }
        public ActionButtonWithTwoChoices(ActionCommandEnum actionEnum)
        {
            InitializeComponent();
            _commandEnum = actionEnum;
            SetButtonText(actionEnum);
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
                string comm = IdleRpgAction.SetActionCommand(_commandEnum)
                                           .SetFirstItem((int)txtItemId1.Value)
                                           .SetSecondItem((int)txtItemId2.Value)
                                           .Build();

                InputActivityMonitor.ExternalWindowHelper.BringWindowToFront("Discord");
                KeyboardInputEvent.CaligraphyHelper.TextToKeystrokes(comm);
            }
            _isRunning = !_isRunning;
        }
    }    
}
