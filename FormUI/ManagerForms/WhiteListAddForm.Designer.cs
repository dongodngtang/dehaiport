namespace FormUI.ManagerForms
{
    partial class WhiteListAddForm
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
            this.tbWhiteListAdd = new System.Windows.Forms.Button();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbWhiteListAdd
            // 
            this.tbWhiteListAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.tbWhiteListAdd.Location = new System.Drawing.Point(94, 149);
            this.tbWhiteListAdd.Name = "tbWhiteListAdd";
            this.tbWhiteListAdd.Size = new System.Drawing.Size(91, 44);
            this.tbWhiteListAdd.TabIndex = 1;
            this.tbWhiteListAdd.Text = "确 认";
            this.tbWhiteListAdd.UseVisualStyleBackColor = true;
            this.tbWhiteListAdd.Click += new System.EventHandler(this.tbWhiteListAdd_Click);
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(94, 38);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(147, 21);
            this.txtPhoneNo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "电话号码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "权    限：";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(94, 88);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(147, 20);
            this.cbType.TabIndex = 8;
            // 
            // WhiteListAddForm
            // 
            this.AcceptButton = this.tbWhiteListAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 245);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbWhiteListAdd);
            this.Name = "WhiteListAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "白名单添加";
            this.Load += new System.EventHandler(this.WhiteListAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tbWhiteListAdd;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbType;
    }
}