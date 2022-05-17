using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Diagnostics;

namespace InputActivityMonitor
{
    /// <summary>
    /// Helper for finding windows and bring them to the front
    /// </summary>
    public class ExternalWindowHelper
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern IntPtr GetForegroundWindow();
        [DllImport("User32.dll")]
        private static extern Int32 SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern bool GetWindowRect(IntPtr hWnd, out Rectangle rect);

        public static bool IsWindowAtFront { get; private set; }
        public static void BringWindowToFront(string windowName)
        {
            IsWindowAtFront = false;
            IntPtr hWnd = FindName(windowName);
            //IntPtr some = GetForegroundWindow();
            //IntPtr hWnd = FindWindow(null, windowName);
            if (hWnd != IntPtr.Zero)
            {
                SetForegroundWindow(hWnd);
                IsWindowAtFront = true;
            }
        }

        public static IntPtr FindName(string windowName)
        {
            IntPtr hWnd = IntPtr.Zero;
            foreach (Process pList in Process.GetProcesses())
            {
                if (pList.MainWindowTitle.Contains(windowName))
                {
                    hWnd = pList.MainWindowHandle;
                }
            }
            GetBoundsOfWindow(hWnd);
            return hWnd;
        }

        public static Rectangle GetBoundsOfWindow(IntPtr hWnd)
        {
            Rectangle rect = new Rectangle();

            if (hWnd != IntPtr.Zero)
            {
                GetWindowRect(hWnd, out rect);
            }
            return rect;
        }

        public static Rectangle GetBoundsOfWindow(string windowName)
        {
            IntPtr hWnd = FindWindow(null, windowName);
            Rectangle rect = new Rectangle();

            if (hWnd != IntPtr.Zero)
            {
                GetWindowRect(hWnd, out rect);
            }
            return rect;
        }
    }
} 