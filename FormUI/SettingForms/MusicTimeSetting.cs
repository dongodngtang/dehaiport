using System;
using System.Windows.Forms;
using FormUI.Properties;

namespace FormUI.SettingForms
{
    public partial class MusicTimeSetting : Form
    {
        public MusicTimeSetting()
        {
            InitializeComponent();
            for (int i = 0; i < 100; i++)
            {
                comboBox1.Items.Add(i);
                comboBox2.Items.Add(i);
                comboBox3.Items.Add(i);
                comboBox4.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();
            this.Close();
        }
    }
}
