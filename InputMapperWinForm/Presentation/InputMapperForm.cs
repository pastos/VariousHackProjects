using InputActivityMonitor;
using InputMapperWinForm.Events;
using InputMapperWinForm.Events.Mouse;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InputMapperWinFormPresentation
{
    public partial class InputMapperForm : Form
    {
        private List<ISimpleMapInput<EventArgs>> _temp;
        private List<ISimpleMapInput> _temp2;
        public InputMapperForm()
        {
            InitializeComponent();
            InitializeHooks();
        }

        private void InitializeHooks()
        {
            //InputActivityMonitor.HookManager.MouseClick += HookManager_MouseClick; ;
            //InputActivityMonitor.HookManager.MouseMove += HookManager_MouseMove1; ;
            //HookManager.MouseWheelExt += HookManager_MouseWheelExt;
            //HookManager.KeyPress += HookManager_KeyPress;
            //HookManager.KeyDown += HookManager_KeyDown;
            //HookManager.KeyUp += HookManager_KeyUp;

            _temp = new List<ISimpleMapInput<EventArgs>>();
            _temp2 = new List<ISimpleMapInput>();
        }

        private void HookManager_KeyUp(object sender, KeyEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void HookManager_KeyDown(object sender, KeyEventArgs e)
        {
            //e.Handled = true;
            //var node = uCtrlActionMapManager1._objectLL.First;
            //while(node != null)
            //{ 
            //    if((int)node.Value.ActionMap.Original == e.KeyValue)
            //    {
            //        KeyboardInputEvent.MarshalClass.KeyPress(node.Value.ActionMap.Destination);
            //    }
            //    node = node.Next;
            //}

        }

        private void HookManager_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        //ISimpleMapInput<EventArgs> d;

        ISimpleMapInput f;
        private void HookManager_MouseWheelExt(object sender, MouseEventExtArgs e)
        {
            //MouseWheelAction<MouseEventExtArgs> d = new MouseWheelAction<MouseEventExtArgs>();
            MouseWheelAction<MouseEventExtArgs> d = new MouseWheelAction<MouseEventExtArgs>();
            f = new MouseWheelAction();
            //.HookManager_ActionExtUp(sender, e, KeyboardInputEvent.VKCodesEnum.VK_KeyZ)
            if (e.Delta > 0)
            {
                //
                txtOutput.Text += "Wheel up";
                txtOutput.Text += Environment.NewLine;
                KeyboardInputEvent.MarshalClass.KeyPress(KeyboardInputEvent.VKCodesEnum.VK_KeyZ);
                //_temp2.Add(f);
                //_temp.Add();
                //_temp[0].HookManager_ActionExtUp(sender, e, KeyboardInputEvent.VKCodesEnum.VK_KeyZ);
            }
            else
            {
                //
                txtOutput.Text += "Wheel down";
                txtOutput.Text += Environment.NewLine;
                KeyboardInputEvent.MarshalClass.KeyPress(KeyboardInputEvent.VKCodesEnum.VK_KeyX);
            }
            e.Handled = true;
        }

        private void HookManager_MouseMove(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void HookManager_MouseClick(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }        
    }
}
