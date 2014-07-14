using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FormUI.OperationLayer;

namespace FormUI.ManagerForms
{
    public partial class Alarm : Form
    {
        private IList<ListViewItem> Items;
        private OrderDefinition _order;
        public Alarm( IList<ListViewItem> items)
        {
            InitializeComponent();
            Items = items;
            _order = new OrderDefinition();
            
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(@"确定发送至选中的{0}个终端？", Items.Count),
                                "提示",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    foreach (var item in Items)
                    {
                        _order.Alarm(item .Text ,item.ToolTipText, txtＭinute.Text.Trim());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

       
    }
}
