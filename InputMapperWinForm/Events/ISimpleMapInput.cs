using System;

namespace InputMapperWinForm.Events
{
    public interface ISimpleMapInput<T> //here T : EventArgs
    {
        void HookManager_ActionExtUp(object sender, T e, KeyboardInputEvent.VKCodesEnum mappedKey);
        void HookManager_ActionExtPress(object sender, T e, KeyboardInputEvent.VKCodesEnum mappedKey);
        void HookManager_ActionExtDown(object sender, T e, KeyboardInputEvent.VKCodesEnum mappedKey);

    }

    public interface ISimpleMapInput
    {

    }
}
