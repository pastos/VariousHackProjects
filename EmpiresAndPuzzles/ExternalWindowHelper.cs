using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace EmpiresAndPuzzles
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


        public Rectangle GetBoundsOfWindow(string windowName)
        {
            IntPtr hWnd = FindWindow(null, windowName);
            Rectangle rect = new Rectangle();

            if (hWnd != IntPtr.Zero)
            {
                GetWindowRect(hWnd, out rect);
            }
            return rect;
        }

        public void BringWindowToFront(string windowName)
        {
            IntPtr hWnd = FindWindow(null, windowName);
            if (hWnd != IntPtr.Zero)
            {
                SetForegroundWindow(hWnd);
            }
        }
    }
}
