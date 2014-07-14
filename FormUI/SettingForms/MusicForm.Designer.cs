namespace FormUI.SettingForms
{
    partial class MusicForm
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
            this.label11 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMusicList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPlayStyle = new System.Windows.Forms.ComboBox();
            this.btLinkOne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(228, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 14);
            this.label11.TabIndex = 16;
            this.label11.Text = "分钟";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(140, 76);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(79, 21);
            this.txtTime.TabIndex = 15;
            this.txtTime.Text = "3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(30, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 14);
            this.label9.TabIndex = 14;
            this.label9.Text = "播放时间设置：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(30, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 14);
            this.label6.TabIndex = 13;
            this.label6.Text = "语音段选择：";
            // 
            // cbMusicList
            // 
            this.cbMusicList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMusicList.FormattingEnabled = true;
            this.cbMusicList.Location = new System.Drawing.Point(140, 36);
            this.cbMusicList.Name = "cbMusicList";
            this.cbMusicList.Size = new System.Drawing.Size(123, 20);
            this.cbMusicList.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(30, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "播 放 方 式：";
            // 
            // cbPlayStyle
            // 
            this.cbPlayStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlayStyle.FormattingEnabled = true;
            this.cbPlayStyle.Location = new System.Drawing.Point(140, 116);
            this.cbPlayStyle.Name = "cbPlayStyle";
            this.cbPlayStyle.Size = new System.Drawing.Size(123, 20);
            this.cbPlayStyle.TabIndex = 10;
            // 
            // btLinkOne
            // 
            this.btLinkOne.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btLinkOne.Location = new System.Drawing.Point(140, 172);
            this.btLinkOne.Name = "btLinkOne";
            this.btLinkOne.Size = new System.Drawing.Size(115, 44);
            this.btLinkOne.TabIndex = 9;
            this.btLinkOne.Text = "连 接";
            this.btLinkOne.UseVisualStyleBackColor = true;
            this.btLinkOne.Click += new System.EventHandler(this.btLinkOne_Click);
            // 
            // MusicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 262);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbMusicList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbPlayStyle);
            this.Controls.Add(this.btLinkOne);
            this.Name = "MusicForm";
            this.Text = "测试音乐";
            this.Load += new System.EventHandler(this.MusicForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMusicList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPlayStyle;
        private System.Windows.Forms.Button btLinkOne;
    }
}