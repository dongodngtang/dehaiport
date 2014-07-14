using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FormUI.OperationLayer;
using Infrastructure;
using TomorrowSoft.BLL;
using TomorrowSoft.Model;

namespace FormUI
{
    public partial class OnDemandForm : Form
    {
        private OrderDefinition _order = new OrderDefinition();
        private TerminalService _service = new TerminalService();
        
        public OnDemandForm()
        {
            InitializeComponent();
            txtTime.KeyPress += Handler.PhoneNumber;
            txtTime1.KeyPress += Handler.PhoneNumber;
            txtTime3.KeyPress += Handler.PhoneNumber;
        }
        private void GetTerminalList()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = _service.GetModelList("");
            dgvPlayOne.DataSource = bs;
            dgvPlayGroup.DataSource = ControlHelpers.DataGridViewCellSetNull(dgvPlayOne);

        }
        private void OnDemandForm_Load(object sender, EventArgs e)
        {
            this.cbPlyeStyle.DataSource = _order.PlayStyle;
            cbPlyeStyle.SelectedIndex = 0;
            this.cbPlayStyle1.DataSource = _order.PlayStyle;
            cbPlayStyle1.SelectedIndex = 0;
            this.cbPlayStyle2.DataSource = _order.PlayStyle;
            cbPlayStyle2.SelectedIndex = 0;
            List<string> musicList = new List<string>();
            for (int i = 0; i <=9;i++)
            {
                musicList.Add(i.ToString());
            }
            this.cbMusicList.DataSource = musicList;
            this.cbMusicList1.DataSource = musicList;
            this.cbMusicList2.DataSource = musicList;
            dgvPlayOne.AutoGenerateColumns = false;
            dgvPlayGroup.AutoGenerateColumns = false;
            GetTerminalList();
            new ControlHelpers().FormChange(this);
        }

        private void btLinkOne_Click(object sender, EventArgs e)
        {
//            foreach (DataGridViewRow row in dgvPlayOne.Rows)
//            {
//                if (row.Cells["dgvCheck"].Value == dgvCheck.TrueValue)
//                {
//                    var term = row.DataBoundItem as Terminal;
//                    if (term != null)
//                    {
//
//                        _order.PlayMusic(term.PhoneNo, cbPlyeStyle.SelectedIndex.ToString(),
//                                         cbMusicList.SelectedText, txtTime.Text);
//                    }
//                }     
//            }

            if (dgvPlayOne.SelectedRows.Count == 0)
            {
                MessageBox.Show("请至少选择一行！");
            }
            else
            {
                if (MessageBox.Show(string.Format(@"您确定选中 {0}个终端吗？", dgvPlayOne.SelectedRows.Count),
                                    "提示",
                                    MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Question) == DialogResult.OK)
                {
                    for (int index = 0; index < dgvPlayOne.SelectedRows.Count; index++)
                    {
                        try
                        {
                            var terminal = dgvPlayOne.SelectedRows[index].DataBoundItem as Terminal;
                            if (terminal != null)
                            {

                                _order.PlayMusic(terminal .Name ,terminal.PhoneNo, cbPlyeStyle.SelectedIndex.ToString(),
                                                 cbMusicList.SelectedItem.ToString(), txtTime.Text);
                            }
                            MessageBox.Show("命令已发送！");
                        }
                        catch
                        {
                            MessageBox.Show("命令失败！");
                        }
                       
                        
                    }
                }
            }
        }

        private void btGroupPlayOK_Click(object sender, EventArgs e)
        {
            
            if (dgvPlayGroup.SelectedRows.Count == 0)
            {
                MessageBox.Show("请至少选择一行！");
            }
            else
            {
                if (MessageBox.Show(string.Format(@"您确定选中 {0} 个组吗？", dgvPlayGroup.SelectedRows.Count),
                                    "提示",
                                    MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        for (int index = 0; index < dgvPlayGroup.SelectedRows.Count; index++)
                        {
                            var terminal = dgvPlayGroup.SelectedRows[index].DataBoundItem as Terminal;
                            if (terminal != null)
                            {

                                _order.PlayMusic(terminal.Grouping ,terminal.GroupPhone, cbPlyeStyle.SelectedIndex.ToString(),
                                                 cbMusicList.SelectedItem.ToString(), txtTime.Text);
                            }

                        }
                        MessageBox.Show("命令已发送！");
                    }
                    catch
                    {
                        MessageBox.Show("命令失败！");
                    }
                 
                }
            }
        }

        private void btPlayAllOK_Click(object sender, EventArgs e)
        {
            var terminal = dgvPlayOne.SelectedRows[2].DataBoundItem as Terminal;
            if (terminal.AllPhone != null && 
                MessageBox.Show(string.Format(@"您确定要齐播 {0} 吗？", terminal .AllPhone),
                                                              "提示",
                                                              MessageBoxButtons.OKCancel,
                                                              MessageBoxIcon.Question) == DialogResult.OK)
            {
                _order.PlayMusic("群播",terminal.AllPhone, cbPlyeStyle.SelectedIndex.ToString(),
                                                cbMusicList.SelectedItem.ToString(), txtTime.Text);
            }
        }
    }
}
