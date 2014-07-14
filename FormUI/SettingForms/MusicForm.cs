using System;
using System.Windows.Forms;
using FormUI.OperationLayer;

namespace FormUI.SettingForms
{
    public partial class MusicForm : Form
    {
        public string Music { get; set; }
        public string Style { get; set; }
        public string Time { get; set; }

        public MusicForm()
        {
            InitializeComponent();
        }



        private void btLinkOne_Click(object sender, EventArgs e)
        {


            Music = cbMusicList.Text;
            Style = cbPlayStyle.SelectedIndex .ToString( );
            Time = txtTime.Text;
            this.DialogResult = DialogResult.OK;

        }


        private void MusicForm_Load(object sender, EventArgs e)
        {
            OrderDefinition.SetMusicNo(cbMusicList);
            if (cbMusicList.Text == string.Empty)
            {
                cbMusicList.Text = MusicNo.语音0 .ToString("D");
            }
            OrderDefinition.SetPlayStyle(cbPlayStyle);
            if (cbPlayStyle.Text == string.Empty)
            {
                cbPlayStyle.Text = PlayStyle.单曲循环.ToString();
            }
        }
    }
}