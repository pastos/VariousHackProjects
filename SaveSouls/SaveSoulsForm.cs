using System;
using System.Windows.Forms;
using System.IO;
using KeyboardHooksLibrary;

namespace SoulSaver
{
    public partial class SaveSoulsForm : Form
    {
        private GlobalKeyboardHook _globalKeyboardHook;
        private string _selectedGame;
        private string _gameFullPath;
        private string _gameSaveFolderFullPath;
        private string _gameSaveFilename;
        private ComboboxItem _selectedComboItem;
        private NotifyIcon _notifyICon;

        private string QuickSaveFolder1 = Environment.CurrentDirectory + "\\QuickSaveFolder1\\";
        private string QuickSaveFolder2 = Environment.CurrentDirectory + "\\QuickSaveFolder2\\";
        private string QuickSaveFolder3 = Environment.CurrentDirectory + "\\QuickSaveFolder3\\";
        private string QuickSaveFolder4 = Environment.CurrentDirectory + "\\QuickSaveFolder4\\";

        public SaveSoulsForm()
        {
            InitializeComponent();
            InitializeKeyboardHooks();
            InitializeForm();
        }

        private void InitializeKeyboardHooks()
        {
            _globalKeyboardHook = new GlobalKeyboardHook();
            _globalKeyboardHook.KeyboardDown += OnKeyPressed;
        }

        private void InitializeForm()
        {
            SetupNotificationIcon();
            PopulateCombobox();
        }

        private void PopulateCombobox()
        {
            ComboboxItem item1 = new ComboboxItem() { Text = "Dark Souls 1", Value = "NBGI", SoulsFileName = "DRAKS0005.sl2" };
            ComboboxItem item2 = new ComboboxItem() { Text = "Dark Souls 2", Value = "DarkSoulsII", SoulsFileName = "DARKSII0000.sl2" };
            ComboboxItem item3 = new ComboboxItem() { Text = "Dark Souls 3", Value = "DarkSoulsIII", SoulsFileName = "DS30000.sl2" };
            comboBox1.Items.Add(item1);
            comboBox1.Items.Add(item2);
            comboBox1.Items.Add(item3);
            comboBox1.SelectedIndex = 2;
        }

        private void DiscoverSaveFolder()
        {
            if (Directory.Exists(_gameFullPath))
            {
                string[] innerDirectories = Directory.GetDirectories(_gameFullPath);
                if (innerDirectories != null && innerDirectories.Length > 0)
                {
                    _gameSaveFolderFullPath = innerDirectories[0];
                }
            }
            else
            {
                txtLog.AppendText("Can't find the save folder. Please try selecting it manually." + Environment.NewLine);
            }
        }

        private void OnKeyPressed(object sender, GlobalKeyboardHookEventArgs e)
        {
            //Debug.WriteLine(e.KeyboardData.VirtualCode);

            //if (e.KeyboardData.VirtualCode != GlobalKeyboardHook.VkSnapshot)
            //    return;

            // seems, not needed in the life.
            //if (e.KeyboardState == GlobalKeyboardHook.KeyboardState.SysKeyDown &&
            //    e.KeyboardData.Flags == GlobalKeyboardHook.LlkhfAltdown)
            //{
            //    MessageBox.Show("Alt + Print Screen");
            //    e.Handled = true;
            //}
            //else

            if (e.KeyboardState == GlobalKeyboardHook.KeyboardState.KeyUp)
            {
                string keyPressed = GlobalKeyboardHook.KeyPressed(e.KeyboardData.VirtualCode);
                if (!string.IsNullOrEmpty(keyPressed))
                {
                    e.Handled = true;
                    if (keyPressed == "F1")
                    {
                        QuickSave(QuickSaveFolder1, 1);
                    }
                    else if (keyPressed == "F2")
                    {
                        QuickSave(QuickSaveFolder2, 2);
                    }
                    else if (keyPressed == "F3")
                    {
                        QuickSave(QuickSaveFolder3, 3);
                    }
                    else if (keyPressed == "F4")
                    {
                        QuickSave(QuickSaveFolder4, 4);
                    }
                    else if (keyPressed == "F5")
                    {
                        QuickLoad(QuickSaveFolder1, 1);
                    }
                    else if ((keyPressed == "F6"))
                    {
                        QuickLoad(QuickSaveFolder2, 2);
                    }
                    else if (keyPressed == "F7")
                    {
                        QuickLoad(QuickSaveFolder3, 3);
                    }
                    else if (keyPressed == "F8")
                    {
                        QuickLoad(QuickSaveFolder4, 4);
                    }

                }
            }
        }

