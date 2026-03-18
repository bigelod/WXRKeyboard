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
        private const int inputSendTime = 1000;
        private System.Threading.Timer _handleCheck;
        private WXRInputAPI wxrInputAPI;

        private IntPtr myOwnHandle;
        private IntPtr lastFoundHandle;

        private string sendText = "";

        public FrmMain()
        {
            InitializeComponent();
            keyboardControl.BuildDefaultDefinition();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            myOwnHandle = IntPtr.Zero;
            lastFoundHandle = IntPtr.Zero;

            this.TopMost = true;

            FormClosing += FrmMain_FormClosing;

            wxrInputAPI = new WXRInputAPI();

            keyboardControl.SetSendKeyAction(SendWXRInput);

            _handleCheck = new System.Threading.Timer(TimerCallback, null, inputSendTime, inputSendTime);
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

        public void SwitchToLastWindow()
        {
            if (lastFoundHandle != IntPtr.Zero)
            {
                try
                {
                    WindowsAPI.SetForegroundWindow(lastFoundHandle);
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
                //wxrInputAPI.SendData(input);
                sendText += "," + XKeycode.ToKeyCombo(input);
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
                wxrInputAPI.SendData("M,1,0,0,0,0");
            }
        }

        private void btnMouseRightClick_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("M,0,1,0,0,0");
            }
        }

        private void btnMouseMiddleClick_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("M,0,0,1,0,0");
            }
        }

        private void btnMouseScrollUp_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("M,0,0,0,1,0");
            }
        }

        private void btnMouseScrollDown_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("M,0,0,0,0,1");
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("K,115");
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("K,110");
            }
        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("K,118");
            }
        }

        private void btnF6_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("K,72");
            }
        }

        private void btnF5_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("K,71");
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
            }
        }

        private void btnF2_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("K,68");
            }
        }

        private void btnF1_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("K,67");
            }
        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("K,50");
            }
        }

        private void btnCTRL_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("K,37");
            }
        }

        private void btnF12_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("K,96");
            }
        }

        private void btnF11_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("K,95");
            }
        }

        private void btnF10_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("K,76");
            }
        }

        private void btnF9_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("K,75");
            }
        }

        private void btnF8_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("K,74");
            }
        }

        private void btnF7_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                SwitchToLastWindow();
                wxrInputAPI.SendData("K,73");
            }
        }
        #endregion
    }
}
