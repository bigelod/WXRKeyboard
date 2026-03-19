using System;
using System.Collections.Generic;
using System.IO;
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

        private string dataDirectory = "Z:/tmp/xr";

        public WXRInputAPI()
        {
            transmitClient = new UdpClient();

            if (dataDirectory == "Z:/tmp/xr" && !Directory.Exists(dataDirectory))
            {
                if (Directory.Exists("Z:/"))
                {
                    //Try to create the temp directory if it doesn't exist
                    if (!Directory.Exists("Z:/tmp"))
                    {
                        Directory.CreateDirectory("Z:/tmp");
                    }
                }
                else
                {
                    //Fallback to a temp directory on whatever drive we are running on instead
                    dataDirectory = Path.GetFullPath("./").Substring(0, 1) + ":/xrtemp";
                }
            }

            if (!Directory.Exists(dataDirectory)) Directory.CreateDirectory(dataDirectory);

            if (!Directory.Exists(dataDirectory))
            {
                return;
            }

            string inputVersionFile = dataDirectory + "/input_version";

            if (!File.Exists(inputVersionFile))
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(inputVersionFile))
                    {
                        sw.WriteLine("0.1");
                    }
                }
                catch
                {

                }
            }
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
