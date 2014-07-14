using System;
using System.Windows.Forms;
using FormUI.OperationLayer;
using TomorrowSoft.BLL;
using TomorrowSoft.Model;

namespace FormUI.SettingForms
{
    public partial class UserFrm : Form
    {
        private UserService _bll;

        public UserFrm()
        {
            InitializeComponent();
            _bll = new UserService();
        }

        private void UserFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            Display();
             new ControlHelpers().FormChange(this);
        }

        private void Display()
        {
            dataGridView1.DataSource = _bll.GetModelList("UserName <> 'Tomorrow'");
           
            foreach(DataGridViewRow row in  dataGridView1.Rows)
            {
                row.Cells["ColumnIndex"].Value = dataGridView1.Rows.IndexOf(row) + 1;
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbUserName.Text))
            {
                MessageBox.Show("不能添加空内容！");
                return;
            }
            if(_bll.GetModelList(string.Format("UserName = '{0}'",tbUserName.Text)).Count>0)
            {
                MessageBox.Show("用户名已经存在！");
                return;
            }
            if(string.IsNullOrEmpty(tbPwd11.Text))
            {
                MessageBox.Show("密码不能为空！");
                return;
            }
            if(!tbPwd11.Text.Equals(tbPwd12.Text))
            {
                MessageBox.Show("两次密码必须相同！");
                return;
            }
            try
            {
                _bll.Add(new User
                             {
                                 Id=Guid.NewGuid(), 
                                 UserName = tbUserName.Text,
                                 Password = tbPwd11.Text,
                                 Level = "普通用户",
                                 Remember = false
                             });
                MessageBox.Show("添加成功！");
                Display();
            }
            catch(Exception ex)
            {
                MessageBox.Show("添加失败！原因：" + ex.Message + "。");
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择一行！");
                return;
            }

            try
            {
                var data = dataGridView1.SelectedRows[0].DataBoundItem as User;

                if(data.UserName == "Tomorrow" || data.UserName == "admin")
                {
                    MessageBox.Show("该账户不允许删除！");
                    return;
                }

                if (MessageBox.Show(
                    string.Format(@"您确定删除“{0}”吗？", data.UserName),
                    "提醒",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
                {
                    _bll.Delete(data.Id);
                    MessageBox.Show("删除成功！");
                    Display();
                }
            }
            catch
            {
                MessageBox.Show("删除失败！");
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbPwd11.Clear();
            tbPwd12.Text = "";
            tbUserName.Text = "";
        }

        private void btResetPwd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择一行！");
                return;
            }

            if (string.IsNullOrEmpty(tbPwd21.Text))
            {
                MessageBox.Show("密码不能为空！");
                return;
            }
            if (!tbPwd21.Text.Equals(tbPwd22.Text))
            {
                MessageBox.Show("两次密码必须相同！");
                return;
            }

            try
            {
                var data = dataGridView1.SelectedRows[0].DataBoundItem as User;
                
                if (MessageBox.Show(
                    string.Format(@"您确定重置“{0}”的密码吗？", data.UserName),
                    "提醒",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
                {
                    data.Password = tbPwd21.Text;
                    _bll.Update(data);
                    MessageBox.Show("重置密码成功！");
                }
            }
            catch
            {
                MessageBox.Show("重置密码成功！");
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
