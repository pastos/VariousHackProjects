using IdleRpgAction.Base.Enumerations;
using IdleRpgAction.Base.Interfaces;
using IdleRpgAction.Domain.Interfaces;
using System;
using System.Windows.Forms;

namespace IdleRpgActionWinForm.Buttons
{

    public abstract class ActionButtonUserControl : UserControl
    {
        protected ActionCommandEnum _actionEnum;
        protected IIdleRpgAction _idleRpgAction;
        protected ActionButtonUserControl(ActionCommandEnum actionEnum)
        {
            //_idleRpgAction = new ActionBase();
            _actionEnum = actionEnum;
        }
        protected void SetButtonText(Button btn)
        {
            btn.Text = _actionEnum.ToString();
        }
    }



    public partial class ActionButtonWithOneChoice : ActionButtonUserControl
    {
        private bool _isRunning;
        public IIdleRpgAction IdleRpgAction;

        public void ActionButtonWithOneChoic(Action<ICommand> commandMethod)
        {
            
        }

        private void assa(StatusCommand command)
        {
            command.RandomText = "";
            command.Build();
        }

        public ActionButtonWithOneChoice(IIdleRpgAction idleRpgAction, ActionCommandEnum actionEnum) : base(idleRpgAction, actionEnum)
        {
            InitializeComponent();
            SetButtonText(btnAction);
            ActionButtonWithOneChoic(assa);
        }


        private string ActionCommand(int amount)
        {
            string comm = IdleRpgAction.SetActionCommand(_actionEnum)
                                           .SetAmount(amount)
                                           .Build();
            return comm;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (!_isRunning)
            {
                _isRunning = !_isRunning;
                string comm = ActionCommand((int)txtAmount.Value);

                InputActivityMonitor.ExternalWindowHelper.BringWindowToFront("Discord");
                KeyboardInputEvent.CaligraphyHelper.TextToKeystrokes(comm);
            }
            _isRunning = !_isRunning;
        }
    }
}
