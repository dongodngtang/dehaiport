using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TomorrowSoft.BLL;
using TomorrowSoft.Model;

namespace FormUI
{
    public partial class AddAndDeleteTerminal : Form
    {
         private TerminalService _bll;

        public AddAndDeleteTerminal()
        {
            InitializeComponent();
            _bll = new TerminalService();
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
                var data = dataGridView1.SelectedRows[0].DataBoundItem as Terminal;

                if (MessageBox.Show(
                    string.Format(@"您确定删除“{0}”吗？", data.PhoneNo),
                    "提醒",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
                {
                    _bll.Delete(data.Id);
                    MessageBox.Show("删除成功！");
                }
            }
            catch
            {
                MessageBox.Show("删除失败！");
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddAndDeleteTerminal_Load(object sender, EventArgs e)
        {
 
            dataGridView1.AutoGenerateColumns = false;
 
        }

        private void btAdd_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Address.Text))
            {
                MessageBox.Show("不能添加空内容！");
                return;
            }
            if (_bll.GetModelList(string.Format("PhoneNo = '{0}'", PhoneNo.Text)).Count > 0)
            {
                MessageBox.Show("终端已经存在！");
                return;
            }
            if (string.IsNullOrEmpty(Address.Text))
            {
                MessageBox.Show("号码不能为空！");
                return;
            }
            try
            {
                _bll.Add(new Terminal()
                {
                    Id = Guid.NewGuid(),
                    Address = Address.Text,
                    PhoneNo = PhoneNo.Text,
                    Number = Number.Text,
                    Grouping = Grouping.Text,
                });
                MessageBox.Show("添加成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("添加失败！原因：" + ex.Message + "。");
            }
        }

        private void btDelete_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择一行！");
                return;
            }

            try
            {
                var data = dataGridView1.SelectedRows[0].DataBoundItem as Terminal;

                if (MessageBox.Show(
                    string.Format(@"您确定删除“{0}”吗？", data.PhoneNo),
                    "提醒",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
                {
                    _bll.Delete(data.Id);
                    MessageBox.Show("删除成功！");
                }
            }
            catch
            {
                MessageBox.Show("删除失败！");
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Address.Text = "";
            PhoneNo.Text = "";
            Number.Text = "";
            Grouping.Text = "";
        }

        private void PhoneNo_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
