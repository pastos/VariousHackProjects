using System.ComponentModel;

namespace KeyboardInputEvent
{
    public enum VKCodesEnum
    {
        [Description("Left mouse button")]
        VK_LBUTTON = 0x01, //Left mouse button
        [Description("Right mouse button")]
        VK_RBUTTON = 0x02, //Right mouse button
        [Description("Control-break processing")]
        VK_CANCEL = 0x03, //Control-break processing
        [Description("Middle mouse button (three-button mouse)")]
        VK_MBUTTON = 0x04, //Middle mouse button (three-button mouse)
        [Description("X1 mouse button")]
        VK_XBUTTON1 = 0x05, //X1 mouse button
        [Description("X2 mouse button")]
        VK_XBUTTON2 = 0x06, //X2 mouse button
        [Description("BACKSPACE key")]
        VK_BACK = 0x08, //BACKSPACE key
        [Description("TAB key")]
        VK_TAB = 0x09, //TAB key
        [Description("CLEAR key")]
        VK_CLEAR = 0x0C, //CLEAR key
        [Description("ENTER key")]
        VK_RETURN = 0x0D, //ENTER key
        [Description("SHIFT key")]
        VK_SHIFT = 0x10, //SHIFT key
        [Description("CTRL key")]
        VK_CONTROL = 0x11, //CTRL key
        [Description("ALT key")]
        VK_MENU = 0x12, //ALT key
        [Description("PAUSE key")]
        VK_PAUSE = 0x13, //PAUSE key
        [Description("CAPS LOCK key")]
        VK_CAPITAL = 0x14, //CAPS LOCK key
        [Description("IME Kana mode")]
        VK_KANA = 0x15, //IME Kana mode
        [Description("IME Hanguel mode (maintained for compatibility, use VK_HANGUL)")]
        VK_HANGUEL = 0x15, //IME Hanguel mode (maintained for compatibility, use VK_HANGUL)
        [Description("IME Hangul mode")]
        VK_HANGUL = 0x15, //IME Hangul mode
        [Description("IME On")]
        VK_IME_ON = 0x16, //IME On
        [Description("IME Junja mode")]
        VK_JUNJA = 0x17, //IME Junja mode
        [Description("IME final mode")]
        VK_FINAL = 0x18, //IME final mode
        [Description("IME Hanja mode")]
        VK_HANJA = 0x19, //IME Hanja mode
        [Description("IME Kanji mode")]
        VK_KANJI = 0x19, //IME Kanji mode
        [Description("IME Off")]
        VK_IME_OFF = 0x1A, //IME Off
        [Description("ESC key")]
        VK_ESCAPE = 0x1B, //ESC key
        [Description("IME convert")]
        VK_CONVERT = 0x1C, //IME convert
        [Description("IME nonconvert")]
        VK_NONCONVERT = 0x1D, //IME nonconvert
        [Description("IME accept")]
        VK_ACCEPT = 0x1E, //IME accept
        [Description("IME mode change request")]
        VK_MODECHANGE = 0x1F, //IME mode change request
        [Description("SPACEBAR")]
        VK_SPACE = 0x20, //SPACEBAR
        [Description("PAGE UP key")]
        VK_PRIOR = 0x21, //PAGE UP key
        [Description("PAGE DOWN key")]
        VK_NEXT = 0x22, //PAGE DOWN key
        [Description("END key")]
        VK_END = 0x23, //END key
        [Description("HOME key")]
        VK_HOME = 0x24, //HOME key
        [Description("LEFT ARROW key")]
        VK_LEFT = 0x25, //LEFT ARROW key
        [Description("UP ARROW key")]
        VK_UP = 0x26, //UP ARROW key
        [Description("RIGHT ARROW key")]
        VK_RIGHT = 0x27, //RIGHT ARROW key
        [Description("DOWN ARROW key")]
        VK_DOWN = 0x28, //DOWN ARROW key
        [Description("SELECT key")]
        VK_SELECT = 0x29, //SELECT key
        [Description("PRINT key")]
        VK_PRINT = 0x2A, //PRINT key
        [Description("EXECUTE key")]
        VK_EXECUTE = 0x2B, //EXECUTE key
        [Description("PRINT SCREEN key")]
        VK_SNAPSHOT = 0x2C, //PRINT SCREEN key
        [Description("INS key")]
        VK_INSERT = 0x2D, //INS key
        [Description("DEL key")]
        VK_DELETE = 0x2E, //DEL key
        [Description("HELP key")]
        VK_HELP = 0x2F, //HELP key
        [Description("0 key")]
        VK_Key0 = 0x30,    //0 key
        [Description("1 key")]
        VK_Key1 = 0x31,    //1 key
        [Description("2 key")]
        VK_Key2 = 0x32,    //2 key
        [Description("3 key")]
        VK_Key3 = 0x33,    //3 key
        [Description("4 key")]
        VK_Key4 = 0x34,    //4 key
        [Description("5 key")]
        VK_Key5 = 0x35,    //5 key
        [Description("6 key")]
        VK_Key6 = 0x36,    //6 key
        [Description("7 key")]
        VK_Key7 = 0x37,    //7 key
        [Description("8 key")]
        VK_Key8 = 0x38,    //8 key
        [Description("9 key")]
        VK_Key9 = 0x39,    //9 key
        [Description("A key")]
        VK_KeyA = 0x41,    //A key
        [Description("B key")]
        VK_KeyB = 0x42,    //B key
        [Description("C key")]
        VK_KeyC = 0x43,    //C key
        [Description("D key")]
        VK_KeyD = 0x44,    //D key
        [Description("E key")]
        VK_KeyE = 0x45,    //E key
        [Description("F key")]
        VK_KeyF = 0x46,    //F key
        [Description("G key")]
        VK_KeyG = 0x47,    //G key
        [Description("H key")]
        VK_KeyH = 0x48,    //H key
        [Description("I key")]
        VK_KeyI = 0x49,    //I key
        [Description("J key")]
        VK_KeyJ = 0x4A,    //J key
        [Description("K key")]
        VK_KeyK = 0x4B,    //K key
        [Description("L key")]
        VK_KeyL = 0x4C,    //L key
        [Description("M key")]
        VK_KeyM = 0x4D,    //M key
        [Description("N key")]
        VK_KeyN = 0x4E,    //N key
        [Description("O key")]
        VK_KeyO = 0x4F,    //O key
        [Description("P key")]
        VK_KeyP = 0x50,    //P key
        [Description("Q key")]
        VK_KeyQ = 0x51,    //Q key
        [Description("R key")]
        VK_KeyR = 0x52,    //R key
        [Description("S key")]
        VK_KeyS = 0x53,    //S key
        [Description("T key")]
        VK_KeyT = 0x54,    //T key
        [Description("U key")]
        VK_KeyU = 0x55,    //U key
        [Description("V key")]
        VK_KeyV = 0x56,    //V key
        [Description("W key")]
        VK_KeyW = 0x57,    //W key
        [Description("X key")]
        VK_KeyX = 0x58,    //X key
        [Description("Y key")]
        VK_KeyY = 0x59,    //Y key
        [Description("Z key")]
        VK_KeyZ = 0x5A,    //Z key
        [Description("Left Windows key (Natural keyboard)")]
        VK_LWIN = 0x5B, //Left Windows key (Natural keyboard)
        [Description("Right Windows key (Natural keyboard)")]
        VK_RWIN = 0x5C, //Right Windows key (Natural keyboard)
        [Description("Applications key (Natural keyboard)")]
        VK_APPS = 0x5D, //Applications key (Natural keyboard)
        [Description("Computer Sleep key")]
        VK_SLEEP = 0x5F, //Computer Sleep key
        [Description("Numeric keypad 0 key")]
        VK_NUMPAD0 = 0x60, //Numeric keypad 0 key
        [Description("Numeric keypad 1 key")]
        VK_NUMPAD1 = 0x61, //Numeric keypad 1 key
        [Description("Numeric keypad 2 key")]
        VK_NUMPAD2 = 0x62, //Numeric keypad 2 key
        [Description("Numeric keypad 3 key")]
        VK_NUMPAD3 = 0x63, //Numeric keypad 3 key
        [Description("Numeric keypad 4 key")]
        VK_NUMPAD4 = 0x64, //Numeric keypad 4 key
        [Description("Numeric keypad 5 key")]
        VK_NUMPAD5 = 0x65, //Numeric keypad 5 key
        [Description("Numeric keypad 6 key")]
        VK_NUMPAD6 = 0x66, //Numeric keypad 6 key
        [Description("Numeric keypad 7 key")]
        VK_NUMPAD7 = 0x67, //Numeric keypad 7 key
        [Description("Numeric keypad 8 key")]
        VK_NUMPAD8 = 0x68, //Numeric keypad 8 key
        [Description("Numeric keypad 9 key")]
        VK_NUMPAD9 = 0x69, //Numeric keypad 9 key
        [Description("Multiply key")]
        VK_MULTIPLY = 0x6A, //Multiply key
        [Description("Add key")]
        VK_ADD = 0x6B, //Add key
        [Description("Separator key")]
        VK_SEPARATOR = 0x6C, //Separator key
        [Description("Subtract key")]
        VK_SUBTRACT = 0x6D, //Subtract key
        [Description("Decimal key")]
        VK_DECIMAL = 0x6E, //Decimal key
        [Description("Divide key")]
        VK_DIVIDE = 0x6F, //Divide key
        [Description("F1 key")]
        VK_F1 = 0x70, //F1 key
        [Description("F2 key")]
        VK_F2 = 0x71, //F2 key
        [Description("F3 key")]
        VK_F3 = 0x72, //F3 key
        [Description("F4 key")]
        VK_F4 = 0x73, //F4 key
        [Description("F5 key")]
        VK_F5 = 0x74, //F5 key
        [Description("F6 key")]
        VK_F6 = 0x75, //F6 key
        [Description("F7 key")]
        VK_F7 = 0x76, //F7 key
        [Description("F8 key")]
        VK_F8 = 0x77, //F8 key
        [Description("F9 key")]
        VK_F9 = 0x78, //F9 key
        [Description("F10 key")]
        VK_F10 = 0x79, //F10 key
        [Description("F11 key")]
        VK_F11 = 0x7A, //F11 key
        [Description("F12 key")]
        VK_F12 = 0x7B, //F12 key
        [Description("F13 key")]
        VK_F13 = 0x7C, //F13 key
        [Description("F14 key")]
        VK_F14 = 0x7D, //F14 key
        [Description("F15 key")]
        VK_F15 = 0x7E, //F15 key
        [Description("F16 key")]
        VK_F16 = 0x7F, //F16 key
        [Description("F17 key")]
        VK_F17 = 0x80, //F17 key
        [Description("F18 key")]
        VK_F18 = 0x81, //F18 key
        [Description("F19 key")]
        VK_F19 = 0x82, //F19 key
        [Description("F20 key")]
        VK_F20 = 0x83, //F20 key
        [Description("F21 key")]
        VK_F21 = 0x84, //F21 key
        [Description("F22 key")]
        VK_F22 = 0x85, //F22 key
        [Description("F23 key")]
        VK_F23 = 0x86, //F23 key
        [Description("F24 key")]
        VK_F24 = 0x87, //F24 key
        [Description("NUM LOCK key")]
        VK_NUMLOCK = 0x90, //NUM LOCK key
        [Description("SCROLL LOCK key")]
        VK_SCROLL = 0x91, //SCROLL LOCK key
        [Description("Left SHIFT key")]
        VK_LSHIFT = 0xA0, //Left SHIFT key
        [Description("Right SHIFT key")]
        VK_RSHIFT = 0xA1, //Right SHIFT key
        [Description("Left CONTROL key")]
        VK_LCONTROL = 0xA2, //Left CONTROL key
        [Description("Right CONTROL key")]
        VK_RCONTROL = 0xA3, //Right CONTROL key
        [Description("Left MENU key")]
        VK_LMENU = 0xA4, //Left MENU key
        [Description("Right MENU key")]
        VK_RMENU = 0xA5, //Right MENU key
        [Description("Browser Back key")]
        VK_BROWSER_BACK = 0xA6, //Browser Back key
        [Description("Browser Forward key")]
        VK_BROWSER_FORWARD = 0xA7, //Browser Forward key
        [Description("Browser Refresh key")]
        VK_BROWSER_REFRESH = 0xA8, //Browser Refresh key
        [Description("Browser Stop key")]
        VK_BROWSER_STOP = 0xA9, //Browser Stop key
        [Description("Browser Search key")]
        VK_BROWSER_SEARCH = 0xAA, //Browser Search key
        [Description("Browser Favorites key")]
        VK_BROWSER_FAVORITES = 0xAB, //Browser Favorites key
        [Description("Browser Start and Home key")]
        VK_BROWSER_HOME = 0xAC, //Browser Start and Home key
        [Description("Volume Mute key")]
        VK_VOLUME_MUTE = 0xAD, //Volume Mute key
        [Description("Volume Down key")]
        VK_VOLUME_DOWN = 0xAE, //Volume Down key
        [Description("Volume Up key")]
        VK_VOLUME_UP = 0xAF, //Volume Up key
        [Description("Next Track key")]
        VK_MEDIA_NEXT_TRACK = 0xB0, //Next Track key
        [Description("Previous Track key")]
        VK_MEDIA_PREV_TRACK = 0xB1, //Previous Track key
        [Description("Stop Media key")]
        VK_MEDIA_STOP = 0xB2, //Stop Media key
        [Description("Play/Pause Media key")]
        VK_MEDIA_PLAY_PAUSE = 0xB3, //Play/Pause Media key
        [Description("Start Mail key")]
        VK_LAUNCH_MAIL = 0xB4, //Start Mail key
        [Description("Select Media key")]
        VK_LAUNCH_MEDIA_SELECT = 0xB5, //Select Media key
        [Description("Start Application 1 key")]
        VK_LAUNCH_APP1 = 0xB6, //Start Application 1 key
        [Description("Start Application 2 key")]
        VK_LAUNCH_APP2 = 0xB7, //Start Application 2 key
        [Description("Used for miscellaneous characters, it can vary by keyboard. For the US standard keyboard, the ',:' key")]
        VK_OEM_1 = 0xBA, //Used for miscellaneous characters, it can vary by keyboard. For the US standard keyboard, the ',:' key
        [Description("For any country/region, the '+' key")]
        VK_OEM_PLUS = 0xBB, //For any country/region, the '+' key
        [Description("For any country/region, the ',' key")]
        VK_OEM_COMMA = 0xBC, //For any country/region, the ',' key
        [Description("For any country/region, the '-' key")]
        VK_OEM_MINUS = 0xBD, //For any country/region, the '-' key
        [Description("For any country/region, the '.' key")]
        VK_OEM_PERIOD = 0xBE, //For any country/region, the '.' key
        [Description("Used for miscellaneous characters, it can vary by keyboard. For the US standard keyboard, the '/?' key")]
        VK_OEM_2 = 0xBF, //Used for miscellaneous characters, it can vary by keyboard. For the US standard keyboard, the '/?' key
        [Description("Used for miscellaneous characters, it can vary by keyboard. For the US standard keyboard, the '`~' key")]
        VK_OEM_3 = 0xC0, //Used for miscellaneous characters, it can vary by keyboard. For the US standard keyboard, the '`~' key
        [Description("Used for miscellaneous characters, it can vary by keyboard. For the US standard keyboard, the '[{' key")]
        VK_OEM_4 = 0xDB, //Used for miscellaneous characters, it can vary by keyboard. For the US standard keyboard, the '[{' key
        [Description("Used for miscellaneous characters, it can vary by keyboard. For the US standard keyboard, the '\\|' key")]
        VK_OEM_5 = 0xDC, //Used for miscellaneous characters, it can vary by keyboard. For the US standard keyboard, the '\|' key
        [Description("Used for miscellaneous characters, it can vary by keyboard. For the US standard keyboard, the ']}' key")]
        VK_OEM_6 = 0xDD, //Used for miscellaneous characters, it can vary by keyboard. For the US standard keyboard, the ']}' key
        [Description("Used for miscellaneous characters, it can vary by keyboard. For the US standard keyboard, the 'single-quote/double-quote' key")]
        VK_OEM_7 = 0xDE, //Used for miscellaneous characters, it can vary by keyboard. For the US standard keyboard, the 'single-quote/double-quote' key
        [Description("Used for miscellaneous characters, it can vary by keyboard.")]
        VK_OEM_8 = 0xDF, //Used for miscellaneous characters, it can vary by keyboard.
        [Description("The <> keys on the US standard keyboard, or the \\| key on the non-US 102-key keyboard")]
        VK_OEM_102 = 0xE2, //The <> keys on the US standard keyboard, or the \\| key on the non-US 102-key keyboard
        [Description("IME PROCESS key")]
        VK_PROCESSKEY = 0xE5, //IME PROCESS key
        [Description("Used to pass Unicode characters as if they were keystrokes. The VK_PACKET key is the low word of a 32-bit Virtual Key value used for non-keyboard input methods. For more information, see Remark in KEYBDINPUT, SendInput, WM_KEYDOWN, and WM_KEYUP")]
        VK_PACKET = 0xE7, //Used to pass Unicode characters as if they were keystrokes. The VK_PACKET key is the low word of a 32-bit Virtual Key value used for non-keyboard input methods. For more information, see Remark in KEYBDINPUT, SendInput, WM_KEYDOWN, and WM_KEYUP
        [Description("Attn key")]
        VK_ATTN = 0xF6, //Attn key
        [Description("CrSel key")]
        VK_CRSEL = 0xF7, //CrSel key
        [Description("ExSel key")]
        VK_EXSEL = 0xF8, //ExSel key
        [Description("Erase EOF key")]
        VK_EREOF = 0xF9, //Erase EOF key
        [Description("Play key")]
        VK_PLAY = 0xFA, //Play key
        [Description("Zoom key")]
        VK_ZOOM = 0xFB, //Zoom key
        [Description("Reserved")]
        VK_NONAME = 0xFC, //Reserved
        [Description("PA1 key")]
        VK_PA1 = 0xFD, //PA1 key
        [Description("key")]
        VK_OEM_CLEAR = 0xFE //Clear key
    }
}
