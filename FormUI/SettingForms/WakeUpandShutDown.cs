using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FormUI.OperationLayer;
using Microsoft.Win32;

namespace FormUI.SettingForms
{
    public partial class WakeUpandShutDown : Form
    {
        public WakeUpandShutDown()
        {
            InitializeComponent();
        }

        private void chbAutoRun_CheckedChanged(object sender, EventArgs e)
        {
            StartingRun();
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

        //文本框只能输入数字
        private void text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <60)
            {
                e.Handled = true;
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (btnOK.Text == "开始")
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                txtHH.Enabled = false;
                txtmm.Enabled = false;
                txtss.Enabled = false;
                timer2.Enabled = true;
                btnOK.Text = "停止";

                string wakeUpTime = txtHH.Text.Trim() + ":" + txtmm.Text.Trim() + ":" + txtss.Text.Trim();
                new WakeUp().SetWaitForWakeUpTime(Convert.ToDateTime(wakeUpTime));
            }
            else
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                txtHH.Enabled = true;
                txtmm.Enabled = true;
                txtss.Enabled = true;
                timer2.Enabled = false;
                btnOK.Text = "开始";
            }
        }

        private void WakeUpandShutDown_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string timeNow = DateTime.Now.ToString();
            label7.Text = timeNow;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string hh = textBox1.Text;
            string mm = textBox2.Text;
            string ss = textBox3.Text;
            string thetime = string.Format("{0}:{1}:{2}", hh, mm, ss);
            if (DateTime.Now.ToString("HH:mm:ss").Equals(thetime))
            {
                Process.Start("shutdown -s -t 10");
            }
        }

       
    }
}
