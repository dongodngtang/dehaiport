namespace FormUI.SettingForms
{
    partial class AutoPlayer
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
            this.dgvMenbers = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPlayTimes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMusic = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStyle = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btExecute = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.dgvGroup = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenbers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMenbers
            // 
            this.dgvMenbers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMenbers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMenbers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenbers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column1});
            this.dgvMenbers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenbers.Location = new System.Drawing.Point(3, 17);
            this.dgvMenbers.Name = "dgvMenbers";
            this.dgvMenbers.RowTemplate.Height = 23;
            this.dgvMenbers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenbers.Size = new System.Drawing.Size(372, 188);
            this.dgvMenbers.TabIndex = 0;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TerminalName";
            this.Column2.HeaderText = "终端名";
            this.Column2.Name = "Column2";
            this.Column2.Width = 66;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TerminalNo";
            this.Column3.HeaderText = "终端号";
            this.Column3.Name = "Column3";
            this.Column3.Width = 66;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "PlayDelay";
            this.Column4.HeaderText = "播放延时";
            this.Column4.Name = "Column4";
            this.Column4.Width = 78;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Music";
            this.Column7.HeaderText = "音乐";
            this.Column7.Name = "Column7";
            this.Column7.Width = 54;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "PlayStyle";
            this.Column8.HeaderText = "播放模式";
            this.Column8.Name = "Column8";
            this.Column8.Width = 78;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "PlayMinute";
            this.Column9.HeaderText = "播放时间";
            this.Column9.Name = "Column9";
            this.Column9.Width = 78;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PlayTimes";
            this.Column1.HeaderText = "播放次数";
            this.Column1.Name = "Column1";
            this.Column1.Width = 78;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMenbers);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 208);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成员列表";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPlayTimes);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbMusic);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbStyle);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtGroupName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtDelay);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(2, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 204);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "参数设置";
            // 
            // txtPlayTimes
            // 
            this.txtPlayTimes.Location = new System.Drawing.Point(78, 160);
            this.txtPlayTimes.Name = "txtPlayTimes";
            this.txtPlayTimes.Size = new System.Drawing.Size(67, 21);
            this.txtPlayTimes.TabIndex = 27;
            this.txtPlayTimes.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 26;
            this.label5.Text = "播放时间：";
            // 
            // cmbMusic
            // 
            this.cmbMusic.DataBindings.Add(new System.Windows.Forms.Binding("Name", global::FormUI.Properties.Settings.Default, "cmbMusicR", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbMusic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMusic.FormattingEnabled = true;
            this.cmbMusic.Location = new System.Drawing.Point(78, 98);
            this.cmbMusic.Name = global::FormUI.Properties.Settings.Default.cmbMusicR;
            this.cmbMusic.Size = new System.Drawing.Size(67, 20);
            this.cmbMusic.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "自定音乐：";
            // 
            // cmbStyle
            // 
            this.cmbStyle.DataBindings.Add(new System.Windows.Forms.Binding("Name", global::FormUI.Properties.Settings.Default, "cmbStyleR", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStyle.FormattingEnabled = true;
            this.cmbStyle.Location = new System.Drawing.Point(78, 130);
            this.cmbStyle.Name = global::FormUI.Properties.Settings.Default.cmbStyleR;
            this.cmbStyle.Size = new System.Drawing.Size(67, 20);
            this.cmbStyle.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "播放模式：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "确认";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "分钟";
            // 
            // txtGroupName
            // 
            this.txtGroupName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FormUI.Properties.Settings.Default, "GroupName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtGroupName.Location = new System.Drawing.Point(78, 65);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(95, 21);
            this.txtGroupName.TabIndex = 6;
            this.txtGroupName.Text = global::FormUI.Properties.Settings.Default.GroupName;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "播放组名：";
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(78, 24);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(59, 21);
            this.txtDelay.TabIndex = 4;
            this.txtDelay.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "播放延时：";
            // 
            // btExecute
            // 
            this.btExecute.Location = new System.Drawing.Point(136, 315);
            this.btExecute.Name = "btExecute";
            this.btExecute.Size = new System.Drawing.Size(75, 42);
            this.btExecute.TabIndex = 2;
            this.btExecute.Text = "执行播放组";
            this.btExecute.UseVisualStyleBackColor = true;
            this.btExecute.Click += new System.EventHandler(this.btExecute_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(26, 315);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 42);
            this.btDel.TabIndex = 1;
            this.btDel.Text = "删除播放组";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // dgvGroup
            // 
            this.dgvGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGroup.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5});
            this.dgvGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvGroup.Location = new System.Drawing.Point(3, 17);
            this.dgvGroup.Name = "dgvGroup";
            this.dgvGroup.RowTemplate.Height = 23;
            this.dgvGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroup.Size = new System.Drawing.Size(245, 188);
            this.dgvGroup.TabIndex = 5;
            this.dgvGroup.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroup_CellContentClick);
            this.dgvGroup.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroup_CellContentClick);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GroupName";
            this.Column5.HeaderText = "播放组名";
            this.Column5.Name = "Column5";
            this.Column5.Width = 78;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvGroup);
            this.groupBox3.Controls.Add(this.btDel);
            this.groupBox3.Controls.Add(this.btExecute);
            this.groupBox3.Location = new System.Drawing.Point(453, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 407);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "组列表";
            // 
            // AutoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 418);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AutoPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "记忆组播放";
            this.Load += new System.EventHandler(this.AutoPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenbers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMenbers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btExecute;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.DataGridView dgvGroup;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPlayTimes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMusic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStyle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}