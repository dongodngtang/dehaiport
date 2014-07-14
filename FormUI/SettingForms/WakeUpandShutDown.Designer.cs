namespace FormUI.SettingForms
{
    partial class WakeUpandShutDown
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
            this.chbAutoRun = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtss = new System.Windows.Forms.TextBox();
            this.txtmm = new System.Windows.Forms.TextBox();
            this.txtHH = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // chbAutoRun
            // 
            this.chbAutoRun.AutoSize = true;
            this.chbAutoRun.Checked = global::FormUI.Properties.Settings.Default.StartUp;
            this.chbAutoRun.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::FormUI.Properties.Settings.Default, "StartUp", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chbAutoRun.Location = new System.Drawing.Point(334, 41);
            this.chbAutoRun.Name = "chbAutoRun";
            this.chbAutoRun.Size = new System.Drawing.Size(96, 16);
            this.chbAutoRun.TabIndex = 43;
            this.chbAutoRun.Text = "开机运行软件";
            this.chbAutoRun.UseVisualStyleBackColor = true;
            this.chbAutoRun.CheckedChanged += new System.EventHandler(this.chbAutoRun_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 42;
            this.label12.Text = "模式：开机";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 41;
            this.label8.Text = "秒";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(157, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 40;
            this.label9.Text = "分";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(98, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 39;
            this.label10.Text = "时";
            // 
            // txtss
            // 
            this.txtss.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FormUI.Properties.Settings.Default, "sss", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtss.Location = new System.Drawing.Point(180, 117);
            this.txtss.Name = "txtss";
            this.txtss.Size = new System.Drawing.Size(30, 21);
            this.txtss.TabIndex = 38;
            this.txtss.Text = global::FormUI.Properties.Settings.Default.sss;
            this.txtss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtmm
            // 
            this.txtmm.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FormUI.Properties.Settings.Default, "smm", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtmm.Location = new System.Drawing.Point(121, 117);
            this.txtmm.Name = "txtmm";
            this.txtmm.Size = new System.Drawing.Size(30, 21);
            this.txtmm.TabIndex = 37;
            this.txtmm.Text = global::FormUI.Properties.Settings.Default.smm;
            this.txtmm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHH
            // 
            this.txtHH.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FormUI.Properties.Settings.Default, "sHH", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtHH.Location = new System.Drawing.Point(62, 117);
            this.txtHH.Name = "txtHH";
            this.txtHH.Size = new System.Drawing.Size(30, 21);
            this.txtHH.TabIndex = 36;
            this.txtHH.Text = global::FormUI.Properties.Settings.Default.sHH;
            this.txtHH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 35;
            this.label11.Text = "时间：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 12);
            this.label7.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 33;
            this.label6.Text = "系统：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 32;
            this.label5.Text = "秒";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 31;
            this.label4.Text = "分";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 30;
            this.label3.Text = "时";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FormUI.Properties.Settings.Default, "dss", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox3.Location = new System.Drawing.Point(180, 41);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(30, 21);
            this.textBox3.TabIndex = 29;
            this.textBox3.Text = global::FormUI.Properties.Settings.Default.dss;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FormUI.Properties.Settings.Default, "dmm", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox2.Location = new System.Drawing.Point(121, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(30, 21);
            this.textBox2.TabIndex = 28;
            this.textBox2.Text = global::FormUI.Properties.Settings.Default.dmm;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FormUI.Properties.Settings.Default, "dHH", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(62, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(30, 21);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = global::FormUI.Properties.Settings.Default.dHH;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "模式：关机";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "时间：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(334, 156);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(107, 23);
            this.btnOK.TabIndex = 24;
            this.btnOK.Text = "开始";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // WakeUpandShutDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 219);
            this.Controls.Add(this.chbAutoRun);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtss);
            this.Controls.Add(this.txtmm);
            this.Controls.Add(this.txtHH);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Name = "WakeUpandShutDown";
            this.Text = "定时开关机";
            this.Load += new System.EventHandler(this.WakeUpandShutDown_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbAutoRun;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtss;
        private System.Windows.Forms.TextBox txtmm;
        private System.Windows.Forms.TextBox txtHH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}