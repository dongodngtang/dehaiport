using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FormUI.OperationLayer;
using FormUI.Properties;
using Infrastructure;
using TomorrowSoft.BLL;
using TomorrowSoft.Model;

namespace FormUI.SettingForms
{
    public partial class AutoPlayer : Form
    {
        private string _terminalName = string.Empty;
        private string _phone = string.Empty;
       public AutoPlayer()
        {
            InitializeComponent();
            groupBox2.Enabled = false;
        }
        public AutoPlayer(string name,string phone)
        {
            InitializeComponent();
            _terminalName = name;
            _phone = phone;
            txtPlayTimes.KeyPress += Handler.Nuber09;
        }

        private GroupMemoryPlayService _service = new GroupMemoryPlayService();
        private void AutoPlayer_Load(object sender, EventArgs e)
        {
            OrderDefinition.SetMusicNo(cmbMusic);
            cmbMusic.SelectedIndex = 0;
            new ControlHelpers().FormChange(this);
            OrderDefinition.SetPlayStyle(cmbStyle);
            cmbStyle.SelectedIndex = 0;
            GetGroups();
        }
        private void GetGroups()
        {
            dgvGroup.DataSource = _service.GetGroupList().Tables[0];
        }
        private void dgvGroup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvMenbers.AutoGenerateColumns = false;
            if (dgvGroup.SelectedRows.Count == 0) return;
            dgvMenbers.DataSource = _service.GetModelList("GroupName = '" + dgvGroup.SelectedRows[0].Cells[0].Value+"'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (AddMenber())
           {
               MessageBox.Show("添加成功！");
               Settings.Default.Save();
               GetGroups();
           }
           else
           {
               MessageBox.Show("添加失败！");
           }
        }

        private bool AddMenber()
        {
            double delayMinute = 0;
            if (!string.IsNullOrEmpty(txtDelay.Text))
            {
                delayMinute = Convert.ToDouble(txtDelay.Text);
            }
          return   _service.Add(new GroupMemoryPlay()
                {
                    GroupName = txtGroupName.Text,
                    TerminalName = _terminalName,
                    TerminalNo = _phone,
                    PlayDelay = delayMinute,
                    PlayTimes = 0,
                    Music = cmbMusic .Text ,
                    PlayStyle = cmbStyle.SelectedIndex.ToString() ,
                    PlayMinute = txtPlayTimes .Text 
                });

        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (dgvGroup.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择一条记录！");
            }
            else
            {
                if (MessageBox.Show(string.Format("您确定要删除{0}记录?", dgvGroup.SelectedRows.Count), "提示",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    for (int i = 0; i < dgvGroup.SelectedRows.Count; i++)
                    {
                        _service.DeleteGroup(dgvGroup.SelectedRows[i].Cells[0].Value.ToString());
                    }
                    MessageBox.Show("删除成功！");
                    GetGroups();
                }
            }
        }

        private void btExecute_Click(object sender, EventArgs e)
        {
            AlarmClock.GroupName = dgvGroup.SelectedRows[0].Cells[0].Value.ToString();
            AlarmClock.PlayTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            MessageBox.Show("正在执行");
        }
    }
}
