namespace FormUI.SettingForms
{
    partial class UserFrm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPwd11 = new System.Windows.Forms.TextBox();
            this.tbPwd12 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbPwd22 = new System.Windows.Forms.TextBox();
            this.btResetPwd = new System.Windows.Forms.Button();
            this.tbPwd21 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIndex,
            this.ColumnName});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(350, 371);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnIndex
            // 
            this.ColumnIndex.FillWeight = 81.21828F;
            this.ColumnIndex.HeaderText = "序号";
            this.ColumnIndex.MinimumWidth = 80;
            this.ColumnIndex.Name = "ColumnIndex";
            this.ColumnIndex.ReadOnly = true;
            // 
            // ColumnName
            // 
            this.ColumnName.DataPropertyName = "UserName";
            this.ColumnName.FillWeight = 118.7817F;
            this.ColumnName.HeaderText = "用户名";
            this.ColumnName.MinimumWidth = 200;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(90, 22);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(116, 21);
            this.tbUserName.TabIndex = 1;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(212, 20);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 56);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "添加\r\n用户";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(368, 333);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 50);
            this.btDelete.TabIndex = 10;
            this.btDelete.Text = "删除用户";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "用 户 名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "密　　码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "确认密码：";
            // 
            // tbPwd11
            // 
            this.tbPwd11.Location = new System.Drawing.Point(90, 55);
            this.tbPwd11.Name = "tbPwd11";
            this.tbPwd11.PasswordChar = '*';
            this.tbPwd11.Size = new System.Drawing.Size(116, 21);
            this.tbPwd11.TabIndex = 2;
            // 
            // tbPwd12
            // 
            this.tbPwd12.Location = new System.Drawing.Point(90, 93);
            this.tbPwd12.Name = "tbPwd12";
            this.tbPwd12.PasswordChar = '*';
            this.tbPwd12.Size = new System.Drawing.Size(116, 21);
            this.tbPwd12.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btClear);
            this.groupBox1.Controls.Add(this.tbPwd12);
            this.groupBox1.Controls.Add(this.tbUserName);
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.Controls.Add(this.tbPwd11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(368, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 133);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(212, 91);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 5;
            this.btClear.Text = "清空";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbPwd22);
            this.groupBox2.Controls.Add(this.btResetPwd);
            this.groupBox2.Controls.Add(this.tbPwd21);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(368, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 160);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // tbPwd22
            // 
            this.tbPwd22.Location = new System.Drawing.Point(90, 89);
            this.tbPwd22.Name = "tbPwd22";
            this.tbPwd22.PasswordChar = '*';
            this.tbPwd22.Size = new System.Drawing.Size(116, 21);
            this.tbPwd22.TabIndex = 8;
            // 
            // btResetPwd
            // 
            this.btResetPwd.Location = new System.Drawing.Point(212, 58);
            this.btResetPwd.Name = "btResetPwd";
            this.btResetPwd.Size = new System.Drawing.Size(75, 52);
            this.btResetPwd.TabIndex = 9;
            this.btResetPwd.Text = "重置\r\n密码";
            this.btResetPwd.UseVisualStyleBackColor = true;
            this.btResetPwd.Click += new System.EventHandler(this.btResetPwd_Click);
            // 
            // tbPwd21
            // 
            this.tbPwd21.Location = new System.Drawing.Point(90, 58);
            this.tbPwd21.Name = "tbPwd21";
            this.tbPwd21.PasswordChar = '*';
            this.tbPwd21.Size = new System.Drawing.Size(116, 21);
            this.tbPwd21.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "确认密码：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "密　　码：";
            // 
            // btClose
            // 
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.Location = new System.Drawing.Point(593, 333);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 50);
            this.btClose.TabIndex = 12;
            this.btClose.Text = "关  闭";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // UserFrm
            // 
            this.AcceptButton = this.btAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btClose;
            this.ClientSize = new System.Drawing.Size(686, 404);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.UserFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPwd11;
        private System.Windows.Forms.TextBox tbPwd12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbPwd22;
        private System.Windows.Forms.Button btResetPwd;
        private System.Windows.Forms.TextBox tbPwd21;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btClear;
    }
}