using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;

namespace HollowLockScreen.Password
{
    [Serializable]
    internal class PasswordObject
    {
        private PasswordNode _head;
        private PasswordNode _tail;
        private PasswordNode _checkNode; //this is the node we are checking for password matche
        private uint _size;
        private uint _totalMatches;
        private uint _currentMatches;


        internal PasswordNode First()
        {
            return _head;
        }

        internal PasswordNode Last()
        {
            return _tail;
        }

        internal uint Size()
        {
            return _size;
        }

        /// <summary>
        /// Calculates the total length of the string password
        /// </summary>
        /// <returns></returns>
        internal int TotalPasswordLength()
        {
            int totalStringLength = 0;
            PasswordNode node = this._head;

            while (node != null)
            {
                if (node.Data.NodeType == PasswordNodeTypeEnum.String)
                {
                    totalStringLength += node.Data.PasswordText.Length;
                }
                node = node.Next;
            }
            return totalStringLength;
        }

        internal void AddNode(PasswordNodeData data)
        {
            PasswordNode newNode = new PasswordNode();
            newNode.Data = data;

            if (_size == 0)
            {
                _head = newNode;
                _tail = newNode;
                _size = 1;
            }
            else
            {
                _tail.Next = newNode;
                newNode.Previous = _tail;
                _tail = newNode;
                _size++;
            }
        }

        internal bool Compare(PasswordObject passwordObjectToCompare)
        {
            bool areTheSame = false;
            if (this._size > 0)
            {
                if (this._size == passwordObjectToCompare.Size())
                {
                    PasswordNode currentNode = _head;
                    PasswordNode currentNodeToCompare = passwordObjectToCompare.First();
                    while (currentNode != null && currentNodeToCompare != null)
                    {
                        if (currentNode.Data.NodeType == currentNodeToCompare.Data.NodeType)
                        {
                            if (currentNode.Data.NodeType == PasswordNodeTypeEnum.MouseButton)
                            {
                                areTheSame = currentNode.Data.MouseButtonType == currentNodeToCompare.Data.MouseButtonType;
                            }
                            else
                            {
                                areTheSame = currentNode.Data.PasswordText == currentNodeToCompare.Data.PasswordText;
                            }
                        }
                        currentNode = currentNode.Next;
                        currentNodeToCompare = currentNodeToCompare.Next;

                        if (!areTheSame)
                        {
                            break;
                        }
                    }
                }
            }
            return areTheSame;
        }

        internal void PrepareForMatching()
        {
            _currentMatches = 0;
            _totalMatches = _size;
            _checkNode = _head;
        }

        internal bool IsValid(PasswordNode inputNode)
        {
            bool isValidated = false;

            if (_size > 0)
            {
                bool isStringValidated = false;
                bool isMouseInputValidated = false;

                if (_checkNode == null)
                {
                    _checkNode = _head;
                }

                if (inputNode != null)
                {
                    if (inputNode.Data != null)
                    {
                        //check only if the input node's type is the same as the type we want to check next
                        if (_checkNode.Data.NodeType == inputNode.Data.NodeType)
                        {
                            switch (inputNode.Data.NodeType)
                            {
                                case PasswordNodeTypeEnum.String:
                                    isStringValidated = IsStringValid(_checkNode, inputNode.Data.PasswordText);
                                    MoveToNextCheckNode(isStringValidated, inputNode.Data.NodeType);
                                    break;
                                case PasswordNodeTypeEnum.MouseButton:
                                    isMouseInputValidated = IsMouseInputValid(_checkNode, inputNode.Data.MouseButtonType);
                                    MoveToNextCheckNode(isMouseInputValidated, inputNode.Data.NodeType);
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }


                //all nodes need to return true when validating in order to accept the password. Misses must be 0
                isValidated = _currentMatches == _totalMatches;
            }

            return isValidated;
        }

        private void MoveToNextCheckNode(bool isPatternValid, PasswordNodeTypeEnum nodeType)
        {
            if (isPatternValid)
            {
                _checkNode = _checkNode.Next;
                _currentMatches++;
            }
            else
            {
                if (nodeType == PasswordNodeTypeEnum.MouseButton)
                {
                    _checkNode = _checkNode.Next;
                    _currentMatches = 0;
                }
            }
        }

        private bool IsStringValid(PasswordNode checkNode, string text)
        {
            bool isStringValidated = false;

            if (checkNode != null)
            {
                int startIndex = text.Length - checkNode.Data.PasswordText.Length; //skips the existing text that we already matched
                startIndex = startIndex > 0 ? startIndex : 0;
                isStringValidated = checkNode.Data.PasswordText == text.Substring(startIndex);
            }

            return isStringValidated;
        }

        private bool IsMouseInputValid(PasswordNode checkNode, MouseButtonTypeEnum mouseButtonType)
        {
            return checkNode?.Data.MouseButtonType == mouseButtonType;
        }
    }
}