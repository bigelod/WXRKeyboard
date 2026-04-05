using System;
using System.Collections.Generic;
using System.Drawing.Printing;
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
        //Optional: Remote debug support, still requires an app running in WinlatorXR that has triggered XrAPI 0.5 or newer
        //When enabled the window switching behavior will be disabled on this instance
        public bool RemoteDebug = false;
        private string debugIP = "127.0.0.1";

        private int udpPortOUT = 7728;
        private int udpPortIN = 7287;
        private string targetIP = "127.0.0.1";

        private UdpClient transmitClient;

        private string dataDirectory = "Z:/tmp/xr";

        public WXRInputAPI()
        {
            if (RemoteDebug)
            {
                targetIP = debugIP;
            }

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

            string versionFile = dataDirectory + "/version";

            if (!File.Exists(versionFile))
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(versionFile))
                    {
                        sw.WriteLine("0.5");
                    }
                }
                catch
                {

                }
            }

            //This may still be used in a future update, so keep it for now
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
                string inputVersionFile = dataDirectory + "/input_version";

                if (File.Exists(inputVersionFile))
                {
                    File.Delete(inputVersionFile);
                }

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
