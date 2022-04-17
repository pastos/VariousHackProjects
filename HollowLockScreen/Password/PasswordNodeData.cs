using System;

namespace HollowLockScreen.Password
{
     [Serializable]
    internal class PasswordNodeData
    {
        public PasswordNodeTypeEnum NodeType;
        public string PasswordText;
        public MouseButtonTypeEnum MouseButtonType;
    }
}