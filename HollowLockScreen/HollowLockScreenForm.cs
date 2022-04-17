using HollowLockScreen.Password;
using InputActivityMonitor;
using SomeSortOfSerializer;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;
using WindowsDevicesOverlord;

namespace HollowLockScreen
{
    public partial class HollowLockScreenForm : Form
    {
        private const string UNLOCK_SECRET_KEY = "IHASTHEROOT";
        private const string REVEAL_WINDOW_SECRET_KEY = "BEGONE";
        private const string LOCK_SECRET_STREAM_KEY = "JUSTLOCKME";
        private USBDevice _usbDevice;
        private NotifyIcon _notifyICon;

        private bool _isLocked;
        private bool _isSettingPassword;
        private bool _isPasswordLoaded;
        private string _keyLog = string.Empty;
        private Keys modifiers = Keys.Control | Keys.Alt;

        private bool _xButton1Clicked;
        private bool _xButton2Clicked;

        private TCPListener _tcpListener;
        private Thread _thread;

        private PasswordObject _loadedPasswordObject;
        private PasswordNode _inputNode;
        private PasswordObject _newPasswordObject;
        private PasswordObject _passwordObjectConfirm;

        private PhotoCaptureLibrary.CameraService _cameraService;

        public HollowLockScreenForm()
        {
            InitializeComponent();
            InitializeUSBDeviceDetection();
            InitializeHooks();
            SetupNotificationIcon();
            InitializeListener();
            InitializeControlsState();
        }

        private void InitializeUSBDeviceDetection()
        {
            _usbDevice = new USBDevice();
        }

        private void InitializeHooks()
        {
            InputActivityMonitor.HookManager.KeyDown += OnKeyDown;
            InputActivityMonitor.HookManager.KeyPress += OnKeyPress;
            InputActivityMonitor.HookManager.MouseClickExt += OnMouseDown;
            InputActivityMonitor.HookManager.MouseUpExt += OnMouseUp;
        }

        private void InitializeListener()
        {            
            _thread = new Thread(new ThreadStart(StartListener));
            _thread.Start();
        }

        private void InitializeControlsState()
        {

        }        

        private void StartListener()
        {
            _tcpListener = new TCPListener(1337);
            _tcpListener.CallBack = CheckStream;
            _tcpListener.StartListener();
        }

        #region Event Handlers
        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            CheckLockSequence(e);
            e.Handled = _isLocked;
            _keyLog += e.KeyCode.ToString();

            ShowForm(_keyLog);

            if (!_isSettingPassword)
            {
                if (_isLocked)
                {
                    _inputNode.Data.NodeType = PasswordNodeTypeEnum.String;
                    _inputNode.Data.PasswordText = _keyLog;
                    CheckSecretKey(_inputNode);
                    if (e.KeyCode == Keys.Q)
                    {
                        _isLocked = false;
                    }
                }

                if (e.KeyCode == Keys.Escape)
                {
                    ResetKeylog();
                }
            }
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void OnMouseDown(object sender, MouseEventExtArgs e)
        {
            e.Handled = _isLocked;

            if (!_isSettingPassword) //check being locked only if we are not setting a password
            {
                if (_isLocked)
                {
                    TakeSnapshot();
                    if (e.Button == MouseButtons.XButton1)
                    {
                        _inputNode.Data.NodeType = PasswordNodeTypeEnum.MouseButton;
                        _inputNode.Data.MouseButtonType = MouseButtonTypeEnum.XInput1;
                        _xButton1Clicked = true;
                    }
                    else if (e.Button == MouseButtons.XButton2)
                    {
                        if (_xButton1Clicked)
                        {
                            _inputNode.Data.NodeType = PasswordNodeTypeEnum.MouseButton;
                            _inputNode.Data.MouseButtonType = MouseButtonTypeEnum.XInput2;
                            _xButton2Clicked = true;
                        }
                    }
                    else if (e.Button == MouseButtons.Left)
                    {
                        _inputNode.Data.NodeType = PasswordNodeTypeEnum.MouseButton;
                        _inputNode.Data.MouseButtonType = MouseButtonTypeEnum.Left;
                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                        _inputNode.Data.NodeType = PasswordNodeTypeEnum.MouseButton;
                        _inputNode.Data.MouseButtonType = MouseButtonTypeEnum.Right;
                    }
                    else if (e.Button == MouseButtons.Middle)
                    {
                        _inputNode.Data.NodeType = PasswordNodeTypeEnum.MouseButton;
                        _inputNode.Data.MouseButtonType = MouseButtonTypeEnum.Middle;
                    }
                    CheckSecretKey(_inputNode);
                }
            }
        }

