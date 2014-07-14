namespace FormUI.SettingForms
{
    partial class VolumeSetting
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
            this.btVolumeSettingOK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbVol = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btVolumeSettingOK
            // 
            this.btVolumeSettingOK.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btVolumeSettingOK.Location = new System.Drawing.Point(131, 147);
            this.btVolumeSettingOK.Margin = new System.Windows.Forms.Padding(5);
            this.btVolumeSettingOK.Name = "btVolumeSettingOK";
            this.btVolumeSettingOK.Size = new System.Drawing.Size(134, 54);
            this.btVolumeSettingOK.TabIndex = 13;
            this.btVolumeSettingOK.Text = "确  定";
            this.btVolumeSettingOK.UseVisualStyleBackColor = true;
            this.btVolumeSettingOK.Click += new System.EventHandler(this.btVolumeSettingOK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(50, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "音 量:";
            // 
            // cbVol
            // 
            this.cbVol.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbVol.FormattingEnabled = true;
            this.cbVol.Location = new System.Drawing.Point(131, 74);
            this.cbVol.Margin = new System.Windows.Forms.Padding(5);
            this.cbVol.Name = "cbVol";
            this.cbVol.Size = new System.Drawing.Size(134, 29);
            this.cbVol.TabIndex = 11;
            // 
            // VolumeSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 296);
            this.Controls.Add(this.btVolumeSettingOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbVol);
            this.Name = "VolumeSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "音量设置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVolumeSettingOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbVol;
    }
}