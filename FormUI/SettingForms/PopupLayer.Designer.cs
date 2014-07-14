namespace FormUI.SettingForms
{
    partial class PopupLayer
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
            this.components = new System.ComponentModel.Container();
            this.btnDone = new System.Windows.Forms.Button();
            this.lbClose = new System.Windows.Forms.Label();
            this.lbPopupContent = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbTime = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(170, 189);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(66, 23);
            this.btnDone.TabIndex = 0;
            this.btnDone.Text = "关闭";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lbClose
            // 
            this.lbClose.AutoSize = true;
            this.lbClose.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbClose.Location = new System.Drawing.Point(398, 5);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(17, 12);
            this.lbClose.TabIndex = 1;
            this.lbClose.Text = "×";
            this.lbClose.Click += new System.EventHandler(this.cbClose_Click);
            // 
            // lbPopupContent
            // 
            this.lbPopupContent.Location = new System.Drawing.Point(39, 83);
            this.lbPopupContent.Name = "lbPopupContent";
            this.lbPopupContent.Size = new System.Drawing.Size(337, 93);
            this.lbPopupContent.TabIndex = 3;
            this.lbPopupContent.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(39, 25);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(41, 12);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "label1";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(39, 54);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(41, 12);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "label1";
            // 
            // PopupLayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 235);
            this.ControlBox = false;
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbPopupContent);
            this.Controls.Add(this.lbClose);
            this.Controls.Add(this.btnDone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PopupLayer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopupLayer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PopupLayer_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PopupLayer_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lbClose;
        private System.Windows.Forms.Label lbPopupContent;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbTitle;
    }
}