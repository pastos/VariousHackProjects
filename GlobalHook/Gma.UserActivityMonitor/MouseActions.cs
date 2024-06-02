using System;
using System.Runtime.InteropServices;

namespace InputActivityMonitor
{
    //from here https://stackoverflow.com/questions/2416748/how-do-you-simulate-mouse-click-in-c
    
    /// <summary>
    /// Contains methods of possible mouse actions
    /// </summary>
    public class MouseActions
    {
        /// <summary>
        /// The event flags of mouse actions in hex listed as enumeration
        /// </summary>
        [Flags]
        public enum MouseEventFlags
        {
            /// <summary>
            /// Left mouse down
            /// </summary>
            LeftDown = 0x00000002,
            /// <summary>
            /// Left mouse up
            /// </summary>
            LeftUp = 0x00000004,
            /// <summary>
            /// Middle mouse down
            /// </summary>
            MiddleDown = 0x00000020,
            /// <summary>
            /// Middle mouse up
            /// </summary>
            MiddleUp = 0x00000040,
            /// <summary>
            /// Mouse move
            /// </summary>
            Move = 0x00000001,
            /// <summary>
            /// unknown
            /// </summary>
            Absolute = 0x00008000,
            /// <summary>
            /// Right mouse down
            /// </summary>
            RightDown = 0x00000008,
            /// <summary>
            /// Right mouse up
            /// </summary>
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

        /// <summary>
        /// Sets the mouse cursor at the x,y position of the screen. Top left is 0,0
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public static void SetCursorPosition(int x, int y)
        {
            SetCursorPos(x, y);
        }

        /// <summary>
        /// Sets the mouse cursor at the MousePoint position of the screen. Top left is 0,0
        /// </summary>
        /// <param name="point"></param>
        public static void SetCursorPosition(MousePoint point)
        {
            SetCursorPos(point.X, point.Y);
        }

        /// <summary>
        /// Gets the current mouse position, otherwise returns the 0,0 position
        /// </summary>
        /// <returns></returns>
        public static MousePoint GetCursorPosition()
        {
            MousePoint currentMousePoint;
            var gotPoint = GetCursorPos(out currentMousePoint);
            if (!gotPoint) { currentMousePoint = new MousePoint(0, 0); }
            return currentMousePoint;
        }

        /// <summary>
        /// Returns the mouse event that was triggered
        /// </summary>
        /// <param name="value"></param>
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

        /// <summary>
        /// Forces the mouse to click at the specified x,y position
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public static void ClickAtPosition(int x, int y)
        {
            //MousePoint currentPoint = MouseActions.GetCursorPosition();
            SetCursorPosition(x, y);
            MouseEvent(MouseEventFlags.LeftDown);
            MouseEvent(MouseEventFlags.LeftUp);
            //SetCursorPosition(currentPoint);
        }

        /// <summary>
        /// Forces the mouse to click at the specified x,y position, and then return the cursor at its previous position
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public static void ClickAndReturnAtPosition(int x, int y)
        {
            MousePoint currentPoint = MouseActions.GetCursorPosition();
            SetCursorPosition(x, y);
            MouseEvent(MouseEventFlags.LeftDown);
            MouseEvent(MouseEventFlags.LeftUp);
            SetCursorPosition(currentPoint);
        }

        /// <summary>
        /// Forces the mouse cursor to drag from start to end.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public static void DragToPoint(MousePoint start, MousePoint end)
        {
            SetCursorPosition(start);
            MouseEvent(MouseEventFlags.LeftDown);
            SetCursorPosition(end);
            MouseEvent(MouseEventFlags.LeftUp);
        }

        /// <summary>
        /// Forces the mouse cursor to drag from startX to endX and startY to endY.
        /// </summary>
        /// <param name="startX"></param>
        /// <param name="startY"></param>
        /// <param name="endX"></param>
        /// <param name="endY"></param>
        public static void DragToPoint(int startX, int startY, int endX, int endY)
        {
            SetCursorPosition(startX, startY);
            MouseEvent(MouseEventFlags.LeftDown);
            SetCursorPosition(endX, endY);
            MouseEvent(MouseEventFlags.LeftUp);
        }

        #endregion

        /// <summary>
        /// Struct for representing the x,y point for the mouse
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct MousePoint
        {
            /// <summary>
            /// X position of the MousePoint struct
            /// </summary>
            public int X;
            /// <summary>
            /// Y position of the MousePoint struct
            /// </summary>
            public int Y;

            /// <summary>
            /// Constructor to declare the x,y position
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            public MousePoint(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
    }
}