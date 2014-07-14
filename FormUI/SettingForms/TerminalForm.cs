using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FormUI.OperationLayer;
using FormUI.Properties;
using TomorrowSoft.BLL;
using TomorrowSoft.Model;

namespace FormUI.SettingForms
{  
    public partial class TerminalForm : Form
    {
        
        private TerminalService _bllTerminal;
        private OrderDefinition _order = new OrderDefinition();
        private List<Terminal> _terminals = new List<Terminal>();
     

        public TerminalForm()
        {
            InitializeComponent();
            _bllTerminal = new TerminalService();
        }

      
        private void TerminalForm_Load(object sender, EventArgs e)
        {
           
        
            GetTerminalList();
            new ControlHelpers().FormChange(this);
        }

        private void GetTerminalList()
        {
            var bs = new BindingSource();
            var lists = _bllTerminal.GetModelList("");
            _terminals = lists;
            bs.DataSource = lists;
            dataGridView1.DataSource = bs;
            bindingNavigator2.BindingSource = bs;
        }

        private void MeetingNo_End_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();
            MessageBox.Show("保存成功");
        }
        
        private void btTerminalAdd_Click(object sender, EventArgs e)
        {
            new TerminalAdd().ShowDialog();
            GetTerminalList();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("请至少选择一行！");
            }
            else
            {
                if (MessageBox.Show(string.Format(@"您确定删除选中的 {0} 条标签吗？", dataGridView1.SelectedRows.Count),
                                    "提示",
                                    MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Question) == DialogResult.OK)
                {
                    for (int index = 0; index < dataGridView1.SelectedRows.Count; index++)
                    {
                        var data = dataGridView1.SelectedRows[index].DataBoundItem as Terminal;
                        _bllTerminal.Delete(data.Id);
                    }
                    GetTerminalList();
                    MessageBox.Show("删除成功！");
                }
            }
        }

      
        private void btTimeSettingOK_Click(object sender, EventArgs e)
        {
            foreach (var terminal in _terminals)
            {
                _order.TimeSetting(terminal .Name ,terminal.PhoneNo, Year.Text, Mouth.Text, Day.Text, Hour.Text, Minute.Text, Second.Text);
            }
        }

     

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择一条记录！");
            }
            else
            {
                var model = dataGridView1.SelectedRows[0].DataBoundItem  as Terminal;
                new TerminalAdd(model).ShowDialog();
                GetTerminalList();
            }
        }
       
    }
}
