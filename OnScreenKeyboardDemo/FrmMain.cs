using OnScreenKeyboardDemo.WXR;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OnScreenKeyboardDemo
{
    public partial class FrmMain : Form
    {
        private WXRInputAPI wxrInputAPI;

        private string sendText = "";

        public FrmMain()
        {
            InitializeComponent();
            keyboardControl.BuildDefaultDefinition();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FormClosing += FrmMain_FormClosing;

            wxrInputAPI = new WXRInputAPI();

            keyboardControl.SetSendKeyAction(SendWXRInput);
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (wxrInputAPI != null)
            {
                wxrInputAPI.Shutdown();
            }
        }

        public void SendWXRInput(string input)
        {
            if (wxrInputAPI != null)
            {
                //wxrInputAPI.SendData(input);
                sendText += "," + input;
            }
        }

        private void btnMouseLeftClick_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                wxrInputAPI.SendData("M,1,0,0,0,0");
            }
        }

        private void btnMouseRightClick_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                wxrInputAPI.SendData("M,0,1,0,0,0");
            }
        }

        private void btnMouseMiddleClick_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                wxrInputAPI.SendData("M,0,0,1,0,0");
            }
        }

        private void btnMouseScrollUp_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                wxrInputAPI.SendData("M,0,0,0,1,0");
            }
        }

        private void btnMouseScrollDown_Click(object sender, EventArgs e)
        {
            if (wxrInputAPI != null)
            {
                wxrInputAPI.SendData("M,0,0,0,0,1");
            }
        }

        //private void lblClickMe_Click(object sender, EventArgs e)
        //{
        //    OnScreenKeyboard.Keyboard.ShowDialog("Keyboard Caption",
        //                                         new Point(DesktopLocation.X , DesktopLocation.Y + Height),
        //                                         new Size(900,290));

        //}
    }
}
