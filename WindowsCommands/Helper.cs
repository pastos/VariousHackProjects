using System.Runtime.InteropServices;

namespace WindowsCommands
{
    public static class Helper
    {
        [DllImport("user32.dll")]
        public static extern bool LockWorkStation();
    }
}
