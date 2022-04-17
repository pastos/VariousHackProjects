using KeyboardInputEvent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gArticCheatSheet
{
    public partial class WinFormApp : Form
    {
        private string _folderPath;
        public WinFormApp()
        {
            InitializeComponent();
        }

        #region Event Handlers
        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            _folderPath = folderBrowserDialog.SelectedPath;
            txtFolderPath.Text = _folderPath;
            LoadImages();
        }
        #endregion

        private void LoadImages()
        {
            FileHelper.Instance.ScanImageFolder(_folderPath);
            imgList.Images.Clear();
            foreach (var item in FileHelper.Instance.ImagePropertyCollection)
            {
                imgList.Images.Add(item.Name, item.Asset);
            }
            listViewImages.LargeImageList = imgList;

            for (int i = 0; i < imgList.Images.Count; i++)
            {
                ListViewItem listView = new ListViewItem(imgList.Images.Keys[i], i);
                listView.Text = imgList.Images.Keys[i];

                listViewImages.Items.Add(listView);
            }
        }

        private void listViewImages_ItemActivate(object sender, EventArgs e)
        {
            ExternalWindowHelper.BringWindowToFront(txtFocusApp.Text);

            //MarshalClass.PressKey(VK_Codes.VK_KeyE);
            //MarshalClass.PressKey(VK_Codes.VK_KeyD);
            //MarshalClass.PressKey(VK_Codes.VK_KeyC);
            //MarshalClass.PressKey(VK_Codes.VK_KeyB);
            //MarshalClass.PressKey(VK_Codes.VK_KeyA);
            //MarshalClass.PressKey(VK_Codes.VK_RETURN);

            //foreach (char item in e.Item.Text)
            //{

            //    //MarshalClass.PressKey());
            //}

            //MarshalClass.PressKey(VK_Codes.VK_RETURN);
        }

        private void listViewImages_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            string s = ExternalWindowHelper.GetActiveWindowTitle();
            if (e.IsSelected)
            {
                //ExternalWindowHelper.SendMessageToWindow("discord", "dsdsd");                
                bool isWindowToFront = ExternalWindowHelper.BringWindowToFront(txtFocusApp.Text);

                if (isWindowToFront)
                {
                    //MarshalClass.PressKey(VK_Codes.VK_KeyE);
                    //MarshalClass.PressKey(VK_Codes.VK_KeyD);
                    //MarshalClass.PressKey(VK_Codes.VK_KeyC);
                    //MarshalClass.PressKey(VK_Codes.VK_KeyB);
                    //MarshalClass.PressKey(VK_Codes.VK_KeyA);
                    //MarshalClass.PressKey(VK_Codes.VK_RETURN);

                    //foreach (char item in e.Item.Text)
                    //{

                    //    //MarshalClass.PressKey());
                    //}

                    //MarshalClass.PressKey(VK_Codes.VK_RETURN);
                }
            }
        }
    }
}
