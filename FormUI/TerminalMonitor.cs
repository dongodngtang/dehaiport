using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BLL;
using FormUI.Filters;
using FormUI.ManagerForms;
using FormUI.OperationLayer;
using FormUI.Properties;
using FormUI.SettingForms;
using TomorrowSoft.BLL;
using TomorrowSoft.Model;

namespace FormUI
{
    public partial  class TerminalMonitor : Form
    {
        public  delegate void Listener( string phone,string context);
        public delegate void MyEvent(object sender, FilterEventArgs e);
        private readonly OrderDefinition _order = new OrderDefinition();
        private readonly TerminalService _service = new TerminalService();
        private readonly AlarmClock _alarm = AlarmClock.Instance;
        private readonly AT cmd = new AT();
        private readonly Port port = Port.Instance;
        private Printer _printer = new Printer();
        private double dou = 0.05;

        public TerminalMonitor()
        {
           InitializeComponent();
           //port.Owner = this;
        
        }

        public event MyEvent NewPhone;
        public static event Listener ListBox1Listener;
   
       public void OnListBox1Listener(string phone,string context)
        {
            if (phone != string.Empty)
            {
                ListBox1Listener(phone ,context);
            }

        }

    
        private void SendMesShow( string phone, string context)
        {   
            ControlListboxAmount();
            listBox1.Items.Add(new Item("发送至：" + phone, context));
        }
        /// <summary>
        /// ListBox中显示的记录的条数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ControlListboxAmount()
        {
            if (listBox1.Items.Count > 6)
            {
                listBox1.Items.RemoveAt(0);
            }
          
        }
        /// <summary>
        /// 来信提示
        /// </summary>
        /// <param name="filter"></param>
        public void Popup(Filter filter)
        {
            if (filter.Phone != string.Empty)
            {
                NewPhone(this, new FilterEventArgs(filter));
            }
        }
        /// <summary>
        /// 刷新ListView中的终端
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshListBox(object sender, FilterEventArgs e)
        {
            string str = e.Filter.Phone;
            
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].ToolTipText == e.Filter.Phone)
                {
                    if (e.Filter.Context.Contains("本终端"))
                    {
                        _order.TimeSet(e.Filter.Name, e.Filter.Phone,
                                       DateTime.Now.ToString("yyyyMMddHHmmss").Substring(2));
                    }
                    if (e.Filter.Context.Contains("本地喊话")|| e.Filter.Context.Contains("播放"))
                       
                    {
                        listView1.Items[i].ImageKey = TerminalState.Green.ToString();
                    }

                    if (e.Filter.Context.Contains("OK"))
                    {
                        listView1.Items[i].ImageKey = TerminalState.Running.ToString();
                    }
                    if (e.Filter.Context.Contains("已停播")||e.Filter .Context .Contains( "error"))
                    {
                        listView1.Items[i].ImageKey = TerminalState.Stoped.ToString();
                    }
                    if (e.Filter.Context.Contains("告警"))
                    {
                        listView1.Items[i].ImageKey = TerminalState.Red.ToString();
                    }
                    if (e.Filter.IsQsDown)
                    {
                        listView1.Items[i].ImageKey = TerminalState.Red.ToString();
                    }
                    str = listView1.Items[i].Text;
                    break;
                }
            }
            ControlListboxAmount();
            listBox1.Items.Add(new Item(e.Filter.Name + "于：" + str, e.Filter.Context, e.Filter.Time));
           
        }

        private void TerminalMonitor_Load(object sender, EventArgs e)
        {
//            Opacity = 0;
            port.Owner = this;
            
            timer1.Start();
            try
            {
                port.SetPortName(Settings.Default.PortName)
                    .SetBaudRate(Settings.Default.BaudRate)
                    .SetDataBit(Settings.Default.DataBits)
                    .SetParity(Settings.Default.Parity)
                    .SetStopBit(Settings.Default.StopBit);
                if (port.Open())
                {
                    cmd.MessageHint();
                    GetAllMessage();
                }
                else
                {
                    var portForm = new PortForm();
                    if (portForm.ShowDialog() == DialogResult.OK && port.Open())
                    {
                        portForm.Close();
                    }
                }
                ChangeState();
                DeleteReadMsg();
            }
            catch (Exception ex)
            {
            }

            if (LoginForm.Level == "管理员")
            {
                口令管理ToolStripMenuItem.Enabled = true;
            }
            new ControlHelpers().FormChange(this);

            LoadTerminals();
            NewPhone += RefreshListBox;
            ListBox1Listener += SendMesShow;
            timer1.Interval = 5000;
            timer1.Enabled = true;
            WindowState = FormWindowState.Maximized;
        }

        private void DeleteReadMsg()
        {
            var mesIndex = new MessageIndexService().GetAll();
            if (mesIndex.Rows.Count <= 0) return;
            for (int i = 0; i < mesIndex.Rows.Count; i++)
            {
                cmd.DeleteMes(mesIndex.Rows [i]["MessageIndex"].ToString());
            }
            MessageBox.Show(string.Format("后台接收{0}条短信", mesIndex.Rows.Count));
            new MessageIndexService().Delete();
        }

        /// <summary>
        /// 加载软件是获取未开机的短信
        /// </summary>
        private void GetAllMessage()
        {
           cmd.GetAllMessage();
        }


        private void ChangeState()
        {
        
           
            if (port.IsOpen && port.Received)
            {
                try
                {
                    cmd.SendAt();
                }
                catch
                {
                    
                }
                lbPortState.Text = port.SerialPort.PortName;
                lbPortState.ForeColor = Color.Green;
            }
            else
            {
                lbPortState.Text = "COM";
                lbPortState.ForeColor = Color.Red;
            }
        }


        private void LoadTerminals()
        {
            listView1.LargeImageList = imageList;
            listView1.Clear();
            List<Terminal> terminals = _service.GetModelList(string.Empty);
            foreach (Terminal terminal in terminals)
            {
                var group = new ListViewGroup(terminal.GroupPhone, terminal.Grouping);
                bool contants = false;
                foreach (ListViewGroup g in listView1.Groups)
                {
                    if (g.Name == terminal.GroupPhone)
                    {
                        group = g;
                        contants = true;
                        break;
                    }
                }
                if (!contants)
                    listView1.Groups.Add(group);
                var item = new ListViewItem(terminal.Name, TerminalState.Stoped.ToString(), group)
                    {
                        ToolTipText = terminal.PhoneNo
                    };

                listView1.Items.Add(item);
            }
        }

        private IList<ListViewItem> GetSelectedPhone()
        {
            var items = new List<ListViewItem>();
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Tag != null)
                {
                    items.Add(item);
                }
            }
            if (items.Count < 1)
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    items.Add(item);
                }
            }
            return items;
        }


        private void btQuery_Click(object sender, EventArgs e)
        {
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox1().ShowDialog();
        }

        private void 串口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PortForm().ShowDialog();
            ChangeState();
        }

        private void 打印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Printer.PrintSetup();
        }

        private void 白名单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new WhiteListForm().Show();
        }


        private void 告警ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MusicTimeSetting().Show();
        }

        private void 终端ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TerminalForm().ShowDialog();
            listView1.Clear();
            LoadTerminals();
        }

        private void 口令管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UserFrm().ShowDialog();
        }

        private void 历史查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HistoryForm().ShowDialog();
        }

        private void 状态查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConditionForm().ShowDialog();
        }

        private void terminalCall_Click(object sender, EventArgs e)
        {
            IList<ListViewItem> items = GetSelectedPhone();
            if (items.Count != 1)
            {
                MessageBox.Show("暂不支持会议通话");
                return;
            }
            if (items[0].ToolTipText == string.Empty)
            {
                MessageBox.Show("该终端号码为空");
            }
            try
            {
                cmd.CallUp(items[0].ToolTipText);
                listBox1.Items.Add(new Item("拨号至：" + listView1.FocusedItem.Text, null));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void terminialHungUp_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.HangUp();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btTest_Click(object sender, EventArgs e)
        {
            IList<ListViewItem> items = GetSelectedPhone();
            if (MessageBox.Show(string.Format(@"确定发送至选中的{0}个终端？", items.Count), "提示",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    foreach (ListViewItem item in items)
                    {
                       _order.ConditionQuery(item .Text ,item.ToolTipText);
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btTestMusic_Click(object sender, EventArgs e)
        {
            IList<ListViewItem> items = GetSelectedPhone();
            if (MessageBox.Show(string.Format(@"确定发送至选中的{0}个终端？", items.Count),
                                "提示",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    foreach (ListViewItem item in items)
                    {
                        string content = _order.PlayMusic(item .Text ,item.ToolTipText, "1",
                                                          "6",
                                                          (Settings.Default.Ceshi == string.Empty
                                                               ? "3"
                                                               : Settings.Default.Ceshi).PadLeft(2,
                                                                                                 Convert.ToChar("0")));
                       
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void 状态ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = listView1.FocusedItem;
            try
            {
                _order.Detection(item.Text, item.ToolTipText);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 音量ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var volumeSettingForm = new VolumeSetting();
            if (volumeSettingForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _order.VolumeSetting(listView1.FocusedItem.Text, listView1.FocusedItem.ToolTipText, volumeSettingForm.Volume);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void 电压ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var batterySetting = new BattryParatemerSetting();
            if (batterySetting.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _order.ParameterSetting(listView1.FocusedItem.Text ,listView1.FocusedItem.ToolTipText, batterySetting.InMax,
                                                             batterySetting.InMin, batterySetting.OutMax,
                                                             batterySetting.OutMin);
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btFloodWarn_Click(object sender, EventArgs e)
        {
          
            IList<ListViewItem> items = GetSelectedPhone();
            if (MessageBox.Show(string.Format(@"确定发送至选中的{0}个终端？", items.Count),
                                "提示",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    foreach (ListViewItem item in items)
                    {
                        string content = _order.PlayMusic(item .Text ,item.ToolTipText, "1",
                                                          "3",
                                                          (Settings.Default.Ceshi == string.Empty
                                                               ? "3"
                                                               : Settings.Default.Xiehong).PadLeft(2,
                                                                                                   Convert.ToChar("0")));
     
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btSlaggWarn_Click(object sender, EventArgs e)
        {
            IList<ListViewItem> items = GetSelectedPhone();
            if (MessageBox.Show(string.Format(@"确定发送至选中的{0}个终端？", items.Count),
                                "提示",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    foreach (ListViewItem item in items)
                    {
                        string content = _order.PlayMusic(item.Text,item.ToolTipText, "1",
                                                          "4",
                                                          (Settings.Default.Ceshi == string.Empty
                                                               ? "3"
                                                               : Settings.Default.Paizha).PadLeft(2,
                                                                                                  Convert.ToChar("0")));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btPowerAlert_Click(object sender, EventArgs e)
        {
            IList<ListViewItem> items = GetSelectedPhone();
            if (MessageBox.Show(string.Format(@"确定发送至选中的{0}个终端？", items.Count),
                                "提示",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    foreach (ListViewItem item in items)
                    {
                       _order.PlayMusic(item .Text ,item.ToolTipText, "1",
                                                          "5",
                                                          (Settings.Default.Ceshi == string.Empty
                                                               ? "3"
                                                               : Settings.Default.Fadian).PadLeft(2, Convert.ToChar("0")));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void 添加管理号码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var white = new WhiteForm("添加管理号码");
            white.ShowDialog();
            if (white.DialogResult == DialogResult.OK && white.Phone != string.Empty)
            {
                try
                {
                    string content = _order.AddManagerPhone(listView1 .FocusedItem .Text ,listView1.FocusedItem.ToolTipText, white.Phone);
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void 添加授权号码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var white = new WhiteForm("添加授权号码");
            white.ShowDialog();
            if (white.DialogResult == DialogResult.OK && white.Phone != string.Empty)
            {
                try
                {
                    _order.Authorization(listView1 .FocusedItem .Text ,listView1.FocusedItem.ToolTipText, white.Phone);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void 删除号码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var white = new WhiteForm("删除号码");
            white.ShowDialog();
            if (white.DialogResult == DialogResult.OK && white.Phone != string.Empty)
            {
                try
                {
                    _order.DeletePhone(listView1 .FocusedItem .Text ,listView1.FocusedItem.ToolTipText, white.Phone);
 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void 清空白名单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(@"清空白名单？"),
                                "提示",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    string content = _order.ClearPhone(listView1 .FocusedItem .Text ,listView1.FocusedItem.ToolTipText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string content = _order.PhoneCheck(listView1 .FocusedItem .Text ,listView1.FocusedItem.ToolTipText);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBox1.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                new PopupLayer((Item) listBox1.Items[index]).Show();
            }
        }


        private void btStopMusic_Click(object sender, EventArgs e)
        {
            IList<ListViewItem> items = GetSelectedPhone();
            if (MessageBox.Show(string.Format(@"确定选中的{0}个终端停播？", items.Count),
                                "提示",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Question) == DialogResult.OK)
            {
                foreach (ListViewItem item in items)
                {
                    _order.MusicStop(item .Text ,item.ToolTipText);
                }
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
//            Opacity += dou;
//            if (Opacity == 1)
//            {
//                timer1.Stop();
//                dou = -0.05;
//            }
            ChangeState();
        }

        private void btRainFull_Click(object sender, EventArgs e)
        {
            IList<ListViewItem> items = GetSelectedPhone();
            if (MessageBox.Show(string.Format(@"确定发送至选中的{0}个终端？", items.Count),
                                "提示",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                { 
//                    IList<string> phone = items.Select(item => item.ToolTipText).ToList();
                    new VoiceText(items).ShowDialog();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btWaterLevel_Click(object sender, EventArgs e)
        {
            new AutoPlayer().ShowDialog();
        }

      

        private void 定时开关机ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shutdown();
        }
        /// <summary>
        /// 启动定时开关机
        /// </summary>
        public static void Shutdown()
        {
            System.Diagnostics.Process.Start(@"AutoShutdownHelper\AutoShutdownHelper.exe");
        }
        public class FilterEventArgs : EventArgs
        {
            public FilterEventArgs(Filter filter)
            {
                Filter = filter;
            }

            public Filter Filter { get; private set; }
        }
       /// <summary>
       /// listbox中记录数据
       /// </summary>
        public class Item:EventArgs 
        {
            public Item(string title, string content)
            {
                Title = title;
                Content = content;
                Time = DateTime.Now;
            }

            public Item(string title, string content, DateTime time)
            {
                Title = title;
                Content = content;
                Time = time;
            }
            public Item(Item item)
            {
                Title = item.Title;
                Content = item .Content;
                Time = DateTime.Now;
            }
            public string Title { get; set; }

            public DateTime Time { get; set; }

            public string Content { get; set; }

            public override string ToString()
            {
                return Title;
            }
        }

        private enum TerminalState
        {
            Test,
            Running,
            Stoped,
            RunningChecked,
            StopedChecked,
            Red,
            RedChecked,
            Green,
            GreenChecked
        }

        #region 鼠标左右按键处理

        private void terminalList_MouseUp(object sender, MouseEventArgs e)
        {
            ListViewItem item = listView1.GetItemAt(e.X, e.Y);
            if (item == null)
            {
                listView1.ContextMenuStrip = null;
                return;
            }
            switch (e.Button)
            {
                case MouseButtons.Left:

                    if (item.Tag == null)
                    {
                        item.Tag = new object();
                        item.ImageKey += @"Checked";
                    }
                    else
                    {
                        item.Tag = null;
                        item.ImageKey = item.ImageKey.Replace("Checked", string.Empty);
                    }
                    break;
                case MouseButtons.Right:
                    listView1.ContextMenuStrip = contextMenu;
                    break;
                default:
                    break;
            }
        }

        #endregion

        private void 定时播放ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = listView1.FocusedItem;
            if (item.ToolTipText == string.Empty)
            {
                MessageBox.Show("终端号码为空！");
            }
            else
            {
                try
                {
                    new AutoStartUpOrEsc(item.ToolTipText,item .Text).ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void 设定延时广播ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AutoPlayer(listView1.FocusedItem.Text, listView1.FocusedItem.ToolTipText).ShowDialog();
        }

        private void btOpenCTerminal_Click(object sender, EventArgs e)
        {
            IList<ListViewItem> items = GetSelectedPhone();
            if (MessageBox.Show(string.Format(@"确定发送至选中的{0}个终端？", items.Count), "提示",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    foreach (ListViewItem item in items)
                    {
                        _order.Detection(item.Text, item.ToolTipText);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void 终端防盗加锁ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _order.Lock(listView1 .FocusedItem .Text ,listView1.FocusedItem.Text);
            MessageBox.Show(listView1.FocusedItem.Text + "：加锁");
        }

        private void 终端防盗解锁ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _order.UnLock(listView1 .FocusedItem .Text ,listView1.FocusedItem.Text);
            MessageBox.Show(listView1.FocusedItem.Text + "：解锁");
        }

        private void btAlarm_Click(object sender, EventArgs e)
        {
            IList<ListViewItem> items = GetSelectedPhone();
            new Alarm(items).Show();
        }
        /// <summary>
        /// listbox1中字体可控变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            string s = this.listBox1.Items[e.Index].ToString();
            if (s.Contains("收信"))
            {
                e.Graphics.DrawString(s, this.Font, Brushes.Green, e.Bounds);
            }
            else if (s.Contains("发送"))
            {
                e.Graphics.DrawString(s, this.Font, Brushes.Red, e.Bounds);
            }
            else
                e.Graphics.DrawString(s, this.Font, new SolidBrush(this.ForeColor), e.Bounds);

        }

        private void 定时查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PhotovoltaicAlarm().Show();
        }

        private void c型终端ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IList<ListViewItem> items = GetSelectedPhone();
            new OpenCTerminal(items).Show();
        }

       

      

     
    }
}