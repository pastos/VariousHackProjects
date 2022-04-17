using System;
using System.Runtime.InteropServices;

namespace MouseHelper
{
    //from here https://stackoverflow.com/questions/2416748/how-do-you-simulate-mouse-click-in-c
    public class MouseActions
    {
        [Flags]
        public enum MouseEventFlags
        {
            LeftDown = 0x00000002,
            LeftUp = 0x00000004,
            MiddleDown = 0x00000020,
            MiddleUp = 0x00000040,
            Move = 0x00000001,
            Absolute = 0x00008000,
            RightDown = 0x00000008,
            RightUp = 0x00000010
        }

        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetCursorPos(out MousePoint lpMousePoint);

        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        public static void SetCursorPosition(int x, int y)
        {
            SetCursorPos(x, y);
        }

        public static void SetCursorPosition(MousePoint point)
        {
            SetCursorPos(point.X, point.Y);
        }

        public static MousePoint GetCursorPosition()
        {
            MousePoint currentMousePoint;
            var gotPoint = GetCursorPos(out currentMousePoint);
            if (!gotPoint) { currentMousePoint = new MousePoint(0, 0); }
            return currentMousePoint;
        }

        public static void MouseEvent(MouseEventFlags value)
        {
            MousePoint position = GetCursorPosition();

            mouse_event
                ((int)value,
                 position.X,
                 position.Y,
                 0,
                 0)
                ;
        }

        #region Custom methods (not initially included in this code)
        public static void ClickAtPosition(int x, int y)
        {
            MousePoint currentPoint = MouseActions.GetCursorPosition();
            SetCursorPosition(x, y);
            MouseEvent(MouseEventFlags.LeftDown);
            MouseEvent(MouseEventFlags.LeftUp);
            SetCursorPosition(currentPoint);
        }

        public static void DragToPoint(MousePoint start, MousePoint end)
        {
            SetCursorPosition(start);
            MouseEvent(MouseEventFlags.LeftDown);
            SetCursorPosition(end);
            MouseEvent(MouseEventFlags.LeftUp);
        }

        public static void DragToPoint(int startX, int startY, int endX, int endY)
        {
            SetCursorPosition(startX, startY);
            MouseEvent(MouseEventFlags.LeftDown);
            SetCursorPosition(endX, endY);
            MouseEvent(MouseEventFlags.LeftUp);
        }

        #endregion

        [StructLayout(LayoutKind.Sequential)]
        public struct MousePoint
        {
            public int X;
            public int Y;

            public MousePoint(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
    }
}