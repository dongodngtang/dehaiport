using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using FormUI.OperationLayer;
using TomorrowSoft.BLL;
using TomorrowSoft.Model;

namespace FormUI.ManagerForms
{
    public partial class ConditionForm : Form
    {
        private readonly TomorrowSoft.BLL.ConditionService _condition = new ConditionService();
        private BindingSource bs = new BindingSource();
      
        public ConditionForm()
        {
            InitializeComponent();
            Printer.DataGridViewList = this.dataGridView1;
        } 

        private void ConditionForm_Load(object sender, EventArgs e)
        {
            bs.DataSource = _condition.GetModelList("");
            GetConditionList(bs);
            if (LoginForm.Level == "管理员")
            {
                btClear.Visible = true;
            }
        }
        private void GetConditionList(BindingSource bs)
        {
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
        }
        private void btQuery_Click(object sender, EventArgs e)
        {
            StringBuilder sbQuery = new StringBuilder();
            sbQuery.AppendFormat("datetime([HandlerTime]) >= datetime('{0} 00:00') ", dtpBegin.Value.ToString("yyyy-MM-dd"));
            sbQuery.Append(" AND ");
            sbQuery.AppendFormat("datetime([HandlerTime]) <= datetime('{0}') ", dtpEnd.Value.ToString("yyyy-MM-dd HH:mm"));
            List<Condition> terminals = _condition.GetModelList(sbQuery.ToString());
            bs.DataSource = terminals;
            GetConditionList(bs);
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            Printer.Printting();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                if (MessageBox.Show(string.Format(@"您确定要清除所有历史记录？"), "提示",
                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    _condition.DeleteList("");
                    GetConditionList(bs);
                    MessageBox.Show("清除成功！");
                }
            }
            else
            {
                if (MessageBox.Show(string.Format("您确定要删除{0}记录?", dataGridView1.SelectedRows.Count), "提示",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        _condition.Delete(Convert.ToInt32(dataGridView1.SelectedRows[i].Cells[0].Value));
                    }
                    MessageBox.Show("删除成功！");
                    GetConditionList(bs);
                }
            }
        }

      
    }
}
