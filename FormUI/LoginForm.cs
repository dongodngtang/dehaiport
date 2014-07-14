using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FormUI.Properties;
using TomorrowSoft.BLL;
using TomorrowSoft.Model;

namespace FormUI
{
    public partial class LoginForm : Form
    {
        private UserService _bll;
        public LoginForm()
        {
            InitializeComponent();
            _bll = new UserService();
        }

     
        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (!cbRemember.Checked)
                tbPwd.Text = "";
        }

        public static string Level;
        private void btLogOn_Click(object sender, EventArgs e)
        {
            if (Varification()) return;
            //保存上次登录名和是否记住密码
            Settings.Default.Save();
            this.DialogResult = DialogResult.OK;
        }

        private bool Varification()
        {
            IList<User> users = _bll.GetModelList(string.Format("UserName = '{0}'", tbUserName.Text.Trim()));
            if (users.Count == 0)
            {
                MessageBox.Show(Resources.Login_NoUser);
                return true;
            }
            User user = users[0];
            Level = user.Level;
            if (!user.Password.Equals(tbPwd.Text.Trim()))
            {
                MessageBox.Show("密码不正确！");
                return true;
            }
            return false;
        }
      
    }
}
