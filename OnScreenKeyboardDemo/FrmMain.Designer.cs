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
            this.btnMouseMiddleClick = new System.Windows.Forms.Button();
            this.btnMouseRightClick = new System.Windows.Forms.Button();
            this.btnMouseLeftClick = new System.Windows.Forms.Button();
            this.btnMouseScrollUp = new System.Windows.Forms.Button();
            this.btnMouseScrollDown = new System.Windows.Forms.Button();
            this.pcKeyboard.SuspendLayout();
            this.pcSpecialInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcKeyboard
            // 
            this.pcKeyboard.Controls.Add(this.keyboardControl);
            this.pcKeyboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcKeyboard.Location = new System.Drawing.Point(0, 71);
            this.pcKeyboard.Name = "pcKeyboard";
            this.pcKeyboard.Padding = new System.Windows.Forms.Padding(2);
            this.pcKeyboard.Size = new System.Drawing.Size(784, 350);
            this.pcKeyboard.TabIndex = 4;
            // 
            // keyboardControl
            // 
            this.keyboardControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyboardControl.GutterSize = 0;
            this.keyboardControl.Location = new System.Drawing.Point(2, 2);
            this.keyboardControl.Name = "keyboardControl";
            this.keyboardControl.Size = new System.Drawing.Size(780, 346);
            this.keyboardControl.TabIndex = 3;
            // 
            // pcSpecialInputs
            // 
            this.pcSpecialInputs.Controls.Add(this.btnMouseScrollDown);
            this.pcSpecialInputs.Controls.Add(this.btnMouseScrollUp);
            this.pcSpecialInputs.Controls.Add(this.btnMouseLeftClick);
            this.pcSpecialInputs.Controls.Add(this.btnMouseRightClick);
            this.pcSpecialInputs.Controls.Add(this.btnMouseMiddleClick);
            this.pcSpecialInputs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcSpecialInputs.Location = new System.Drawing.Point(0, 0);
            this.pcSpecialInputs.Name = "pcSpecialInputs";
            this.pcSpecialInputs.Size = new System.Drawing.Size(784, 71);
            this.pcSpecialInputs.TabIndex = 5;
            // 
            // btnMouseMiddleClick
            // 
            this.btnMouseMiddleClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMouseMiddleClick.Image = global::OnScreenKeyboardDemo.Properties.Resources.mouse_middle_click_outline;
            this.btnMouseMiddleClick.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMouseMiddleClick.Location = new System.Drawing.Point(535, 12);
            this.btnMouseMiddleClick.Name = "btnMouseMiddleClick";
            this.btnMouseMiddleClick.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btnMouseMiddleClick.Size = new System.Drawing.Size(75, 53);
            this.btnMouseMiddleClick.TabIndex = 0;
            this.btnMouseMiddleClick.Text = "Middle Click";
            this.btnMouseMiddleClick.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMouseMiddleClick.UseVisualStyleBackColor = true;
            this.btnMouseMiddleClick.Click += new System.EventHandler(this.btnMouseMiddleClick_Click);
            // 
            // btnMouseRightClick
            // 
            this.btnMouseRightClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMouseRightClick.Image = global::OnScreenKeyboardDemo.Properties.Resources.mouse_right_outline;
            this.btnMouseRightClick.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMouseRightClick.Location = new System.Drawing.Point(454, 12);
            this.btnMouseRightClick.Name = "btnMouseRightClick";
            this.btnMouseRightClick.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btnMouseRightClick.Size = new System.Drawing.Size(75, 53);
            this.btnMouseRightClick.TabIndex = 1;
            this.btnMouseRightClick.Text = "Right Click";
            this.btnMouseRightClick.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMouseRightClick.UseVisualStyleBackColor = true;
            this.btnMouseRightClick.Click += new System.EventHandler(this.btnMouseRightClick_Click);
            // 
            // btnMouseLeftClick
            // 
            this.btnMouseLeftClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMouseLeftClick.Image = global::OnScreenKeyboardDemo.Properties.Resources.mouse_left_outline;
            this.btnMouseLeftClick.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMouseLeftClick.Location = new System.Drawing.Point(373, 12);
            this.btnMouseLeftClick.Name = "btnMouseLeftClick";
            this.btnMouseLeftClick.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btnMouseLeftClick.Size = new System.Drawing.Size(75, 53);
            this.btnMouseLeftClick.TabIndex = 2;
            this.btnMouseLeftClick.Text = "Left Click";
            this.btnMouseLeftClick.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMouseLeftClick.UseVisualStyleBackColor = true;
            this.btnMouseLeftClick.Click += new System.EventHandler(this.btnMouseLeftClick_Click);
            // 
            // btnMouseScrollUp
            // 
            this.btnMouseScrollUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMouseScrollUp.Image = global::OnScreenKeyboardDemo.Properties.Resources.mouse_scroll_up_outline;
            this.btnMouseScrollUp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMouseScrollUp.Location = new System.Drawing.Point(616, 12);
            this.btnMouseScrollUp.Name = "btnMouseScrollUp";
            this.btnMouseScrollUp.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btnMouseScrollUp.Size = new System.Drawing.Size(75, 53);
            this.btnMouseScrollUp.TabIndex = 3;
            this.btnMouseScrollUp.Text = "Scroll Up";
            this.btnMouseScrollUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMouseScrollUp.UseVisualStyleBackColor = true;
            this.btnMouseScrollUp.Click += new System.EventHandler(this.btnMouseScrollUp_Click);
            // 
            // btnMouseScrollDown
            // 
            this.btnMouseScrollDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMouseScrollDown.Image = global::OnScreenKeyboardDemo.Properties.Resources.mouse_scroll_down_outline;
            this.btnMouseScrollDown.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMouseScrollDown.Location = new System.Drawing.Point(697, 12);
            this.btnMouseScrollDown.Name = "btnMouseScrollDown";
            this.btnMouseScrollDown.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btnMouseScrollDown.Size = new System.Drawing.Size(75, 53);
            this.btnMouseScrollDown.TabIndex = 4;
            this.btnMouseScrollDown.Text = "Scroll Down";
            this.btnMouseScrollDown.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMouseScrollDown.UseVisualStyleBackColor = true;
            this.btnMouseScrollDown.Click += new System.EventHandler(this.btnMouseScrollDown_Click);
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
    }
}

