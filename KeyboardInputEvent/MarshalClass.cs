using System.Runtime.InteropServices;
using System.Threading;

namespace KeyboardInputEvent
{
    public class MarshalClass
    {
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        [DllImport("user32.dll")] 
        static extern short VkKeyScanA(char ch);

        //[DllImport("user32.dll")]
        //static extern void SendMessageW(in HWND hWnd, in UINT Msg, in WPARAM wParam, in LPARAM lParam);
        //LRESULT SendMessageW([in] HWND hWnd,[in] UINT Msg,[in] WPARAM wParam,[in] LPARAM lParam);

        //const byte VK_RETURN = 0x0D;
        const uint KEYEVENTF_EXTENDEDKEY = 0x0001;
        const uint KEYEVENTF_KEYUP = 0x0002;

        //public const byte VK_LSHIFT = 0xA0; // left shift key
        //public const byte VK_TAB = 0x09;
        

        //public static void PressKey(byte keyCode)
        //{
        //    keybd_event(keyCode, 0, 0, 0);
        //    Thread.Sleep(1);
        //    keybd_event(keyCode, 0, KEYEVENTF_KEYUP, 0);
        //}

        public static void KeyPress(VKCodesEnum vkCode)
        {
            keybd_event(((byte)vkCode), 0, 0, 0);
            Thread.Sleep(5);
            keybd_event(((byte)vkCode), 0, KEYEVENTF_KEYUP, 0);
        }

        public static void KeyUp(VKCodesEnum vkCode)
        {
            keybd_event(((byte)vkCode), 0, KEYEVENTF_KEYUP, 0);
        }

        public static void KeyDown(VKCodesEnum vkCode)
        {
            keybd_event(((byte)vkCode), 0, 0, 0);
        }

        //public static short koukou(char c)
        //{
        //    keybd_event(((byte)VkKeyScanA(c)), 0, 0, 0);
        //    //Thread.Sleep(10);
        //    keybd_event(((byte)VkKeyScanA(c)), 0, KEYEVENTF_KEYUP, 0);

        //    var helper = new Helper { Value = VkKeyScanA(c) };

        //    var a = helper.Low;
        //    var b = helper.High;

        //    return VkKeyScanA(c);
        //}

        //[StructLayout(LayoutKind.Explicit)]
        //struct Helper
        //{
        //    [FieldOffset(0)] public short Value;
        //    [FieldOffset(0)] public byte Low;
        //    [FieldOffset(1)] public byte High;
        //}
    }
}
