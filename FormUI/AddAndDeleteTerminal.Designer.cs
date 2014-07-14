namespace FormUI
{
    partial class AddAndDeleteTerminal
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
            this.btClose = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TerminalAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGrouping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TernimalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.TextBox();
            this.PhoneNo = new System.Windows.Forms.TextBox();
            this.Grouping = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.Location = new System.Drawing.Point(700, 210);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 50);
            this.btClose.TabIndex = 17;
            this.btClose.Text = "关  闭";
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(590, 210);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 50);
            this.btDelete.TabIndex = 15;
            this.btDelete.Text = "删除终端";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TerminalAddress,
            this.ColumnGrouping,
            this.ColumnPhoneNo,
            this.TernimalNo});
            this.dataGridView1.Location = new System.Drawing.Point(4, 14);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(559, 268);
            this.dataGridView1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "地 址：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "终端号码：";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(21, 130);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 56);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "添加\r\n终端";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click_1);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(131, 130);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 56);
            this.btClear.TabIndex = 5;
            this.btClear.Text = "清空";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Number);
            this.groupBox1.Controls.Add(this.Grouping);
            this.groupBox1.Controls.Add(this.PhoneNo);
            this.groupBox1.Controls.Add(this.Address);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btClear);
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(569, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 192);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "编号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "分 组：";
            // 
            // TerminalAddress
            // 
            this.TerminalAddress.FillWeight = 81.21828F;
            this.TerminalAddress.HeaderText = "地址";
            this.TerminalAddress.MinimumWidth = 80;
            this.TerminalAddress.Name = "TerminalAddress";
            this.TerminalAddress.ReadOnly = true;
            // 
            // ColumnGrouping
            // 
            this.ColumnGrouping.HeaderText = "分组";
            this.ColumnGrouping.Name = "ColumnGrouping";
            this.ColumnGrouping.ReadOnly = true;
            // 
            // ColumnPhoneNo
            // 
            this.ColumnPhoneNo.HeaderText = "编号";
            this.ColumnPhoneNo.Name = "ColumnPhoneNo";
            this.ColumnPhoneNo.ReadOnly = true;
            // 
            // TernimalNo
            // 
            this.TernimalNo.FillWeight = 118.7817F;
            this.TernimalNo.HeaderText = "终端号码";
            this.TernimalNo.MinimumWidth = 200;
            this.TernimalNo.Name = "TernimalNo";
            this.TernimalNo.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(90, 13);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(116, 21);
            this.Address.TabIndex = 11;
            // 
            // PhoneNo
            // 
            this.PhoneNo.Location = new System.Drawing.Point(90, 40);
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.Size = new System.Drawing.Size(116, 21);
            this.PhoneNo.TabIndex = 12;
            // 
            // Grouping
            // 
            this.Grouping.Location = new System.Drawing.Point(90, 67);
            this.Grouping.Name = "Grouping";
            this.Grouping.Size = new System.Drawing.Size(116, 21);
            this.Grouping.TabIndex = 13;
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(90, 91);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(116, 21);
            this.Number.TabIndex = 14;
            // 
            // AddAndDeleteTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 290);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddAndDeleteTerminal";
            this.Text = "AddAndDeleteTerminal";
            this.Load += new System.EventHandler(this.AddAndDeleteTerminal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerminalAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGrouping;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TernimalNo;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.TextBox Grouping;
        private System.Windows.Forms.TextBox PhoneNo;

    }
}