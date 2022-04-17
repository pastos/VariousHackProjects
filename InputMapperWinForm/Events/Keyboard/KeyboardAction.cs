using KeyboardInputEvent;
using System.Windows.Forms;

namespace InputMapperWinForm.Events.Keyboard
{
    public class KeyboardAction : ISimpleMapInput<KeyPressEventArgs>
    {
        public void HookManager_ActionExtDown(object sender, KeyPressEventArgs e, VKCodesEnum mappedKey)
        {
            MarshalClass.KeyDown(mappedKey);
        }

        public void HookManager_ActionExtPress(object sender, KeyPressEventArgs e, VKCodesEnum mappedKey)
        {
            MarshalClass.KeyPress(mappedKey);
        }

        public void HookManager_ActionExtUp(object sender, KeyPressEventArgs e, VKCodesEnum mappedKey)
        {
            MarshalClass.KeyUp(mappedKey);
        }
    }
}
