using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FormUI.OperationLayer;
using TomorrowSoft.BLL;
using TomorrowSoft.Model;

namespace FormUI.SettingForms
{
    public partial class SpeakForm : Form
    {
        private TerminalService _service = new TerminalService();
        private AT com = new AT();

        public SpeakForm()
        {
            InitializeComponent();
        }

        private void GetTerminalList()
        {
            BindingSource bs = new BindingSource();
            List<Terminal> lists = _service.GetModelList("");
            bs.DataSource = lists;
            dgvPlayOne.DataSource = bs;
        
            dgvPlayGroup.DataSource = ControlHelpers.DataGridViewCellSetNull(dgvPlayOne);
            bindingNavigator1.BindingSource = bs;

        }

        private void SpeakForm_Load(object sender, EventArgs e)
        {
            dgvPlayOne.AutoGenerateColumns = false;
            dgvPlayGroup.AutoGenerateColumns = false;
            GetTerminalList();
             new ControlHelpers().FormChange(this);
        }

        private void btLinkOne_Click(object sender, EventArgs e)
        {
            if (dgvPlayOne.SelectedRows.Count == 1)
            {
                if (MessageBox.Show(string.Format(@"您确定单喊{0}？", dgvPlayOne.SelectedRows[0].Cells["PhoneNo"].Value),
                                    "提示",
                                    MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Question) == DialogResult.OK)
                {
                    for (int index = 0; index < dgvPlayOne.SelectedRows.Count; index++)
                    {
                        var terminal = dgvPlayOne.SelectedRows[index].DataBoundItem as Terminal;
                        if (terminal != null)
                        {
                            com.CallUp(terminal.PhoneNo);
                        }
                        else
                        {
                            MessageBox.Show("终端号码为空！请重新选择。");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("您的操作有误，单播只能选择一个号吗或您没选择一行！");
            }
           
            
        }

        private void btLinkGroup_Click(object sender, EventArgs e)
        {
           
            if (dgvPlayOne.SelectedRows.Count == 1)
            {
                if (MessageBox.Show(string.Format(@"您确定要组喊{0}?", dgvPlayGroup.SelectedRows[0].Cells["GroupPhone0"].Value),
                                    "提示",
                                    MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Question) == DialogResult.OK)
                {
                    for (int index = 0; index < dgvPlayOne.SelectedRows.Count; index++)
                    {
                        var terminal = dgvPlayOne.SelectedRows[index].DataBoundItem as Terminal;
                        if (terminal != null)
                        {
                            com.CallUp(terminal.GroupPhone);
                        }
                        else
                        {
                            MessageBox.Show("组播号码为空！");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("您的操作有误，组播只能选择一个号吗或您没选择一行！");

            }
        }

        private void btLinkAll_Click(object sender, EventArgs e)
        {
            var terminal = dgvPlayOne.Rows[2].DataBoundItem as Terminal;
            if (terminal != null && MessageBox.Show(string.Format(@"您确定要齐播{0}?", terminal.AllPhone),
                                                    "提示",
                                                    MessageBoxButtons.OKCancel,
                                                    MessageBoxIcon.Question) == DialogResult.OK)
            {
                com.CallUp(terminal.AllPhone);
            }
          
        }
    }
}
