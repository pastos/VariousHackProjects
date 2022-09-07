using System;
using System.Threading;

namespace KeyboardInputEvent
{
    public static class CaligraphyHelper
    {
        public static void TextToKeystrokes(string text)
        {
            //MarshalClass.KeyDown(VKCodesEnum.VK_LSHIFT);
            //MarshalClass.KeyPress(VKCodesEnum.VK_Key4);
            //MarshalClass.KeyUp(VKCodesEnum.VK_LSHIFT);
            foreach (char c in text)
            {
                CheckCharacterAndType(c);
                Thread.Sleep(1);
            }
            MarshalClass.KeyPress(VKCodesEnum.VK_RETURN);
        }

        private static void CheckCharacterAndType(char c)
        {
            if (c == '@')
            {
                MarshalClass.KeyDown(VKCodesEnum.VK_LSHIFT);
                MarshalClass.KeyPress(VKCodesEnum.VK_Key2);
                MarshalClass.KeyUp(VKCodesEnum.VK_LSHIFT);
            }
            else if (c == '#')
            {
                MarshalClass.KeyDown(VKCodesEnum.VK_LSHIFT);
                MarshalClass.KeyPress(VKCodesEnum.VK_Key3);
                MarshalClass.KeyUp(VKCodesEnum.VK_LSHIFT);
            }
            else if (c == '$')
            {
                MarshalClass.KeyDown(VKCodesEnum.VK_LSHIFT);
                MarshalClass.KeyPress(VKCodesEnum.VK_Key4);
                MarshalClass.KeyUp(VKCodesEnum.VK_LSHIFT);
            }
            else if(c=='(')
            {
                MarshalClass.KeyDown(VKCodesEnum.VK_LSHIFT);
                MarshalClass.KeyPress(VKCodesEnum.VK_Key9);
                MarshalClass.KeyUp(VKCodesEnum.VK_LSHIFT);
            }
            else if (c == ')')
            {
                MarshalClass.KeyDown(VKCodesEnum.VK_LSHIFT);
                MarshalClass.KeyPress(VKCodesEnum.VK_Key0);
                MarshalClass.KeyUp(VKCodesEnum.VK_LSHIFT);
            }
            else if (c == '.')
            {
                MarshalClass.KeyPress(VKCodesEnum.VK_OEM_PERIOD);
            }
            else if (c == '\'')
            {
                MarshalClass.KeyPress(VKCodesEnum.VK_OEM_7);
            }
            else if (c == '/')
            {
                MarshalClass.KeyPress(VKCodesEnum.VK_OEM_2);
            }
            else
            {
                VKCodesEnum result;
                int convertedChar = c.ToString().ToUpper()[0];
                Enum.TryParse(convertedChar.ToString(), out result);
                MarshalClass.KeyPress(result);
            }
        }
    }
}
