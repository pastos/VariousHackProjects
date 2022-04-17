using System;

namespace HollowLockScreen.Password
{
    [Serializable]
    internal class PasswordNode
    {
        public PasswordNodeData Data;
        public PasswordNode Next;
        public PasswordNode Previous;

    }
}