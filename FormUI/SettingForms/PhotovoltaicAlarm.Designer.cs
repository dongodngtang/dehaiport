namespace FormUI.SettingForms
{
    partial class PhotovoltaicAlarm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBattery = new System.Windows.Forms.TextBox();
            this.txtQS = new System.Windows.Forms.TextBox();
            this.txtMm = new System.Windows.Forms.TextBox();
            this.txtHh = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "定时时间：";
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(107, 172);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 39);
            this.btOk.TabIndex = 2;
            this.btOk.Text = "确定";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "光伏下限：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "时";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "分";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "V ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "V ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "蓄电池下限：";
            // 
            // txtBattery
            // 
            this.txtBattery.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FormUI.Properties.Settings.Default, "Battery", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtBattery.Location = new System.Drawing.Point(107, 133);
            this.txtBattery.Name = "txtBattery";
            this.txtBattery.Size = new System.Drawing.Size(116, 21);
            this.txtBattery.TabIndex = 11;
            this.txtBattery.Text = global::FormUI.Properties.Settings.Default.Battery;
            // 
            // txtQS
            // 
            this.txtQS.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FormUI.Properties.Settings.Default, "RDS", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtQS.Location = new System.Drawing.Point(107, 96);
            this.txtQS.Name = "txtQS";
            this.txtQS.Size = new System.Drawing.Size(116, 21);
            this.txtQS.TabIndex = 6;
            this.txtQS.Text = global::FormUI.Properties.Settings.Default.RDS;
            // 
            // txtMm
            // 
            this.txtMm.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FormUI.Properties.Settings.Default, "Mm", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtMm.Location = new System.Drawing.Point(185, 56);
            this.txtMm.MaxLength = 2;
            this.txtMm.Name = "txtMm";
            this.txtMm.Size = new System.Drawing.Size(38, 21);
            this.txtMm.TabIndex = 4;
            this.txtMm.Text = global::FormUI.Properties.Settings.Default.Mm;
            // 
            // txtHh
            // 
            this.txtHh.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FormUI.Properties.Settings.Default, "Hh", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtHh.Location = new System.Drawing.Point(107, 56);
            this.txtHh.MaxLength = 2;
            this.txtHh.Name = "txtHh";
            this.txtHh.Size = new System.Drawing.Size(39, 21);
            this.txtHh.TabIndex = 0;
            this.txtHh.Text = global::FormUI.Properties.Settings.Default.Hh;
            // 
            // PhotovoltaicAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 262);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBattery);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHh);
            this.Name = "PhotovoltaicAlarm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "下限警告";
            this.Load += new System.EventHandler(this.PhotovoltaicAlarm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBattery;
        private System.Windows.Forms.Label label8;
    }
}