using InputActivityMonitor;
using InputMapperWinForm.Mappings;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InputMapperWinForm.Presentation.CustomControls
{
    public partial class UCtrlActionMapManager : UserControl
    {
        internal LinkedList<NodeObject> _objectLL;
        private NodeObject _nodeObject;

        public UCtrlActionMapManager()
        {
            InitializeComponent();
            InitializeUserControlManager();
            AddNewNode();
            LoadProfiles();
            InitializeHooks();
        }

        private void InitializeHooks()
        {
            //HookManager.MouseWheelExt += HookManager_MouseWheelExt;
            //HookManager.KeyPress += HookManager_KeyPress;
            HookManager.KeyDown += HookManager_KeyDown;
            //HookManager.KeyUp += HookManager_KeyUp;
        }

        //private void HookManager_KeyUp(object sender, KeyEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        private void HookManager_KeyDown(object sender, KeyEventArgs e)
        {
            var node = _objectLL.First;
            while (node != null)
            {
                //if ((int)node.Value.ActionMap.Original == e.KeyValue)
                var selection = (KeyboardInputEvent.VKCodesEnum)node.Value.UCtrlActionMapPanel.ExposedControls.OriginalActionCmb.SelectedItem;
                if ((int)selection == e.KeyValue)
                {
                    e.Handled = true;
                    KeyboardInputEvent.MarshalClass.KeyPress(node.Value.ActionMap.Destination);
                    //KeyboardInputEvent.MarshalClass.KeyPress(KeyboardInputEvent.VKCodesEnum.VK_KeyG);
                }
                node = node.Next;
            }
        }

        //private void HookManager_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    //throw new NotImplementedException();
        //}

        //private void HookManager_MouseWheelExt(object sender, MouseEventExtArgs e)
        //{
        //    //throw new NotImplementedException();
        //}

        private void InitializeUserControlManager()
        {
            _objectLL = new LinkedList<NodeObject>();
        }

        private void LoadProfiles()
        {

        }

        #region Control Events

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            AddNewNode();
            AdjustControlPositions();
            MakeSelfInvisible(btn);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            UCtrlButton btn = (UCtrlButton)sender;
            Control parent = btn.NodeObject.UCtrlActionMapPanel.Parent;
            parent.Controls.Remove(btn.NodeObject.UCtrlActionMapPanel);
            _objectLL.Remove(btn.NodeObject);
        }

        #endregion


        #region Visuals
        private void MakeSelfInvisible(Button btn)
        {
            btn.Visible = false;
        }


        private void AddNewNode()
        {
            _nodeObject = new NodeObject
            {
                ActionMap = new ActionMap(),
                UCtrlActionMapPanel = CreateActionMapPanel()
            };
            _objectLL.AddLast(_nodeObject);
            AssignEvents();
        }

        private void AdjustControlPositions()
        {
            ExpandHeight();
            AdjustActionMapControlPosition(_nodeObject);
        }

        private void ExpandHeight()
        {
            Height += _objectLL.Last.Value.UCtrlActionMapPanel.Top + _objectLL.Last.Value.UCtrlActionMapPanel.Height;
        }

        private void AdjustActionMapControlPosition(NodeObject node)
        {
            LinkedListNode<NodeObject> currentNode = _objectLL.Last;
            if (currentNode != null)
            {
                node.UCtrlActionMapPanel.Top += currentNode.Previous.Value.UCtrlActionMapPanel.Top + currentNode.Previous.Value.UCtrlActionMapPanel.Height;
                node.UCtrlActionMapPanel.Left = currentNode.Previous.Value.UCtrlActionMapPanel.Left;
            }
        }
        #endregion

        private UCtrlActionMapPanel CreateActionMapPanel()
        {
            UCtrlActionMapPanel obj = new UCtrlActionMapPanel();
            Controls.Add(obj);
            obj.Location = new System.Drawing.Point(0, 0);
            //obj.BringToFront();
            return obj;
        }

        private void AssignEvents()
        {
            _nodeObject.UCtrlActionMapPanel.ExposedControls.AddNewButton.Click += btnAddNew_Click;
            _nodeObject.UCtrlActionMapPanel.ExposedControls.DeleteButton.NodeObject = _nodeObject;
            _nodeObject.UCtrlActionMapPanel.ExposedControls.DeleteButton.Click += btnDelete_Click;

            _nodeObject.UCtrlActionMapPanel.ExposedControls.OriginalActionCmb.SelectedIndexChanged += OriginalActionCmb_SelectedIndexChanged;
            _nodeObject.UCtrlActionMapPanel.ExposedControls.NewActionCmb.SelectedIndexChanged += NewActionCmb_SelectedIndexChanged;
        }
        private void OriginalActionCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_nodeObject.UCtrlActionMapPanel.ExposedControls.OriginalActionCmb.SelectedItem != null)
            {
                var item = (KeyboardInputEvent.VKCodesEnum)_nodeObject.UCtrlActionMapPanel.ExposedControls.OriginalActionCmb.SelectedItem;
                _nodeObject.ActionMap.Original = item;
            }
        }

        private void NewActionCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_nodeObject.UCtrlActionMapPanel.ExposedControls.NewActionCmb.SelectedItem != null)
            {
                var item = (KeyboardInputEvent.VKCodesEnum)_nodeObject.UCtrlActionMapPanel.ExposedControls.NewActionCmb.SelectedItem;
                _nodeObject.ActionMap.Destination = item;
            }
        }

    }
}
