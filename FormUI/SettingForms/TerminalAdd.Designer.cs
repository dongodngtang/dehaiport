namespace FormUI.SettingForms
{
    partial class TerminalAdd
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.tbWhiteListAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGroupPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAllPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "组    号：";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(100, 119);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(147, 21);
            this.txtPhoneNo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "电话号码：";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(100, 62);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(147, 21);
            this.txtAddress.TabIndex = 1;
            // 
            // tbWhiteListAdd
            // 
            this.tbWhiteListAdd.Location = new System.Drawing.Point(100, 219);
            this.tbWhiteListAdd.Name = "tbWhiteListAdd";
            this.tbWhiteListAdd.Size = new System.Drawing.Size(91, 44);
            this.tbWhiteListAdd.TabIndex = 6;
            this.tbWhiteListAdd.Text = "确 认";
            this.tbWhiteListAdd.UseVisualStyleBackColor = true;
            this.tbWhiteListAdd.Click += new System.EventHandler(this.tbWhiteListAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "终端地址：";
            // 
            // txtGroupPhone
            // 
            this.txtGroupPhone.Location = new System.Drawing.Point(100, 149);
            this.txtGroupPhone.Name = "txtGroupPhone";
            this.txtGroupPhone.Size = new System.Drawing.Size(147, 21);
            this.txtGroupPhone.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "组绑定号：";
            // 
            // txtAllPhone
            // 
            this.txtAllPhone.Location = new System.Drawing.Point(100, 178);
            this.txtAllPhone.Name = "txtAllPhone";
            this.txtAllPhone.Size = new System.Drawing.Size(147, 21);
            this.txtAllPhone.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "齐绑定号：";
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(100, 89);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(147, 21);
            this.txtGroup.TabIndex = 2;
            this.txtGroup.Leave += new System.EventHandler(this.txtGroup_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(147, 21);
            this.txtName.TabIndex = 0;
            this.txtName.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 23;
            this.label6.Text = "终端名称：";
            // 
            // TerminalAdd
            // 
            this.AcceptButton = this.tbWhiteListAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 285);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.txtGroupPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAllPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.tbWhiteListAdd);
            this.Controls.Add(this.label1);
            this.Name = "TerminalAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加";
            this.Load += new System.EventHandler(this.TerminalAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button tbWhiteListAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGroupPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAllPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
    }
}