using KeyboardInputEvent;

namespace InputMapperWinForm.Mappings
{
    internal class ActionMap
    {
        public VKCodesEnum Original { get; set; }
        public VKCodesEnum Destination { get; set; }

        public bool IsRepeated { get; set; }

    }
}
