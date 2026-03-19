namespace OnScreenKeyboardDemo
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pcKeyboard = new System.Windows.Forms.Panel();
            this.keyboardControl = new OnScreenKeyboard.Keyboard();
            this.pcSpecialInputs = new System.Windows.Forms.Panel();
            this.btnMouseScrollDown = new System.Windows.Forms.Button();
            this.btnMouseScrollUp = new System.Windows.Forms.Button();
            this.btnMouseLeftClick = new System.Windows.Forms.Button();
            this.btnMouseRightClick = new System.Windows.Forms.Button();
            this.btnMouseMiddleClick = new System.Windows.Forms.Button();
            this.btnCTRL = new System.Windows.Forms.Button();
            this.btnShift = new System.Windows.Forms.Button();
            this.btnF1 = new System.Windows.Forms.Button();
            this.btnF2 = new System.Windows.Forms.Button();
            this.btnF3 = new System.Windows.Forms.Button();
            this.btnF4 = new System.Windows.Forms.Button();
            this.btnF5 = new System.Windows.Forms.Button();
            this.btnF6 = new System.Windows.Forms.Button();
            this.btnF7 = new System.Windows.Forms.Button();
            this.btnF8 = new System.Windows.Forms.Button();
            this.btnF9 = new System.Windows.Forms.Button();
            this.btnF10 = new System.Windows.Forms.Button();
            this.btnF11 = new System.Windows.Forms.Button();
            this.btnF12 = new System.Windows.Forms.Button();
            this.btnIns = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.pcKeyboard.SuspendLayout();
            this.pcSpecialInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcKeyboard
            // 
            this.pcKeyboard.Controls.Add(this.keyboardControl);
            this.pcKeyboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcKeyboard.Location = new System.Drawing.Point(0, 144);
            this.pcKeyboard.Name = "pcKeyboard";
            this.pcKeyboard.Padding = new System.Windows.Forms.Padding(2);
            this.pcKeyboard.Size = new System.Drawing.Size(784, 277);
            this.pcKeyboard.TabIndex = 4;
            // 
            // keyboardControl
            // 
            this.keyboardControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyboardControl.GutterSize = 0;
            this.keyboardControl.Location = new System.Drawing.Point(2, 2);
            this.keyboardControl.Name = "keyboardControl";
            this.keyboardControl.Size = new System.Drawing.Size(780, 273);
            this.keyboardControl.TabIndex = 3;
            // 
            // pcSpecialInputs
            // 
            this.pcSpecialInputs.Controls.Add(this.btnEnd);
            this.pcSpecialInputs.Controls.Add(this.btnHome);
            this.pcSpecialInputs.Controls.Add(this.btnIns);
            this.pcSpecialInputs.Controls.Add(this.btnF12);
            this.pcSpecialInputs.Controls.Add(this.btnF11);
            this.pcSpecialInputs.Controls.Add(this.btnF10);
            this.pcSpecialInputs.Controls.Add(this.btnF9);
            this.pcSpecialInputs.Controls.Add(this.btnF8);
            this.pcSpecialInputs.Controls.Add(this.btnF7);
            this.pcSpecialInputs.Controls.Add(this.btnF6);
            this.pcSpecialInputs.Controls.Add(this.btnF5);
            this.pcSpecialInputs.Controls.Add(this.btnF4);
            this.pcSpecialInputs.Controls.Add(this.btnF3);
            this.pcSpecialInputs.Controls.Add(this.btnF2);
            this.pcSpecialInputs.Controls.Add(this.btnF1);
            this.pcSpecialInputs.Controls.Add(this.btnShift);
            this.pcSpecialInputs.Controls.Add(this.btnCTRL);
            this.pcSpecialInputs.Controls.Add(this.btnMouseScrollDown);
            this.pcSpecialInputs.Controls.Add(this.btnMouseScrollUp);
            this.pcSpecialInputs.Controls.Add(this.btnMouseLeftClick);
            this.pcSpecialInputs.Controls.Add(this.btnMouseRightClick);
            this.pcSpecialInputs.Controls.Add(this.btnMouseMiddleClick);
            this.pcSpecialInputs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcSpecialInputs.Location = new System.Drawing.Point(0, 0);
            this.pcSpecialInputs.Name = "pcSpecialInputs";
            this.pcSpecialInputs.Size = new System.Drawing.Size(784, 144);
            this.pcSpecialInputs.TabIndex = 5;
            this.pcSpecialInputs.Paint += new System.Windows.Forms.PaintEventHandler(this.pcSpecialInputs_Paint);
            // 
            // btnMouseScrollDown
            // 
            this.btnMouseScrollDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMouseScrollDown.Image = global::OnScreenKeyboardDemo.Properties.Resources.mouse_scroll_down_outline;
            this.btnMouseScrollDown.Location = new System.Drawing.Point(697, 12);
            this.btnMouseScrollDown.Name = "btnMouseScrollDown";
            this.btnMouseScrollDown.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btnMouseScrollDown.Size = new System.Drawing.Size(75, 61);
            this.btnMouseScrollDown.TabIndex = 4;
            this.btnMouseScrollDown.Text = "Scroll Down";
            this.btnMouseScrollDown.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMouseScrollDown.UseVisualStyleBackColor = true;
            this.btnMouseScrollDown.Click += new System.EventHandler(this.btnMouseScrollDown_Click);
            // 
            // btnMouseScrollUp
            // 
            this.btnMouseScrollUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMouseScrollUp.Image = global::OnScreenKeyboardDemo.Properties.Resources.mouse_scroll_up_outline;
            this.btnMouseScrollUp.Location = new System.Drawing.Point(616, 12);
            this.btnMouseScrollUp.Name = "btnMouseScrollUp";
            this.btnMouseScrollUp.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btnMouseScrollUp.Size = new System.Drawing.Size(75, 61);
            this.btnMouseScrollUp.TabIndex = 3;
            this.btnMouseScrollUp.Text = "Scroll Up";
            this.btnMouseScrollUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMouseScrollUp.UseVisualStyleBackColor = true;
            this.btnMouseScrollUp.Click += new System.EventHandler(this.btnMouseScrollUp_Click);
            // 
            // btnMouseLeftClick
            // 
            this.btnMouseLeftClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMouseLeftClick.Image = global::OnScreenKeyboardDemo.Properties.Resources.mouse_left_outline;
            this.btnMouseLeftClick.Location = new System.Drawing.Point(373, 12);
            this.btnMouseLeftClick.Name = "btnMouseLeftClick";
            this.btnMouseLeftClick.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btnMouseLeftClick.Size = new System.Drawing.Size(75, 61);
            this.btnMouseLeftClick.TabIndex = 0;
            this.btnMouseLeftClick.Text = "Left Click";
            this.btnMouseLeftClick.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMouseLeftClick.UseVisualStyleBackColor = true;
            this.btnMouseLeftClick.Click += new System.EventHandler(this.btnMouseLeftClick_Click);
            // 
            // btnMouseRightClick
            // 
            this.btnMouseRightClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMouseRightClick.Image = global::OnScreenKeyboardDemo.Properties.Resources.mouse_right_outline;
            this.btnMouseRightClick.Location = new System.Drawing.Point(454, 12);
            this.btnMouseRightClick.Name = "btnMouseRightClick";
            this.btnMouseRightClick.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btnMouseRightClick.Size = new System.Drawing.Size(75, 61);
            this.btnMouseRightClick.TabIndex = 1;
            this.btnMouseRightClick.Text = "Right Click";
            this.btnMouseRightClick.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMouseRightClick.UseVisualStyleBackColor = true;
            this.btnMouseRightClick.Click += new System.EventHandler(this.btnMouseRightClick_Click);
            // 
            // btnMouseMiddleClick
            // 
            this.btnMouseMiddleClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMouseMiddleClick.Image = global::OnScreenKeyboardDemo.Properties.Resources.mouse_middle_click_outline;
            this.btnMouseMiddleClick.Location = new System.Drawing.Point(535, 12);
            this.btnMouseMiddleClick.Name = "btnMouseMiddleClick";
            this.btnMouseMiddleClick.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btnMouseMiddleClick.Size = new System.Drawing.Size(75, 61);
            this.btnMouseMiddleClick.TabIndex = 0;
            this.btnMouseMiddleClick.Text = "Middle Click";
            this.btnMouseMiddleClick.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMouseMiddleClick.UseVisualStyleBackColor = true;
            this.btnMouseMiddleClick.Click += new System.EventHandler(this.btnMouseMiddleClick_Click);
            // 
            // btnCTRL
            // 
            this.btnCTRL.Image = global::OnScreenKeyboardDemo.Properties.Resources.keyboard_ctrl_outline;
            this.btnCTRL.Location = new System.Drawing.Point(12, 12);
            this.btnCTRL.Name = "btnCTRL";
            this.btnCTRL.Size = new System.Drawing.Size(58, 61);
            this.btnCTRL.TabIndex = 5;
            this.btnCTRL.UseVisualStyleBackColor = true;
            this.btnCTRL.Click += new System.EventHandler(this.btnCTRL_Click);
            // 
            // btnShift
            // 
            this.btnShift.Image = global::OnScreenKeyboardDemo.Properties.Resources.keyboard_shift_icon_outline;
            this.btnShift.Location = new System.Drawing.Point(76, 12);
            this.btnShift.Name = "btnShift";
            this.btnShift.Size = new System.Drawing.Size(58, 61);
            this.btnShift.TabIndex = 6;
            this.btnShift.UseVisualStyleBackColor = true;
            this.btnShift.Click += new System.EventHandler(this.btnShift_Click);
            // 
            // btnF1
            // 
            this.btnF1.Image = global::OnScreenKeyboardDemo.Properties.Resources.keyboard_f1_outline;
            this.btnF1.Location = new System.Drawing.Point(12, 79);
            this.btnF1.Name = "btnF1";
            this.btnF1.Size = new System.Drawing.Size(58, 60);
            this.btnF1.TabIndex = 7;
            this.btnF1.UseVisualStyleBackColor = true;
            this.btnF1.Click += new System.EventHandler(this.btnF1_Click);
            // 
            // btnF2
            // 
            this.btnF2.Image = global::OnScreenKeyboardDemo.Properties.Resources.keyboard_f2_outline;
            this.btnF2.Location = new System.Drawing.Point(76, 79);
            this.btnF2.Name = "btnF2";
            this.btnF2.Size = new System.Drawing.Size(58, 60);
            this.btnF2.TabIndex = 8;
            this.btnF2.UseVisualStyleBackColor = true;
            this.btnF2.Click += new System.EventHandler(this.btnF2_Click);
            // 
            // btnF3
            // 
            this.btnF3.Image = global::OnScreenKeyboardDemo.Properties.Resources.keyboard_f3_outline;
            this.btnF3.Location = new System.Drawing.Point(140, 79);
            this.btnF3.Name = "btnF3";
            this.btnF3.Size = new System.Drawing.Size(58, 60);
            this.btnF3.TabIndex = 9;
            this.btnF3.UseVisualStyleBackColor = true;
            this.btnF3.Click += new System.EventHandler(this.btnF3_Click);
            // 
            // btnF4
            // 
            this.btnF4.Image = global::OnScreenKeyboardDemo.Properties.Resources.keyboard_f4_outline;
            this.btnF4.Location = new System.Drawing.Point(204, 79);
            this.btnF4.Name = "btnF4";
            this.btnF4.Size = new System.Drawing.Size(58, 60);
            this.btnF4.TabIndex = 10;
            this.btnF4.UseVisualStyleBackColor = true;
            this.btnF4.Click += new System.EventHandler(this.btnF4_Click);
            // 
            // btnF5
            // 
            this.btnF5.Image = global::OnScreenKeyboardDemo.Properties.Resources.keyboard_f5_outline;
            this.btnF5.Location = new System.Drawing.Point(268, 79);
            this.btnF5.Name = "btnF5";
            this.btnF5.Size = new System.Drawing.Size(58, 60);
            this.btnF5.TabIndex = 11;
            this.btnF5.UseVisualStyleBackColor = true;
            this.btnF5.Click += new System.EventHandler(this.btnF5_Click);
            // 
            // btnF6
            // 
            this.btnF6.Image = global::OnScreenKeyboardDemo.Properties.Resources.keyboard_f6_outline;
            this.btnF6.Location = new System.Drawing.Point(332, 79);
            this.btnF6.Name = "btnF6";
            this.btnF6.Size = new System.Drawing.Size(58, 60);
            this.btnF6.TabIndex = 12;
            this.btnF6.UseVisualStyleBackColor = true;
            this.btnF6.Click += new System.EventHandler(this.btnF6_Click);
            // 
            // btnF7
            // 
            this.btnF7.Image = global::OnScreenKeyboardDemo.Properties.Resources.keyboard_f7_outline;
            this.btnF7.Location = new System.Drawing.Point(396, 79);
            this.btnF7.Name = "btnF7";
            this.btnF7.Size = new System.Drawing.Size(58, 60);
            this.btnF7.TabIndex = 13;
            this.btnF7.UseVisualStyleBackColor = true;
            this.btnF7.Click += new System.EventHandler(this.btnF7_Click);
            // 
            // btnF8
            // 
            this.btnF8.Image = global::OnScreenKeyboardDemo.Properties.Resources.keyboard_f8_outline;
            this.btnF8.Location = new System.Drawing.Point(460, 79);
            this.btnF8.Name = "btnF8";
            this.btnF8.Size = new System.Drawing.Size(58, 60);
            this.btnF8.TabIndex = 14;
            this.btnF8.UseVisualStyleBackColor = true;
            this.btnF8.Click += new System.EventHandler(this.btnF8_Click);
            // 
            // btnF9
            // 
            this.btnF9.Image = global::OnScreenKeyboardDemo.Properties.Resources.keyboard_f9_outline;
            this.btnF9.Location = new System.Drawing.Point(524, 79);
            this.btnF9.Name = "btnF9";
            this.btnF9.Size = new System.Drawing.Size(58, 60);
            this.btnF9.TabIndex = 15;
            this.btnF9.UseVisualStyleBackColor = true;
            this.btnF9.Click += new System.EventHandler(this.btnF9_Click);
            // 
            // btnF10
            // 
            this.btnF10.Image = global::OnScreenKeyboardDemo.Properties.Resources.keyboard_f10_outline;
            this.btnF10.Location = new System.Drawing.Point(588, 79);
            this.btnF10.Name = "btnF10";
            this.btnF10.Size = new System.Drawing.Size(58, 60);
            this.btnF10.TabIndex = 16;
            this.btnF10.UseVisualStyleBackColor = true;
            this.btnF10.Click += new System.EventHandler(this.btnF10_Click);
            // 
            // btnF11
            // 
            this.btnF11.Image = global::OnScreenKeyboardDemo.Properties.Resources.keyboard_f11_outline;
            this.btnF11.Location = new System.Drawing.Point(652, 79);
            this.btnF11.Name = "btnF11";
            this.btnF11.Size = new System.Drawing.Size(58, 60);
            this.btnF11.TabIndex = 17;
            this.btnF11.UseVisualStyleBackColor = true;
            this.btnF11.Click += new System.EventHandler(this.btnF11_Click);
            // 
            // btnF12
            // 
            this.btnF12.Image = global::OnScreenKeyboardDemo.Properties.Resources.keyboard_f12_outline;
            this.btnF12.Location = new System.Drawing.Point(714, 79);
            this.btnF12.Name = "btnF12";
            this.btnF12.Size = new System.Drawing.Size(58, 60);
            this.btnF12.TabIndex = 18;
            this.btnF12.UseVisualStyleBackColor = true;
            this.btnF12.Click += new System.EventHandler(this.btnF12_Click);
            // 
            // btnIns
            // 
            this.btnIns.Image = global::OnScreenKeyboardDemo.Properties.Resources.keyboard_insert_outline;
            this.btnIns.Location = new System.Drawing.Point(140, 12);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(58, 61);
            this.btnIns.TabIndex = 19;
            this.btnIns.UseVisualStyleBackColor = true;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = global::OnScreenKeyboardDemo.Properties.Resources.keyboard_home_outline;
            this.btnHome.Location = new System.Drawing.Point(204, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(58, 61);
            this.btnHome.TabIndex = 20;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Image = global::OnScreenKeyboardDemo.Properties.Resources.keyboard_end_outline;
            this.btnEnd.Location = new System.Drawing.Point(268, 12);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(58, 61);
            this.btnEnd.TabIndex = 21;
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 421);
            this.Controls.Add(this.pcKeyboard);
            this.Controls.Add(this.pcSpecialInputs);
            this.MinimumSize = new System.Drawing.Size(745, 458);
            this.Name = "FrmMain";
            this.Text = "WinlatorXR - On Screen Keyboard";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pcKeyboard.ResumeLayout(false);
            this.pcSpecialInputs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private OnScreenKeyboard.Keyboard keyboardControl;
        private System.Windows.Forms.Panel pcKeyboard;
        private System.Windows.Forms.Panel pcSpecialInputs;
        private System.Windows.Forms.Button btnMouseMiddleClick;
        private System.Windows.Forms.Button btnMouseScrollDown;
        private System.Windows.Forms.Button btnMouseScrollUp;
        private System.Windows.Forms.Button btnMouseLeftClick;
        private System.Windows.Forms.Button btnMouseRightClick;
        private System.Windows.Forms.Button btnShift;
        private System.Windows.Forms.Button btnCTRL;
        private System.Windows.Forms.Button btnF12;
        private System.Windows.Forms.Button btnF11;
        private System.Windows.Forms.Button btnF10;
        private System.Windows.Forms.Button btnF9;
        private System.Windows.Forms.Button btnF8;
        private System.Windows.Forms.Button btnF7;
        private System.Windows.Forms.Button btnF6;
        private System.Windows.Forms.Button btnF5;
        private System.Windows.Forms.Button btnF4;
        private System.Windows.Forms.Button btnF3;
        private System.Windows.Forms.Button btnF2;
        private System.Windows.Forms.Button btnF1;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnIns;
    }
}