        private void OnMouseUp(object sender, MouseEventExtArgs e)
        {
            e.Handled = _isLocked;
        }

        private void HollowLockScreenForm_Resize(object sender, EventArgs e)
        {
            HideForm();
        }

        private void HollowLockScreenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _tcpListener.StopListener();
            _thread.Abort();
        }

        /// <summary>
        /// Used for detecting usb devices plugged in
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            _usbDevice.Detect(m);
            if (_usbDevice.IsConnected)
            {
                if (_isLocked)
                {
                    WindowsCommands.Helper.LockWorkStation();
                }
            }

        }

        private void btnSetPassword_Click(object sender, EventArgs e)
        {
            if (_isSettingPassword)
            {
                SetPassword(_newPasswordObject, txtPassword.Text);
                SetPassword(_passwordObjectConfirm, txtConfirmPassword.Text);

                bool arePasswordsSame = _newPasswordObject.Compare(_passwordObjectConfirm);

                if (arePasswordsSame)
                {
                    SavePassword(_newPasswordObject);
                    btnSetPassword.Text = "Set New Password";
                    _isSettingPassword = false;
                    txtPassword.Enabled = false;
                    txtConfirmPassword.Enabled = false;
                    lblHotzone.Enabled = false;
                    lblConfirmHotzone.Enabled = false;
                    btnCancel.Visible = false;
                    errIcon.SetError(txtConfirmPassword, string.Empty);
                }
                else
                {
                    errIcon.SetError(txtConfirmPassword, "Passwords do not match dude");
                }
            }
            else
            {
                txtPassword.Enabled = true;
                txtPassword.Text = string.Empty;
                txtConfirmPassword.Enabled = true;
                txtConfirmPassword.Text = string.Empty;
                lblHotzone.Enabled = true;
                lblConfirmHotzone.Enabled = true;
                btnCancel.Visible = true;
                btnSetPassword.Text = "Apply";
                _isSettingPassword = true;
                _isLocked = false;
                txtPassword.Focus();
                _newPasswordObject = new PasswordObject();
                _passwordObjectConfirm = new PasswordObject();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSetPassword.Text = "Set New Password";
            _isSettingPassword = false;
            txtPassword.Enabled = false;
            txtConfirmPassword.Enabled = false;
            lblHotzone.Enabled = false;
            btnCancel.Visible = false;
            errIcon.SetError(txtConfirmPassword, string.Empty);
        }

        private void lblHotzone_Click(object sender, EventArgs e)
        {
            MouseEventArgs mEvent = (MouseEventArgs)e;
            MouseEventExtArgs mEventExtArgs = new MouseEventExtArgs(mEvent);
            SetPassword(_newPasswordObject, txtPassword.Text);
            CaptureMousePart(_newPasswordObject, mEventExtArgs);
        }
        private void lblConfirmHotzone_Click(object sender, EventArgs e)
        {
            MouseEventArgs mEvent = (MouseEventArgs)e;
            MouseEventExtArgs mEventExtArgs = new MouseEventExtArgs(mEvent);
            SetPassword(_passwordObjectConfirm, txtConfirmPassword.Text);
            CaptureMousePart(_passwordObjectConfirm, mEventExtArgs);
        }

        #endregion

        #region Private methods
        private void SetPassword(PasswordObject passwordObject, string text)
        {
            int previousPasswordLength = passwordObject.TotalPasswordLength(); //calculate the length of the password so far
            if (previousPasswordLength < text.Length) //to record the new part of the password, the new length needs to be bigger
            {
                string newPasswordLog = text.Substring(previousPasswordLength);
                CaptureStringPart(passwordObject, newPasswordLog.ToUpper());
            }
        }

        private void CaptureStringPart(PasswordObject passwordObject, string text)
        {
            var data = new PasswordNodeData();
            data.MouseButtonType = MouseButtonTypeEnum.None;
            data.NodeType = PasswordNodeTypeEnum.String;
            data.PasswordText = text;
            passwordObject.AddNode(data);
        }

        private void CaptureMousePart(PasswordObject passwordObject, MouseEventExtArgs e)
        {
            var data = new PasswordNodeData();
            data.NodeType = PasswordNodeTypeEnum.MouseButton;

            switch (e.Button)
            {
                case MouseButtons.Left:
                    data.MouseButtonType = MouseButtonTypeEnum.Left;
                    break;
                case MouseButtons.Right:
                    data.MouseButtonType = MouseButtonTypeEnum.Right;
                    break;
                case MouseButtons.Middle:
                    data.MouseButtonType = MouseButtonTypeEnum.Middle;
                    break;
                case MouseButtons.XButton1:
                    data.MouseButtonType = MouseButtonTypeEnum.XInput1;
                    break;
                case MouseButtons.XButton2:
                    data.MouseButtonType = MouseButtonTypeEnum.XInput2;
                    break;
                case MouseButtons.None:
                default:
                    data.MouseButtonType = MouseButtonTypeEnum.None;
                    break;
            }
            passwordObject.AddNode(data);
        }

        private void SavePassword(PasswordObject passwordObject)
        {
            SSOS<PasswordObject> ssos = new SSOS<PasswordObject>();
            ssos.Serialize(passwordObject);
        }

        private PasswordObject LoadPasword()
        {
            SSOS<PasswordObject> ssos = new SSOS<PasswordObject>();
            return ssos.Deserialize();
        }


        private void CheckLockSequence(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.L && (Control.ModifierKeys & (modifiers)) == modifiers)
            {
                _inputNode = new PasswordNode();
                ResetKeylog();
                _loadedPasswordObject = LoadPasword();
                if (_loadedPasswordObject != null) //check if the password is loaded
                {
                    _loadedPasswordObject.PrepareForMatching();
                    _isPasswordLoaded = true;
                }

                _cameraService = new PhotoCaptureLibrary.CameraService();                
                _cameraService.StartCaptureDevice();
                _cameraService.SnapshotTakenDelegate += SnapshotTakenEvent;
                _isLocked = true;
            }
        }        

        private void CheckSecretKey(PasswordNode inputNode)
        {
            if (_isPasswordLoaded)
            {
                //PasswordNode inputNode = null;
                //user's password
                //bool isPrimaryCheckOK = _loadedPasswordObject.IsValid(inputNode);
                bool isFallbackCheckOK = _xButton1Clicked && _xButton2Clicked && inputNode.Data.PasswordText == UNLOCK_SECRET_KEY;
                _isLocked = !(/*isPrimaryCheckOK ||*/ isFallbackCheckOK);
            }
            else
            {
                //fallback password
                _isLocked = !(_xButton1Clicked && _xButton2Clicked && inputNode.Data.PasswordText == UNLOCK_SECRET_KEY);
            }

            if (!_isLocked)
            {
                _cameraService.StopCaptureDevice();
            }
        }

        private void CheckStream(string data)
        {
            if (data != null)
            {
                if (data.Contains(LOCK_SECRET_STREAM_KEY))
                {
                    _isLocked = true;
                }
            }
        }

        private void ResetKeylog()
        {
            _keyLog = string.Empty;
            _xButton1Clicked = false;
            _xButton2Clicked = false;

            if (_loadedPasswordObject != null)
            {
                _loadedPasswordObject = LoadPasword(); //reload password to repopulate the linkedlist
                _loadedPasswordObject.PrepareForMatching();
            }
            _inputNode = new PasswordNode();
            _inputNode.Data = new PasswordNodeData();
        }

        private void SetupNotificationIcon()
        {
            _notifyICon = new NotifyIcon();
            _notifyICon.Icon = this.Icon;
            _notifyICon.BalloonTipIcon = ToolTipIcon.Info;
            _notifyICon.Text = "Hollow Lock Screen";
        }

        private void ShowForm()
        {
            Show();
            this.WindowState = FormWindowState.Normal;

            _notifyICon.Visible = false;
            _notifyICon.Icon = null;
        }

        private void ShowForm(string secretKey)
        {
            if (secretKey == REVEAL_WINDOW_SECRET_KEY)
            {
                _keyLog = string.Empty;
                ShowForm();
            }
        }

        private void HideForm()
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                _notifyICon.Visible = false;
            }
            else
            {
                _notifyICon.Icon = null;
            }
        }

        private void TakeSnapshot()
        {
            if (_cameraService != null)
            {
                 _cameraService.TakeSnapshot();
            }
        }

        /// <summary>
        /// Event that is ran after the snapshot is taken. This is the assigned delegate
        /// </summary>
        private void SnapshotTakenEvent()
        {
            SaveSnapshot();
        }

        private void SaveSnapshot()
        {
            Bitmap bmp = _cameraService.Snapshot;
            DateTime now = DateTime.Now;
            string fileName = now.Year.ToString() + now.Month.ToString() + now.Day.ToString() + "-" +
                              now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString() + ".png";

            if (bmp != null)
            {
                bmp.Save(fileName, ImageFormat.Png);
            }
        }

        #endregion
    }
}