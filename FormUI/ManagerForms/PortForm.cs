using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using BLL;
using FormUI.OperationLayer;
using FormUI.Properties;

namespace FormUI.ManagerForms
{
    public partial class PortForm : Form
    {
        private static SerialPortUtil comPort = SerialPortUtil.GetInstance();
        private static readonly Port _port = Port.Instance;
        private AT cmd = new AT();

        public PortForm()
        {
            InitializeComponent();
        }

        private void MainFrom_Load(object sender, EventArgs e)
        {
            LoadOptions();
            ChangeState(_port.IsOpen);
        }

        private void ChangeState(bool isOpen)
        {
           try
                {
                    cmd.SendAt();
                }
                catch
                {

                }
            if (isOpen && _port.Received )
            {
                btnOpenClose.Text = "关闭串口";
                lbConnectTip.Text = comPort.PortName + "已连接";
                lbConnectTip.ForeColor = Color.Green;
            }
            else
            {
                btnOpenClose.Text = "打开串口";
                btnOpenClose.DialogResult = DialogResult.OK;
                lbConnectTip.Text = comPort.PortName + "未连接";
                lbConnectTip.ForeColor = Color.Red;
            }
        }

        private void LoadOptions()
        {
            SerialPortUtil.SetPortNameValues(cbPortName);
            if (cbPortName.Items.Count == 0)
            {
                MessageBox.Show(Resources.NoPort, Resources.TipsTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            SerialPortUtil.SetBauRateValues(cbBaudRate);
            SerialPortUtil.SetDataBitsValues(cbDataBits);
            SerialPortUtil.SetParityValues(cbParity);
            SerialPortUtil.SetStopBitValues(cbStopBits);

            if (cbPortName.Text == string.Empty)
            {
               
                    if (Settings.Default.PortName == string.Empty)
                    {
                        try
                        {
                            cbPortName.SelectedIndex = 0;
                        }
                        catch
                        {
                            
                        }
                    }
                        
                    else
                        cbPortName.Text = Settings.Default.PortName;
              
                
            }

            if (cbBaudRate.Text == string.Empty)
                cbBaudRate.Text = SerialPortBaudRates.BaudRate_115200.ToString("D");

            if (cbDataBits.Text == string.Empty)
                cbDataBits.Text = SerialPortDatabits.EightBits.ToString("D");

            if (cbParity.Text == string.Empty)
                cbParity.Text = Parity.None.ToString();

            if (cbStopBits.Text == string.Empty)
                cbStopBits.Text = StopBits.One.ToString();
        }


 
        //在事件里输出接收的数据
        private void comPort_DataReceived(DataReceivedEventArgs e)
        {
            txtRecv.BeginInvoke(
                new MethodInvoker(() =>
                {
                    if (_port.HexMode)
                    {
                        txtRecv.AppendText(SerialPortUtil.ByteToHex(e.DataRecv)); //输出到主窗口文本控件   
                    }
                    else
                    {
                        txtRecv.AppendText(Encoding.Default.GetString(e.DataRecv)); //输出到主窗口文本控件 
                    }
                }
                    )
                );
        }
        private void btnOpenClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (_port.IsOpen)
                {
                    ClosePort();
                }
                else
                {
                    OpenPort();
                }
                ChangeState(_port.IsOpen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.TipsTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ClosePort()
        {
            _port.Close();
        }

        private void OpenPort()
        {
            _port.SetPortName(cbPortName.Text)
                 .SetBaudRate(cbBaudRate.Text)
                 .SetDataBit(cbDataBits.Text)
                 .SetParity(cbParity.Text)
                 .SetStopBit(cbStopBits.Text);
            Settings.Default.Save();
            if (_port.Open())
            {
                cmd.MessageHint();
                cmd.GetAllMessage();
                btnOpenClose.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("串口打开失败");
            }
            DeleteReadMsg();

        }
        private void DeleteReadMsg()
        {
            var mesIndex = new MessageIndexService().GetAll();
            if (mesIndex.Rows.Count <= 0) return;
            for (int i = 0; i < mesIndex.Rows.Count; i++)
            {
                cmd.DeleteMes(mesIndex.Rows[i]["MessageIndex"].ToString());
            }
            new MessageIndexService().Delete();
        }
     

    }
}