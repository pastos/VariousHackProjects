using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPClientTest
{
    namespace Client
    {
        class Program
        {
            const int PORT_NO = 13000;
            const string SERVER_IP = "192.168.0.8";
            static void Main(string[] args)
            {
                //---data to send to the server---
                string textToSend = DateTime.Now.ToString();

                //---create a TCPClient object at the IP and port no.---
                TcpClient client = new TcpClient();
                client.SendTimeout = 3;
                client.ReceiveTimeout = 1;
                client.Connect(SERVER_IP, PORT_NO);

                byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);

                NetworkStream nwStream = client.GetStream();
                

                //---send the text---
                Console.WriteLine("Sending : " + textToSend);
                nwStream.Write(bytesToSend, 0, bytesToSend.Length);

                //---read back the text---
                byte[] bytesToRead = new byte[client.ReceiveBufferSize];
                int bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);
                Console.WriteLine("Received : " + Encoding.ASCII.GetString(bytesToRead, 0, bytesRead));
                Console.ReadLine();
                nwStream.Close();
                client.Close();

            }
        }
    }
}
