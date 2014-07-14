using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormUI.SettingForms
{
    public partial class PopupLayer : Form
    {
        private readonly TerminalMonitor.Item _item;

        private Point point;
        public PopupLayer()
        {
            InitializeComponent();
            btnDone.DialogResult = DialogResult.OK;
        }

        public PopupLayer(TerminalMonitor.Item item):this()
        {
            _item = item;
            this.lbPopupContent.Text = item.Content;
            this.lbTitle.Text = item.Title;
            this.lbTime.Text = item.Time.ToString("yyyy/MM/dd HH:mm:ss");
           
        }


        private void PopupLayer_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void cbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;//停止timer2计时器，
            if (this.Opacity > 0 && this.Opacity <= 1)//开始执行弹出窗渐渐透明
            {
                this.Opacity = this.Opacity - 0.05;//透明频度0.05
            }
            if (MousePosition.X >= this.Location.X && MousePosition.Y >= this.Location.Y)//每次都判断鼠标是否是在弹出窗上，使用鼠标在屏幕上的坐标跟弹出窗体的屏幕坐标做比较。
            {
                timer2.Enabled = true;//如果鼠标在弹出窗上的时候，timer2开始工作
                timer1.Enabled = false;//timer1停止工作。
            }
            if (this.Opacity == 0)//当透明度==0的时候，关闭弹出窗以释放资源。
            {
                this.Close();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;//timer1停止工作
            this.Opacity = 1;//弹出窗透明度设置为1，完全不透明
            if (MousePosition.X < this.Location.X && MousePosition.Y < this.Location.Y)//如下
            {
                timer1.Enabled = true;
                timer2.Enabled = false;
            }
        }
        Point myPoint;
        private void PopupLayer_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                myPoint = Control.MousePosition;
                myPoint.Offset(myPoint.X, myPoint.Y);
                this.DesktopLocation = myPoint;
            }

        }

    }
}
