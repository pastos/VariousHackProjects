using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace gArticCheatSheet
{
    public class ExternalWindowHelper
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetForegroundWindow();
        [DllImport("User32.dll")]
        private static extern Int32 SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern bool GetWindowRect(IntPtr hWnd, out Rectangle rect);

        [DllImport("user32.dll", EntryPoint = "FindWindowEx")]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam);        
        
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);        

        public static string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder windowText = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();
            GetWindowText(handle, windowText, nChars);
            //if (GetWindowText(handle, windowText, nChars) > 0)
            //{
            //    return windowText.ToString();
            //}
            //return null;
            return windowText.ToString();
        }

        private static IntPtr GetProcess(string processName)
        {
            IntPtr result = default;
            Process[] processes = Process.GetProcessesByName(processName);

            if (processes.Length > 1)
            {
                result = FindWindowEx(processes[0].MainWindowHandle, new IntPtr(0), "Edit", null);

            }
            return result;
        }

        public static bool BringWindowToFront(string windowName)
        {
            bool isSuccessful = false;
            IntPtr hWnd = FindWindow(null, windowName);
            if (hWnd != IntPtr.Zero)
            {
                SetForegroundWindow(hWnd);
                isSuccessful = true;
            }
            return isSuccessful;
        }

        public static void SendMessageToWindow(string processName, string message)
        {
            SendMessage(GetProcess(processName), 0x000C, 0, message);
        }
    }
}
