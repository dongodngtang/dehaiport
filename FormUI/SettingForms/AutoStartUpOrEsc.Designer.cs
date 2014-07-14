namespace FormUI.SettingForms
{
    partial class AutoStartUpOrEsc
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
            this.btOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbSystemTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chbAutoRun = new System.Windows.Forms.CheckBox();
            this.groupBoxRadio = new System.Windows.Forms.GroupBox();
            this.txtPlayTimes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpAlarmTime = new System.Windows.Forms.DateTimePicker();
            this.btDelete = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbMusic = new System.Windows.Forms.ComboBox();
            this.nudMonth = new System.Windows.Forms.NumericUpDown();
            this.rbMonth = new System.Windows.Forms.RadioButton();
            this.rbDay = new System.Windows.Forms.RadioButton();
            this.rbConfirmTime = new System.Windows.Forms.RadioButton();
            this.rbWeek = new System.Windows.Forms.RadioButton();
            this.cmbStyle = new System.Windows.Forms.ComboBox();
            this.cblWeek = new System.Windows.Forms.CheckedListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBoxRadio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(238, 199);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(85, 46);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "确定";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "发送时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "自定音乐：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "播放模式：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 171);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "播放记录";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column9,
            this.Column7,
            this.Column1,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column8,
            this.Column2});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(626, 151);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Id";
            this.Column5.HeaderText = "序号";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 54;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "TerminalName";
            this.Column9.HeaderText = "终端名称";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 78;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Phone";
            this.Column7.HeaderText = "终端号码";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 78;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "RegularType";
            this.Column1.HeaderText = "定时类型";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 78;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Time";
            this.Column6.HeaderText = "播放时间";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 78;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Music";
            this.Column3.HeaderText = "播放音乐";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 78;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "PlayType";
            this.Column4.HeaderText = "播放模式";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 78;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "PlayTimes";
            this.Column8.HeaderText = "播放时长";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 78;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Status";
            this.Column2.HeaderText = "播放次数";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 78;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbSystemTime);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.chbAutoRun);
            this.groupBox2.Controls.Add(this.groupBoxRadio);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(632, 279);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "定时操作";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lbSystemTime
            // 
            this.lbSystemTime.AutoSize = true;
            this.lbSystemTime.Location = new System.Drawing.Point(475, 76);
            this.lbSystemTime.Name = "lbSystemTime";
            this.lbSystemTime.Size = new System.Drawing.Size(0, 12);
            this.lbSystemTime.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 45;
            this.label4.Text = "系统时间";
            // 
            // chbAutoRun
            // 
            this.chbAutoRun.AutoSize = true;
            this.chbAutoRun.Location = new System.Drawing.Point(477, 115);
            this.chbAutoRun.Name = "chbAutoRun";
            this.chbAutoRun.Size = new System.Drawing.Size(96, 16);
            this.chbAutoRun.TabIndex = 44;
            this.chbAutoRun.Text = "开机运行软件";
            this.chbAutoRun.UseVisualStyleBackColor = true;
            this.chbAutoRun.CheckedChanged += new System.EventHandler(this.chbAutoRun_CheckedChanged);
            // 
            // groupBoxRadio
            // 
            this.groupBoxRadio.Controls.Add(this.txtPlayTimes);
            this.groupBoxRadio.Controls.Add(this.label5);
            this.groupBoxRadio.Controls.Add(this.dtpAlarmTime);
            this.groupBoxRadio.Controls.Add(this.btDelete);
            this.groupBoxRadio.Controls.Add(this.btOk);
            this.groupBoxRadio.Controls.Add(this.dateTimePicker1);
            this.groupBoxRadio.Controls.Add(this.cmbMusic);
            this.groupBoxRadio.Controls.Add(this.nudMonth);
            this.groupBoxRadio.Controls.Add(this.rbMonth);
            this.groupBoxRadio.Controls.Add(this.rbDay);
            this.groupBoxRadio.Controls.Add(this.rbConfirmTime);
            this.groupBoxRadio.Controls.Add(this.rbWeek);
            this.groupBoxRadio.Controls.Add(this.label2);
            this.groupBoxRadio.Controls.Add(this.cmbStyle);
            this.groupBoxRadio.Controls.Add(this.cblWeek);
            this.groupBoxRadio.Controls.Add(this.label3);
            this.groupBoxRadio.Controls.Add(this.label1);
            this.groupBoxRadio.Location = new System.Drawing.Point(3, 20);
            this.groupBoxRadio.Name = "groupBoxRadio";
            this.groupBoxRadio.Size = new System.Drawing.Size(466, 259);
            this.groupBoxRadio.TabIndex = 12;
            this.groupBoxRadio.TabStop = false;
            this.groupBoxRadio.Text = "定时播放时间段设置";
            // 
            // txtPlayTimes
            // 
            this.txtPlayTimes.Location = new System.Drawing.Point(119, 223);
            this.txtPlayTimes.Name = "txtPlayTimes";
            this.txtPlayTimes.Size = new System.Drawing.Size(68, 21);
            this.txtPlayTimes.TabIndex = 21;
            this.txtPlayTimes.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "播放时间：";
            // 
            // dtpAlarmTime
            // 
            this.dtpAlarmTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpAlarmTime.Location = new System.Drawing.Point(120, 124);
            this.dtpAlarmTime.Name = "dtpAlarmTime";
            this.dtpAlarmTime.ShowUpDown = true;
            this.dtpAlarmTime.Size = new System.Drawing.Size(120, 21);
            this.dtpAlarmTime.TabIndex = 18;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(350, 199);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(85, 46);
            this.btDelete.TabIndex = 14;
            this.btDelete.Text = "删除";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 91);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 21);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // cmbMusic
            // 
            this.cmbMusic.DataBindings.Add(new System.Windows.Forms.Binding("Name", global::FormUI.Properties.Settings.Default, "cmbMusicR", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbMusic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMusic.FormattingEnabled = true;
            this.cmbMusic.Location = new System.Drawing.Point(119, 159);
            this.cmbMusic.Name = global::FormUI.Properties.Settings.Default.cmbMusicR;
            this.cmbMusic.Size = new System.Drawing.Size(67, 20);
            this.cmbMusic.TabIndex = 3;
            // 
            // nudMonth
            // 
            this.nudMonth.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nudMonth.Location = new System.Drawing.Point(101, 42);
            this.nudMonth.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMonth.Name = "nudMonth";
            this.nudMonth.Size = new System.Drawing.Size(50, 26);
            this.nudMonth.TabIndex = 11;
            this.nudMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbMonth
            // 
            this.rbMonth.AutoSize = true;
            this.rbMonth.Location = new System.Drawing.Point(38, 48);
            this.rbMonth.Name = "rbMonth";
            this.rbMonth.Size = new System.Drawing.Size(47, 16);
            this.rbMonth.TabIndex = 12;
            this.rbMonth.TabStop = true;
            this.rbMonth.Text = "每月";
            this.rbMonth.UseVisualStyleBackColor = true;
            // 
            // rbDay
            // 
            this.rbDay.AutoSize = true;
            this.rbDay.Location = new System.Drawing.Point(174, 48);
            this.rbDay.Name = "rbDay";
            this.rbDay.Size = new System.Drawing.Size(47, 16);
            this.rbDay.TabIndex = 13;
            this.rbDay.TabStop = true;
            this.rbDay.Text = "每天";
            this.rbDay.UseVisualStyleBackColor = true;
            // 
            // rbConfirmTime
            // 
            this.rbConfirmTime.AutoSize = true;
            this.rbConfirmTime.Location = new System.Drawing.Point(39, 94);
            this.rbConfirmTime.Name = "rbConfirmTime";
            this.rbConfirmTime.Size = new System.Drawing.Size(71, 16);
            this.rbConfirmTime.TabIndex = 16;
            this.rbConfirmTime.TabStop = true;
            this.rbConfirmTime.Text = "指定时间";
            this.rbConfirmTime.UseVisualStyleBackColor = true;
            // 
            // rbWeek
            // 
            this.rbWeek.AutoSize = true;
            this.rbWeek.Location = new System.Drawing.Point(235, 48);
            this.rbWeek.Name = "rbWeek";
            this.rbWeek.Size = new System.Drawing.Size(47, 16);
            this.rbWeek.TabIndex = 14;
            this.rbWeek.TabStop = true;
            this.rbWeek.Text = "每周";
            this.rbWeek.UseVisualStyleBackColor = true;
            this.rbWeek.CheckedChanged += new System.EventHandler(this.rbWeek_CheckedChanged);
            // 
            // cmbStyle
            // 
            this.cmbStyle.DataBindings.Add(new System.Windows.Forms.Binding("Name", global::FormUI.Properties.Settings.Default, "cmbStyleR", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStyle.FormattingEnabled = true;
            this.cmbStyle.Location = new System.Drawing.Point(119, 194);
            this.cmbStyle.Name = global::FormUI.Properties.Settings.Default.cmbStyleR;
            this.cmbStyle.Size = new System.Drawing.Size(68, 20);
            this.cmbStyle.TabIndex = 5;
            // 
            // cblWeek
            // 
            this.cblWeek.FormattingEnabled = true;
            this.cblWeek.Location = new System.Drawing.Point(288, 42);
            this.cblWeek.Name = "cblWeek";
            this.cblWeek.Size = new System.Drawing.Size(95, 116);
            this.cblWeek.TabIndex = 15;
            this.cblWeek.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AutoStartUpOrEsc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AutoStartUpOrEsc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "终端定时播放";
            this.Load += new System.EventHandler(this.AutoStartUpOrEsc_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxRadio.ResumeLayout(false);
            this.groupBoxRadio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMusic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStyle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudMonth;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxRadio;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rbConfirmTime;
        private System.Windows.Forms.CheckedListBox cblWeek;
        private System.Windows.Forms.RadioButton rbWeek;
        private System.Windows.Forms.RadioButton rbDay;
        private System.Windows.Forms.RadioButton rbMonth;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.DateTimePicker dtpAlarmTime;
        private System.Windows.Forms.CheckBox chbAutoRun;
        private System.Windows.Forms.Label lbSystemTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtPlayTimes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}