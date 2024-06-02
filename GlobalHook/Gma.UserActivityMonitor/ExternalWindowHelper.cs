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

        /// <summary>
        /// True if currently used window is at front
        /// </summary>
        public static bool IsWindowAtFront { get; private set; }
        
        /// <summary>
        /// Brings the window with name 'windowName' to the front
        /// </summary>
        /// <param name="windowName"></param>
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

        /// <summary>
        /// Finds the name of the window that contains 'windowName' in its name
        /// </summary>
        /// <param name="windowName"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets the rectangular boundaries of the window based on its IntPtr
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        public static Rectangle GetBoundsOfWindow(IntPtr hWnd)
        {
            Rectangle rect = new Rectangle();

            if (hWnd != IntPtr.Zero)
            {
                GetWindowRect(hWnd, out rect);
            }
            return rect;
        }

        /// <summary>
        /// Gets the rectangular boundaries of the window based on its name 'windowName'
        /// </summary>
        /// <param name="windowName"></param>
        /// <returns></returns>
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