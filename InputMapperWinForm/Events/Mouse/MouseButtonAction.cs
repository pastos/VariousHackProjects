using InputActivityMonitor;
using KeyboardInputEvent;

namespace InputMapperWinForm.Events.Mouse
{
    public class MouseButtonAction : ISimpleMapInput<MouseEventExtArgs>
    {
        public void HookManager_ActionExtDown(object sender, MouseEventExtArgs e, VKCodesEnum mappedKey)
        {
            MarshalClass.KeyDown(mappedKey);
        }

        public void HookManager_ActionExtPress(object sender, MouseEventExtArgs e, VKCodesEnum mappedKey)
        {
            MarshalClass.KeyPress(mappedKey);
        }

        public void HookManager_ActionExtUp(object sender, MouseEventExtArgs e, VKCodesEnum mappedKey)
        {
            MarshalClass.KeyUp(mappedKey);
        }
    }
}
