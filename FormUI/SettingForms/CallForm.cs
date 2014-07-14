using System;
using System.Windows.Forms;
using FormUI.OperationLayer;
using Infrastructure;

namespace FormUI.SettingForms
{
    public partial class CallForm : Form
    {
        private AT comAT = new AT();
        public CallForm()
        {
            InitializeComponent();
            txResult.KeyPress += Handler.PhoneNumber;
        }

        private void btNumber0_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            txResult.Text += button.Text;
            txResult.SetFocus();
        }

        private void btDialingOk_Click(object sender, EventArgs e)
        {
            comAT.CallUp(txResult.Text);
        }

        private void btClearOne_Click(object sender, EventArgs e)
        {
            var length = txResult.TextLength;
            if(length > 0)
            {
               txResult.Text=txResult.Text.Remove(length-1);
            }
            txResult.SetFocus();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