        #region Save/Load Methods
        private void QuickSave(string destination, int quickSaveNumber)
        {
            string soulFileFullPath = txtGameSavePath.Text; // _gameSaveFolderFullPath + "\\" + _gameSaveFilename;
            string destinationFileFullPath = destination + "\\" + _gameSaveFilename;

            try
            {
                if (!Directory.Exists(destination))
                {
                    Directory.CreateDirectory(destination);
                }

                File.Copy(soulFileFullPath, destinationFileFullPath, true);
                string body = string.Format("Game Saved (QuickSave {0})", quickSaveNumber);
                txtLog.AppendText(body + Environment.NewLine);
                ShowBaloonNotification(body);
            }
            catch
            {

            }
        }

        private void QuickLoad(string loadDestination, int quickLoadNumber)
        {
            BackupOriginal(); //backup first before loading
            string soulFileFullPath = txtGameSavePath.Text; // _gameSaveFolderFullPath + "\\" + _gameSaveFilename;
            string loadDestinationFileFullPath = loadDestination + "\\" + _gameSaveFilename;

            if (File.Exists(soulFileFullPath) && File.Exists(loadDestinationFileFullPath))
            {
                try
                {
                    File.Copy(loadDestinationFileFullPath, soulFileFullPath, true);
                    string body = string.Format("Game Loaded (QuickLoad {0})", quickLoadNumber);
                    txtLog.AppendText(body + Environment.NewLine);
                    ShowBaloonNotification(body);
                }
                catch (Exception ex)
                {
                    txtLog.AppendText(ex.Message + Environment.NewLine);
                }
            }
        }

        private void BackupOriginal()
        {
            string soulFileFullPath = _gameSaveFolderFullPath + "\\" + _gameSaveFilename;
            string backupLocation = "Backup";
            string backupFileFullPath = backupLocation + "\\" + _gameSaveFilename;
            try
            {
                DateTime newFile_LastWriteTime = File.GetLastWriteTime(soulFileFullPath);
                DateTime backupFile_LastWriteTime = File.GetLastWriteTime(backupFileFullPath);
                if (newFile_LastWriteTime != backupFile_LastWriteTime)
                {
                    File.Copy(soulFileFullPath, backupFileFullPath, true);
                }
            }
            catch
            {
            }
        }
        #endregion

        #region SaveSoulsForm Methods
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _gameSaveFolderFullPath = string.Empty; //reset the full game's save path
            _selectedComboItem = (ComboboxItem)comboBox1.SelectedItem;

            _selectedGame = _selectedComboItem.Value.ToString();
            _gameSaveFilename = _selectedComboItem.SoulsFileName.ToString();
            if (comboBox1.SelectedIndex == 0)
            {
                _gameFullPath = UserFolderHelper.DocumentsFolder + "\\" + _selectedGame + "\\";
            }
            else
            {
                _gameFullPath = UserFolderHelper.AppDataFolder + "\\" + _selectedGame + "\\";
            }
            DiscoverSaveFolder();
            txtGameSavePath.Text = _gameSaveFolderFullPath + "\\" + _gameSaveFilename;
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                _gameSaveFolderFullPath = openFileDialog.FileName;
                txtGameSavePath.Text = _gameSaveFolderFullPath;
            }
        }

        private void SaveSoulsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _notifyICon.Dispose();
        }

        private void SaveSoulsForm_Resize(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                _notifyICon.Icon = this.Icon;
                _notifyICon.Visible = true;
            }
            else
            {
                _notifyICon.Icon = null;
            }
        }
        #endregion

        #region Notification Icon Methods
        private void SetupNotificationIcon()
        {
            _notifyICon = new NotifyIcon();
            _notifyICon.Icon = this.Icon;
            _notifyICon.Click += NotifyICon__Click;
            _notifyICon.BalloonTipIcon = ToolTipIcon.Info;
            //_notifyICon.BalloonTipClosed += NotifyICon_BalloonTipClosed;
            //_notifyICon.BalloonTipClicked += NotifyICon_BalloonTipClosed;
            _notifyICon.Text = "Save Souls";
        }

        private void ShowBaloonNotification(string bodyText)
        {
            _notifyICon.BalloonTipTitle = _selectedComboItem.Text;
            _notifyICon.BalloonTipText = bodyText;
            _notifyICon.Visible = true;
            //_notifyICon.ShowBalloonTip(5000);
        }

        private void NotifyICon__Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;

            _notifyICon.Visible = false;
            _notifyICon.Icon = null;
        }

        private void NotifyICon_BalloonTipClosed(object sender, EventArgs e)
        {
            _notifyICon.Dispose();
        }
        #endregion

        private class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public string SoulsFileName { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
    }
}