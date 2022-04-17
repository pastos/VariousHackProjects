using InputActivityMonitor;
using KeyboardInputEvent;
using System.Collections.Generic;

namespace InputMapperWinForm.Events.Mouse
{
    public class MouseWheelAction<T> : ISimpleMapInput<T> where T : MouseEventExtArgs
    {
        public void HookManager_ActionExtDown(object sender, T e, VKCodesEnum mappedKey)
        {
            if (e.Delta < 0)
            {
                MarshalClass.KeyPress(mappedKey);
            }
        }

        public void HookManager_ActionExtPress(object sender, T e, VKCodesEnum mappedKey)
        {
            MarshalClass.KeyPress(mappedKey);
        }

        public void HookManager_ActionExtUp(object sender, T e, VKCodesEnum mappedKey)
        {
            if (e.Delta > 0)
            {
                MarshalClass.KeyPress(mappedKey);
            }
        }
    }

    public class MouseWheelAction : ISimpleMapInput
    {
        public KeyboardInputEvent.VKCodesEnum Origin { get; set; }
        public KeyboardInputEvent.VKCodesEnum Destination { get; set; }
    }

    public class InputActionDictionary : Dictionary<KeyboardInputEvent.VKCodesEnum, KeyboardInputEvent.VKCodesEnum>
    {
        public new void Add(KeyboardInputEvent.VKCodesEnum o, KeyboardInputEvent.VKCodesEnum d)
        {
            Add(o, d);
        }
    }
}
