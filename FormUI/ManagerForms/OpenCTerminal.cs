using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FormUI.OperationLayer;
using Infrastructure;

namespace FormUI.ManagerForms
{
    public partial class OpenCTerminal : Form
    {

        private OrderDefinition _order;
        private IList< ListViewItem> Terminals;
        public OpenCTerminal(IList<ListViewItem> terminals)
        {

            InitializeComponent();
            _order = new OrderDefinition();
            Terminals  = terminals;
        }

        private void OpenCTerminal_Load(object sender, EventArgs e)
        {
            textBox1.KeyPress += Handler.PhoneNumber;
            textBox2.KeyPress += Handler.PhoneNumber;
            textBox3.KeyPress += Handler.PhoneNumber;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            foreach (var item in Terminals)
            {
                _order.OpenCTerminal( item.Text, item.ToolTipText,textBox1 .Text .Trim( ), textBox2.Text.Trim(), textBox3.Text.Trim());
            }
        }
    }
}
