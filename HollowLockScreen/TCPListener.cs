using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;


namespace HollowLockScreen
{
    public class TCPListener
    {
        private int _port;
        private TcpListener _listener;
        private TcpClient _tcpClient;
        private NetworkStream _stream;
        private bool _isStopped;

        public delegate void CallBackHandler(string data);
        public CallBackHandler CallBack;

        public bool IsConnected
        {
            get
            {
                return _tcpClient.Connected;
            }
        }

        public TCPListener(int port)
        {
            _port = port;
            _tcpClient = new TcpClient();


        }

        public void StartListener()
        {
            try
            {
                Start();
                while (!_isStopped)
                {
                    ListenForNetworkStream();
                    string data = ReadByte(_stream);
                    if (!string.IsNullOrWhiteSpace(data))
                    {
                        if (CallBack != null)
                        {
                            CallBack(data);
                        }
                    }
                }
            }
            catch (SocketException ex)
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {
                //if it wasn't stopped normally then start it again
                if (!_isStopped)
                {
                    StartListener();
                }
            }
        }

        public void StopListener()
        {
            _isStopped = true;            
            _tcpClient.Close();
            _listener.Stop();
        }

        private void Start()
        {
            _listener = new TcpListener(IPAddress.Any, _port);
            _listener.Start();
            _isStopped = false;
        }

        

        private void ListenForNetworkStream()
        {
            _tcpClient = _listener.AcceptTcpClient();
            _stream = _tcpClient.GetStream();
        }

        private string ReadByte(NetworkStream stream)
        {
            byte[] byteStream = new byte[256];
            string data = string.Empty;
            int readCount = 0;

            while (readCount < byteStream.Length)
            {
                int remainingBytes = byteStream.Length - readCount;
                int i = stream.Read(byteStream, 0, remainingBytes);
                data += System.Text.Encoding.ASCII.GetString(byteStream, 0, i);

                if (i == 0)
                {
                    throw new Exception("Lost Connection during read");
                }

                readCount += i;
            }

            return data;
        }

    }
}
