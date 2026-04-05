using OnScreenKeyboardDemo.WXR;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using WinApi;

namespace OnScreenKeyboardDemo
{
    public partial class FrmMain : Form
    {
        private const int handleCheckTime = 1000;
        private System.Threading.Timer _handleCheck;
        private WXRInputAPI wxrInputAPI;

        private IntPtr myOwnHandle;
        private IntPtr lastFoundHandle;

        public FrmMain()
        {
            InitializeComponent();
            keyboardControl.BuildDefaultDefinition();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            myOwnHandle = IntPtr.Zero;
            lastFoundHandle = IntPtr.Zero;

            //this.TopMost = true; //Doesn't work in Wine

            FormClosing += FrmMain_FormClosing;

            wxrInputAPI = new WXRInputAPI();

            keyboardControl.SetSendKeyAction(SendWXRInput);

            _handleCheck = new System.Threading.Timer(TimerCallback, null, handleCheckTime, handleCheckTime);

            this.Width = Math.Max(Screen.PrimaryScreen.Bounds.Width - 200, 600);
            
            if (this.Width == 600)
            {
                this.Left = 10;
            }
            else
            {
                this.Left = 100;
            }

            this.Top = Math.Max((Screen.PrimaryScreen.Bounds.Height - this.Height) - 40, 10);
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (wxrInputAPI != null)
            {
                wxrInputAPI.Shutdown();
            }
        }

        private void CheckForegroundHandle(IntPtr myOwnHandle)
        {
            IntPtr targetHwnd = WindowsAPI.GetForegroundWindow();
            if (targetHwnd == myOwnHandle || targetHwnd == IntPtr.Zero)
            {
                return;
            }

            lastFoundHandle = targetHwnd;
        }

        public void ReturnToFront()
        {
            if (wxrInputAPI != null && wxrInputAPI.RemoteDebug) return;

            if (myOwnHandle != IntPtr.Zero)
            {
                try
                {
                    Thread.Sleep(350); //Time to ensure the other window got the input

                    WindowsAPI.SetForegroundWindow(myOwnHandle);
                }
                catch
                {

                }
            }            
        }

        public void SwitchToLastWindow()
        {
            if (wxrInputAPI != null && wxrInputAPI.RemoteDebug) return;

            if (lastFoundHandle != IntPtr.Zero)
            {
                try
                {
                    WindowsAPI.SetForegroundWindow(lastFoundHandle);

                    Thread.Sleep(150); //Quick sleep to ensure it gets the input
                }
                catch
                {

                }
            }
        }

        private void TimerCallback(object state)
        {
            if (myOwnHandle == IntPtr.Zero)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    myOwnHandle = this.Handle;
                });
            }

            CheckForegroundHandle(myOwnHandle);
        }

        public void SendWXRInput(string input)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                string sendText = XKeycode.ToKeyCombo(input);
                if (sendText != "K,")
                {
                    wxrInputAPI.SendData(sendText);
                }
                ReturnToFront();
            }
        }


        #region SpecialKeys
        private void pcSpecialInputs_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMouseLeftClick_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("M,TFFFF");
                ReturnToFront();
            }
        }

        private void btnMouseRightClick_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("M,FTFFF");
                ReturnToFront();
            }
        }

        private void btnMouseMiddleClick_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("M,FFTFF");
                ReturnToFront();
            }
        }

        private void btnMouseScrollUp_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("M,FFFTF");
                ReturnToFront();
            }
        }

        private void btnMouseScrollDown_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("M,FFFFT");
                ReturnToFront();
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("K,115");
                ReturnToFront();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("K,110");
                ReturnToFront();
            }
        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("K,118");
                ReturnToFront();
            }
        }

        private void btnF6_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("K,72");
                ReturnToFront();
            }
        }

        private void btnF5_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("K,71");
                ReturnToFront();
            }
        }

        private void btnF4_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("K,70");
            }
        }

        private void btnF3_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("K,69");
                ReturnToFront();
            }
        }

        private void btnF2_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("K,68");
                ReturnToFront();
            }
        }

        private void btnF1_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("K,67");
                ReturnToFront();
            }
        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("K,50");
                ReturnToFront();
            }
        }

        private void btnCTRL_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("K,37");
                ReturnToFront();
            }
        }

        private void btnF12_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("K,96");
                ReturnToFront();
            }
        }

        private void btnF11_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("K,95");
                ReturnToFront();
            }
        }

        private void btnF10_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("K,76");
                ReturnToFront();
            }
        }

        private void btnF9_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("K,75");
                ReturnToFront();
            }
        }

        private void btnF8_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("K,74");
                ReturnToFront();
            }
        }

        private void btnF7_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("K,73");
                ReturnToFront();
            }
        }
        #endregion
    }
}
