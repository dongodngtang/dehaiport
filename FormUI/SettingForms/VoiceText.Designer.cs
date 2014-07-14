namespace FormUI.SettingForms
{
    partial class VoiceText
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
            this.txtVoiceText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPlayTimes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtVoiceText
            // 
            this.txtVoiceText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVoiceText.Location = new System.Drawing.Point(3, 17);
            this.txtVoiceText.MaxLength = 140;
            this.txtVoiceText.Multiline = true;
            this.txtVoiceText.Name = "txtVoiceText";
            this.txtVoiceText.Size = new System.Drawing.Size(491, 103);
            this.txtVoiceText.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVoiceText);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑语音文本";
            // 
            // txtPlayTimes
            // 
            this.txtPlayTimes.Location = new System.Drawing.Point(104, 203);
            this.txtPlayTimes.Name = "txtPlayTimes";
            this.txtPlayTimes.Size = new System.Drawing.Size(66, 21);
            this.txtPlayTimes.TabIndex = 2;
            this.txtPlayTimes.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "播放次数：";
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(245, 184);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 40);
            this.btOk.TabIndex = 4;
            this.btOk.Text = "确定";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // VoiceText
            // 
            this.AcceptButton = this.btOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 262);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlayTimes);
            this.Controls.Add(this.groupBox1);
            this.Name = "VoiceText";
            this.Text = "播放语音文本";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVoiceText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPlayTimes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btOk;
    }
}