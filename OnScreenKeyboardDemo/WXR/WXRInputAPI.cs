using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace OnScreenKeyboardDemo.WXR
{
    public class WXRInputAPI
    {
        private int udpPortOUT = 7728;
        private int udpPortIN = 7287;
        private string targetIP = "127.0.0.1";

        private UdpClient transmitClient;

        public WXRInputAPI()
        {
            transmitClient = new UdpClient();
        }

        public void Shutdown()
        {
            try
            {
                transmitClient.Close();
            }
            catch (Exception e)
            {

            }
        }

        public void SendData(string data)
        {
            byte[] serverMessageAsByteArray = Encoding.ASCII.GetBytes(data);

            transmitClient.Send(serverMessageAsByteArray, serverMessageAsByteArray.Length, new IPEndPoint(IPAddress.Parse(targetIP), udpPortOUT));
        }
    }
}
