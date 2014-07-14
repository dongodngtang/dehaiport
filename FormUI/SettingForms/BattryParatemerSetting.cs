using System;
using System.Windows.Forms;

namespace FormUI.SettingForms
{
    public partial class BattryParatemerSetting : Form
    {

        public string InMax { get; set; }
        public string InMin { get; set; }
        public string OutMax { get; set; }
        public string OutMin { get; set; }

        public BattryParatemerSetting()
        {
            InitializeComponent();
        }

        private void btTabParamOK_Click(object sender, EventArgs e)
        {
            InMax = ChargeMax.Text;
            InMin = ChargeMin.Text;
            OutMax = DisChargeMax.Text;
            OutMin = DisChargeMin.Text;
            if (InMax == string.Empty || InMin == string.Empty || OutMax == string.Empty ||
                OutMin == string.Empty)
            {
                MessageBox.Show("请填写完整");
                return;
            }
            this.DialogResult = DialogResult.OK;
        }


    }
}
