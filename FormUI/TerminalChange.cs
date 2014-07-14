using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FormUI.SettingForms;

namespace FormUI
{
    public partial class TerminalChange : Form
    {
        public TerminalChange()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new TerminalForm().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AddAndDeleteTerminal().ShowDialog();
        }

    }
}
