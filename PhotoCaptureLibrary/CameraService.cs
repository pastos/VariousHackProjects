using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;

namespace PhotoCaptureLibrary
{
    public class CameraService
    {
        private FilterInfoCollection _filterInfoCollection;
        private VideoCaptureDevice _captureDevice;
        private const long BYTES_THRESHOLD = 1024 * 1024 * 10; // 10MB
        private const long FRAMES_THRESHOLD = 50;

        public Bitmap Snapshot { get; private set; }

        public Action SnapshotTakenDelegate;

        public CameraService()
        {
            _filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        }

        public void StartCaptureDevice()
        {
            _captureDevice = new VideoCaptureDevice(_filterInfoCollection[0].MonikerString);// specified web cam and its filter moniker string
            _captureDevice.NewFrame += NewFrameEvent;

            _captureDevice.Start();
            
        }

        private void PlayingFinished(object sender, ReasonToFinishPlaying reason)
        {

            throw new System.NotImplementedException();
        }

        public void StopCaptureDevice()
        {
            if (_captureDevice.IsRunning)
            {
                _captureDevice.SignalToStop();
                _captureDevice.WaitForStop();
                _captureDevice = null;
            }
        }

        private bool _isSnapshot;
        public void TakeSnapshot()
        {
            _isSnapshot = true;
        }

        private void NewFrameEvent(object sender, NewFrameEventArgs eventArgs)
        {
            if (_isSnapshot)
            {
                Snapshot = (Bitmap)eventArgs.Frame.Clone();
                eventArgs.Frame.Dispose();

                if(SnapshotTakenDelegate != null)
                {
                    SnapshotTakenDelegate();
                }

                _isSnapshot = false;
            }
        }
    }
}