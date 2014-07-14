using System;
using System.Windows.Forms;
using Infrastructure;

namespace FormUI.ManagerForms
{
    public partial class WhiteForm : Form
    {
        public string Phone { get; set; }

        public WhiteForm(string title)
        {
            InitializeComponent();
            this.Text = title;
            textBox1.KeyPress += Handler.PhoneNumber;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Phone = textBox1.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
