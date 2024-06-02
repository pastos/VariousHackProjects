using System;
using System.Windows.Forms;
using System.IO;
using KeyboardHooksLibrary;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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
            ScanForLatestSave();
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
                rTxtLog.AppendText("Can't find the save folder. Please try selecting it manually." + Environment.NewLine);
            }
        }

        private void ScanForLatestSave()
        {
            SortedList<DateTime, string> sortedList = new SortedList<DateTime, string>();
            if (Directory.Exists(QuickSaveFolder1))
            {
                string[] files1 = Directory.GetFiles(QuickSaveFolder1, "*.sl2");
                DateTime latestWriteUtc1 = GetWriteTimeUtcOfSaveFolder(files1);
                sortedList.Add(latestWriteUtc1, QuickSaveFolder1);
            }

            if (Directory.Exists(QuickSaveFolder2))
            {
                string[] files2 = Directory.GetFiles(QuickSaveFolder2, "*.sl2");
                DateTime latestWriteUtc2 = GetWriteTimeUtcOfSaveFolder(files2);
                sortedList.Add(latestWriteUtc2, QuickSaveFolder2);
            }

            if (Directory.Exists(QuickSaveFolder3))
            {
                string[] files3 = Directory.GetFiles(QuickSaveFolder3, "*.sl2");
                DateTime latestWriteUtc3 = GetWriteTimeUtcOfSaveFolder(files3);
                sortedList.Add(latestWriteUtc3, QuickSaveFolder3);
            }

            if (Directory.Exists(QuickSaveFolder4))
            {
                string[] files4 = Directory.GetFiles(QuickSaveFolder4, "*.sl2");
                DateTime latestWriteUtc4 = GetWriteTimeUtcOfSaveFolder(files4);
                sortedList.Add(latestWriteUtc4, QuickSaveFolder4);
            }

            string matchFolderName = @"(\w*)\\$";
            Regex regEx = new Regex(matchFolderName);
            if (sortedList.Count > 0)
            {
                string quickSaveName = regEx.Match(sortedList.Last().Value).Groups[1].Value; //group inside parenthesis of regex
                quickSaveName = quickSaveName.Replace("Folder", string.Empty);
                lbl_LatestSave.Text = quickSaveName;
            }
            else
            {
                lbl_LatestSave.Text = "There is no save point";
            }

        }

        private DateTime GetWriteTimeUtcOfSaveFolder(string[] files)
        {
            DateTime latestWriteUtc = DateTime.MinValue;
            foreach (var file in files)
            {
                DateTime writeUtc = File.GetLastAccessTimeUtc(file);
                if (latestWriteUtc < writeUtc)
                {
                    latestWriteUtc = writeUtc;
                }
            }
            return latestWriteUtc;
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

            if (e.KeyboardState == GlobalKeyboardHook.KeyboardState.KeyDown)
            {
                string keyPressed = GlobalKeyboardHook.KeyPressed(e.KeyboardData.VirtualCode);
                if (!string.IsNullOrEmpty(keyPressed))
                {
                    if (keyPressed == "F1")
                    {
                        e.Handled = true;
                        QuickSave(QuickSaveFolder1, 1);
                    }
                    else if (keyPressed == "F2")
                    {
                        e.Handled = true;
                        QuickSave(QuickSaveFolder2, 2);
                    }
                    else if (keyPressed == "F3")
                    {
                        e.Handled = true;
                        QuickSave(QuickSaveFolder3, 3);
                    }
                    else if (keyPressed == "F4")
                    {
                        e.Handled = true;
                        QuickSave(QuickSaveFolder4, 4);
                    }
                    else if (keyPressed == "F5")
                    {
                        e.Handled = true;
                        QuickLoad(QuickSaveFolder1, 1);
                    }
                    else if ((keyPressed == "F6"))
                    {
                        e.Handled = true;
                        QuickLoad(QuickSaveFolder2, 2);
                    }
                    else if (keyPressed == "F7")
                    {
                        e.Handled = true;
                        QuickLoad(QuickSaveFolder3, 3);
                    }
                    else if (keyPressed == "F8")
                    {
                        e.Handled = true;
                        QuickLoad(QuickSaveFolder4, 4);
                    }
                    else
                    {
                        e.Handled = false;
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
                string body = string.Format("Game Saved (QuickSave {0}) - {1}", quickSaveNumber, DateTime.Now.ToString());
                rTxtLog.SelectionColor = PickRandomColor();
                rTxtLog.SelectionBackColor = InverseColor(rTxtLog.SelectionColor);
                rTxtLog.AppendText(body + Environment.NewLine);
                rTxtLog.ScrollToCaret();
                lbl_LatestSave.Text = string.Format("QuickSave {0}", quickSaveNumber);
                //ShowBaloonNotification(body);
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
                    string body = string.Format("Game Loaded (QuickLoad {0}) - {1}", quickLoadNumber, DateTime.Now.ToString());
                    rTxtLog.SelectionColor = PickRandomColor();
                    rTxtLog.SelectionBackColor = InverseColor(rTxtLog.SelectionColor);
                    rTxtLog.AppendText(body + Environment.NewLine);
                    rTxtLog.ScrollToCaret();
                    //ShowBaloonNotification(body);
                }
                catch (Exception ex)
                {
                    rTxtLog.SelectionColor = System.Drawing.Color.Red;
                    rTxtLog.AppendText(ex.Message + Environment.NewLine);
                }
            }
        }

        private Color PickRandomColor()
        {
            Random rnd = new Random(System.Environment.TickCount);
            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);
            return Color.FromArgb(r, g, b);
        }

        private Color InverseColor(Color color)
        {
            int inverseR = 255 - color.R;
            int inverseG = 255 - color.G;
            int inverseB = 255 - color.B;
            return Color.FromArgb(inverseR, inverseG, inverseB);
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
            _notifyICon.ShowBalloonTip(5000);
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