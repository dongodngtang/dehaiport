using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using FormUI.OperationLayer;
using FormUI.Properties;
using Microsoft.Win32;
using TomorrowSoft.BLL;
using TomorrowSoft.Model;

namespace FormUI.SettingForms
{
    public partial class AutoStartUpOrEsc : Form
    {
        private readonly RegularPlayService _service = new RegularPlayService();
        private  string Phone = string .Empty;
        private string TerminalName = string.Empty;

        public AutoStartUpOrEsc(string phone,string name)
        {
            InitializeComponent();
            this.Phone = phone;
            TerminalName = name;
        }

        private void GetList()
        {
            dataGridView1.DataSource = _service.GetAllList().Tables[0];
        }

        private void AutoStartUpOrEsc_Load(object sender, EventArgs e)
        {
            OrderDefinition.SetMusicNo(cmbMusic);
            cmbMusic.SelectedIndex = 0;
            new ControlHelpers().FormChange(this);
            OrderDefinition.SetPlayStyle(cmbStyle);
            cmbStyle.SelectedIndex = 0;
            CheckboxlistInit();
            GetList();
            timer1.Enabled = true;

        }

        private void CheckboxlistInit()
        {
            IList<ContralDataModel> chblModel = new List<ContralDataModel>();
            chblModel.Add(new ContralDataModel(0, "星期日"));
            chblModel.Add(new ContralDataModel(1, "星期一"));
            chblModel.Add(new ContralDataModel(2, "星期二"));
            chblModel.Add(new ContralDataModel(3, "星期三"));
            chblModel.Add(new ContralDataModel(4, "星期四"));
            chblModel.Add(new ContralDataModel(5, "星期五"));
            chblModel.Add(new ContralDataModel(6, "星期六"));

            cblWeek.DataSource = chblModel; 
            cblWeek.DisplayMember = "Name";
            cblWeek.ValueMember = "Id";
        }


        private void btOk_Click(object sender, EventArgs e)
        {
            //"yyyy-MM-dd hh:mm:ss"
            if (GetRadioButtonText() != string.Empty&&txtPlayTimes .Text != string.Empty&&Phone != string .Empty)
            {
                _service.Add(new RegularPlay(dtpAlarmTime.Value.ToString("HH:mm:ss"), GetRadioButtonText(),
                                             cmbMusic.Text, cmbStyle.SelectedIndex.ToString(), 0,Phone,txtPlayTimes.Text .Trim(),TerminalName));
                MessageBox.Show("OK");
                GetList();
            }
            else
            {
                MessageBox.Show("定时类型或播放时间不能为空！");
            }


        }

        private void rbWeek_CheckedChanged(object sender, EventArgs e)
        {
            cblWeek.Visible = true;
        }

    
        private string GetRadioButtonText()
        {
            Control.ControlCollection cc = this.Controls.Find("groupBoxRadio", true)[0].Controls;
            foreach (Control c in cc)
            {
                if (c is RadioButton)
                {
                    RadioButton rbtn = (RadioButton) c;
                    if (rbtn.Checked)
                    {
                        if (rbtn.Text == "每月")
                        {
                            return rbtn.Text +"-" + nudMonth.Value;
                        }
                        if (rbtn.Text == "每天")
                        {
                            return rbtn.Text +"-"+ dtpAlarmTime.Value.ToString("HH:mm:ss")+"*";
                        }
                        if (rbtn.Text == "每周")
                        {
                            if (GetClbValue() == string.Empty)
                            {
                                MessageBox.Show("周不能为空！");
                            }
                            else
                            {
                                 return rbtn.Text + "-" + GetClbValue() ;
                            }
                           
                        }
                        if (rbtn.Text == "指定时间")
                        {
                            return rbtn.Text + "-" + dateTimePicker1.Value.ToString("yyyy/MM/dd");
                        }
                        break;
                    }
                }
            }
            return string.Empty;
        }

        private string GetClbValue()
        {
            string week = string.Empty;
            if (cblWeek.CheckedItems.Count != 0)
            {
                for (int i = 0; i < cblWeek.Items.Count; i++)
                {
                    if (cblWeek.GetItemChecked(i))
                    {
                        week += cblWeek.GetItemText(cblWeek .Items[i])+" ";
                    }

                }
            }
            return week;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                if (MessageBox.Show(string.Format(@"您确定要删除历史记录？"), "提示",
                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        _service.Delete(Convert.ToInt32(dataGridView1.SelectedRows[i].Cells[0].Value));
                    }
                    MessageBox.Show("删除成功！");
                    GetList();
                  
                }
            }
         
        }

        private void chbAutoRun_CheckedChanged(object sender, EventArgs e)
        {
            StartingRun();
            Settings.Default.Save();
        }
        private void StartingRun()
        {
            string strName = Application.ExecutablePath;
            string strnewName = strName.Substring(strName.LastIndexOf("\\") + 1);
            if (chbAutoRun.Checked)
            {
                chbAutoRun.Checked = true;
                if (!File.Exists(strName)) //指定文件是否存在  
                    return;
                RegistryKey Rkey =
                    Registry.LocalMachine.OpenSubKey(
                        "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (Rkey == null)
                    Rkey =
                        Registry.LocalMachine.CreateSubKey(
                            "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
                Rkey.SetValue(strnewName, strName); //修改注册表，使程序开机时自动执行。
                MessageBox.Show("程序设置完成，重新启动计算机后即可生效！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //修改注册表，使程序开机时不自动执行。  
                chbAutoRun.Checked = false;
                RegistryKey Rkey =
                    Registry.LocalMachine.CreateSubKey(
                        "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
                Rkey.DeleteValue(strnewName, false);
                MessageBox.Show("程序设置完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string timenow = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            lbSystemTime.Text = timenow;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

     

    }
}