namespace FormUI.ManagerForms
{
    partial class PortForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOpenClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbConnectTip = new System.Windows.Forms.Label();
            this.cbPortName = new System.Windows.Forms.ComboBox();
            this.cbStopBits = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRecv = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenClose
            // 
            this.btnOpenClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpenClose.Location = new System.Drawing.Point(22, 214);
            this.btnOpenClose.Name = "btnOpenClose";
            this.btnOpenClose.Size = new System.Drawing.Size(166, 38);
            this.btnOpenClose.TabIndex = 0;
            this.btnOpenClose.Text = "打开串口";
            this.btnOpenClose.UseVisualStyleBackColor = true;
            this.btnOpenClose.Click += new System.EventHandler(this.btnOpenClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "端口号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "波特率";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "数据位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "校验位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "停止位";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbConnectTip);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnOpenClose);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbPortName);
            this.panel1.Controls.Add(this.cbStopBits);
            this.panel1.Controls.Add(this.cbBaudRate);
            this.panel1.Controls.Add(this.cbParity);
            this.panel1.Controls.Add(this.cbDataBits);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 279);
            this.panel1.TabIndex = 11;
            
            // 
            // lbConnectTip
            // 
            this.lbConnectTip.AutoSize = true;
            this.lbConnectTip.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbConnectTip.Location = new System.Drawing.Point(56, 163);
            this.lbConnectTip.Name = "lbConnectTip";
            this.lbConnectTip.Size = new System.Drawing.Size(22, 21);
            this.lbConnectTip.TabIndex = 17;
            this.lbConnectTip.Text = " ";
            // 
            // cbPortName
            // 
            this.cbPortName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FormUI.Properties.Settings.Default, "PortName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPortName.FormattingEnabled = true;
            this.cbPortName.Location = new System.Drawing.Point(67, 12);
            this.cbPortName.Name = "cbPortName";
            this.cbPortName.Size = new System.Drawing.Size(121, 20);
            this.cbPortName.TabIndex = 3;
            this.cbPortName.TabStop = false;
            this.cbPortName.Text = global::FormUI.Properties.Settings.Default.PortName;
            // 
            // cbStopBits
            // 
            this.cbStopBits.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FormUI.Properties.Settings.Default, "StopBit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStopBits.FormattingEnabled = true;
            this.cbStopBits.Location = new System.Drawing.Point(67, 118);
            this.cbStopBits.Name = "cbStopBits";
            this.cbStopBits.Size = new System.Drawing.Size(121, 20);
            this.cbStopBits.TabIndex = 8;
            this.cbStopBits.Text = global::FormUI.Properties.Settings.Default.StopBit;
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FormUI.Properties.Settings.Default, "BaudRate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Location = new System.Drawing.Point(67, 40);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(121, 20);
            this.cbBaudRate.TabIndex = 4;
            this.cbBaudRate.Text = global::FormUI.Properties.Settings.Default.BaudRate;
            // 
            // cbParity
            // 
            this.cbParity.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FormUI.Properties.Settings.Default, "Parity", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Location = new System.Drawing.Point(67, 92);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(121, 20);
            this.cbParity.TabIndex = 7;
            this.cbParity.Text = global::FormUI.Properties.Settings.Default.Parity;
            // 
            // cbDataBits
            // 
            this.cbDataBits.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FormUI.Properties.Settings.Default, "DataBits", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Location = new System.Drawing.Point(67, 66);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(121, 20);
            this.cbDataBits.TabIndex = 5;
            this.cbDataBits.Text = global::FormUI.Properties.Settings.Default.DataBits;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(3, 278);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(214, 95);
            this.panel4.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(218, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 279);
            this.panel2.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRecv);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, -283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(0, 374);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收区";
            // 
            // txtRecv
            // 
            this.txtRecv.BackColor = System.Drawing.SystemColors.Control;
            this.txtRecv.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRecv.ForeColor = System.Drawing.Color.Lime;
            this.txtRecv.Location = new System.Drawing.Point(205, 231);
            this.txtRecv.Multiline = true;
            this.txtRecv.Name = "txtRecv";
            this.txtRecv.Size = new System.Drawing.Size(10, 88);
            this.txtRecv.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.txtSend);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(0, 188);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发送区";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, -212);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(545, 400);
            this.panel3.TabIndex = 1;
            // 
            // txtSend
            // 
            this.txtSend.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSend.ForeColor = System.Drawing.Color.Lime;
            this.txtSend.Location = new System.Drawing.Point(3, 17);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(0, 168);
            this.txtSend.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 279);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PortForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串口调试工具";
            this.Load += new System.EventHandler(this.MainFrom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPortName;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbStopBits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRecv;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbConnectTip;

    }
}

