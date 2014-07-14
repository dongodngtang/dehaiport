namespace FormUI
{
    partial class LoginForm
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
            this.btLogOn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRemember = new System.Windows.Forms.CheckBox();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btLogOn
            // 
            this.btLogOn.Location = new System.Drawing.Point(89, 142);
            this.btLogOn.Name = "btLogOn";
            this.btLogOn.Size = new System.Drawing.Size(108, 43);
            this.btLogOn.TabIndex = 12;
            this.btLogOn.Text = "登录";
            this.btLogOn.UseVisualStyleBackColor = true;
            this.btLogOn.Click += new System.EventHandler(this.btLogOn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "密　码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "用户名：";
            // 
            // cbRemember
            // 
            this.cbRemember.AutoSize = true;
            this.cbRemember.Checked = global::FormUI.Properties.Settings.Default.Remenber;
            this.cbRemember.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::FormUI.Properties.Settings.Default, "Remenber", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbRemember.Location = new System.Drawing.Point(89, 107);
            this.cbRemember.Name = "cbRemember";
            this.cbRemember.Size = new System.Drawing.Size(72, 16);
            this.cbRemember.TabIndex = 11;
            this.cbRemember.Text = "记住密码";
            this.cbRemember.UseVisualStyleBackColor = true;
            // 
            // tbPwd
            // 
            this.tbPwd.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FormUI.Properties.Settings.Default, "Password", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbPwd.Location = new System.Drawing.Point(89, 70);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.PasswordChar = '*';
            this.tbPwd.Size = new System.Drawing.Size(161, 21);
            this.tbPwd.TabIndex = 10;
            this.tbPwd.Text = global::FormUI.Properties.Settings.Default.Password;
            // 
            // tbUserName
            // 
            this.tbUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FormUI.Properties.Settings.Default, "UserName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbUserName.Location = new System.Drawing.Point(89, 38);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(161, 21);
            this.tbUserName.TabIndex = 9;
            this.tbUserName.Text = global::FormUI.Properties.Settings.Default.UserName;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btLogOn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 206);
            this.Controls.Add(this.btLogOn);
            this.Controls.Add(this.cbRemember);
            this.Controls.Add(this.tbPwd);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登陆界面";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLogOn;
        private System.Windows.Forms.CheckBox cbRemember;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}