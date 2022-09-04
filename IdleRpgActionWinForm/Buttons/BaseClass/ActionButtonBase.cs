using System.Windows.Forms;

namespace IdleRpgActionWinForm.Buttons.BaseClass
{
    public abstract class ActionButtonBase : UserControl
    {
        protected string _targetApplicationName;
        public void UpdateTargetApplication(string targetApplicationName)
        {
            _targetApplicationName = targetApplicationName;
        }
    }
}
