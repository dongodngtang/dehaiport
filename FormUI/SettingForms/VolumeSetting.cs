using System;
using System.Windows.Forms;
using FormUI.OperationLayer;

namespace FormUI.SettingForms
{
    public partial class VolumeSetting : Form
    {
        public string Volume { get; set; }

        public VolumeSetting()
        {
            InitializeComponent();
            OrderDefinition.SetVoice(cbVol);
        }
        private void btVolumeSettingOK_Click(object sender, EventArgs e)
        {
            Volume = cbVol.Text;
            this.DialogResult = DialogResult.OK;

        }
    }
}
