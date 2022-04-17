using System.Windows.Forms;

namespace WindowsDevicesOverlord
{
    public class USBDevice
    {
        private const int WM_DEVICECHANGE = 0x219;
        private const int DBT_DEVICEARRIVAL = 0x8000;
        private const int DBT_DEVICEREMOVECOMPLETE = 0x8004;
        private const int DBT_DEVTYP_VOLUME = 0x00000002;

        public bool IsConnected { get; private set; }
        public void Detect(Message m)
        {
            switch (m.Msg)
            {
                case WM_DEVICECHANGE:
                    switch ((int)m.WParam)
                    {
                        case DBT_DEVICEARRIVAL:
                            IsConnected = true;
                            break;
                        case DBT_DEVICEREMOVECOMPLETE:
                            IsConnected = false;
                            break;
                    }
                    break;
            }
        }
    }
}
