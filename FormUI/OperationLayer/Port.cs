using System;
using System.Collections;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using BLL;
using FormUI.Attributes;
using FormUI.Filters;
using Infrastructure;
using TomorrowSoft.BLL;
using TomorrowSoft.Model;

namespace FormUI.OperationLayer
{
    [Aop]
    public class Port : AopObject
    {
        public TerminalMonitor Owner { get; set; }

        /// <summary>
        ///     十六进制模式
        /// </summary>
        public bool HexMode { get; set; }

        /// <summary>
        ///     接收事件是否有效
        ///     true表示有效
        /// </summary>
        public bool ReceiveEventEnabled { get; set; }

        /// <summary>
        /// 接收到回应
        /// </summary>
        public bool IsReceived { get; set; }

        private static volatile Port instance;

        private static readonly object syncRoot = new Object();
        /// <summary>
        /// 多线程单例模式，确保SerialPort只实例化一次
        /// </summary>
        /// <returns></returns>
        public static Port Instance
        {
            get
            {
                if (instance != null) return instance;
                lock (syncRoot)
                {
                    if (instance == null)
                        instance = new Port();
                }
                return instance;
            }
        }

       
        public SerialPort SerialPort { get; private set; }

        private Port()
        {
            ReceiveEventEnabled = true;
            SerialPort = new SerialPort();
        }

        public bool IsOpen
        {
            get { return SerialPort.IsOpen; }
        }

        [Operation]
        public Port Send(string at)
        {
            Thread.Sleep(150);
            SerialPort.WriteLine(at);
            Suspend();
            return this;
        }
        public bool Received { get; set; }
        /// <summary>
        /// 挂起线程，等待串口回应
        /// </summary>
        private void Suspend()
        {
            var i = 0;
            Received = true;
            while (!IsReceived)
            {
                Thread.Sleep(30);
                i++;
                if (i > 300)
                {
                Received = false;
                throw new Exception("发送超时，请检查串口设备"); 
                }
             
            }
            IsReceived = false;
        }

        [Operation]
        public Port SendNoWrap(string at)
        {
            Thread.Sleep(150);
            SerialPort.Write(at);
            return this;
        }

        [Operation]
        public Port SendNoResponse(string at)
        {
            SerialPort.WriteLine(at);
            return this;
        }

        [Operation]
        public Port Send(byte[] at)
        {
            Thread.Sleep(150);
            SerialPort.Write(at, 0, at.Length);
            Suspend();
            return this;
        }

        public bool Open()
        {
            if (SerialPort.IsOpen)
                SerialPort.Close();
            try
            {
                SerialPort.Open();
                SerialPort.NewLine = "\r\n";
                SerialPort.DataReceived += port_DataReceived;
                SerialPort.ErrorReceived += port_ErrorReceived;
            }
            catch
            {
            }
            return IsOpen;
        }

        public void Close()
        {
            SerialPort.Close();
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string strCollect = string.Empty; 
            var port = (SerialPort) sender;
            try
            {
                port.ReceivedBytesThreshold = port.ReadBufferSize;
                while (true)
                {
                    Thread.Sleep(100);
                    var message = port.ReadExisting();
                    if (string.Equals(message, string.Empty))
                    {
                        break;
                    }
                    else
                    {
                        strCollect += message;
                        Thread.Sleep(100);
                    }
                } 
//                var message = port.ReadExisting();
//                var content = message.Replace("\r", string.Empty)
//                                     .Split(new[] {"\n"}, StringSplitOptions.RemoveEmptyEntries);
                var content = strCollect.Replace("\r", string.Empty)
                                   .Split(new[] {"\n","OK"}, StringSplitOptions.RemoveEmptyEntries);
                ReadCardMes(content);
                if (!ReceiveEventEnabled)
                {
                    IsReceived = true;
                    return;
                }

                var t = new ThreadStart(() =>
                    {
                        var filter = new FilterProcessor(content).Run();
                        if (filter == null) return;
                        Owner.Invoke(new Action<Filter>(Owner.Popup), filter);
                    });
                new Thread(t).Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                port.ReceivedBytesThreshold = 1;
            }
        }

        private void ReadCardMes(string[] content)
        {
            
            for (int index = 0; index < content.Length; index ++)
            {
                if (!content[index].Contains("+CMGL:")) continue;
                MessageSave(content[index + 1]);
                var mesNo = content[index].Split(new[] {"+CMGL:",","}, StringSplitOptions.RemoveEmptyEntries);
                new MessageIndexService().Add(mesNo[0]);
              
            }
          

        }

        protected readonly WhiteListService White = new WhiteListService();
        protected readonly TerminalService Terminal = new TerminalService();

        private void MessageSave(string Content)
        {
            int current;
            int total;
            string identifier;
            bool isLongMessage;
            string phone;
            DateTime time;
            string content;
            AT.GetSmsContent(Content, out isLongMessage, out phone, out time, out content, out current, out total,
                             out identifier);
            if (phone.StartsWith("86"))
                phone = phone.Remove(0, 2);
            if (White.PhoneExists(phone) || Terminal.PhoneExists(phone))
            {

                if (isLongMessage)
                {
                    var service = new LongSmsService();
                    service.Add(new LongSms
                        {
                            Content = content,
                            Current = current,
                            Identifier = identifier,
                            Phone = phone,
                            Time = time,
                            Total = total
                        });

                    var longSmses = service.GetBy(phone, identifier, time);
                    if (longSmses.Count < total)
                        return;
                    content = string.Empty;
                    foreach (var sms in longSmses)
                    {
                        content += sms.Content;
                    }

                }
                if (content.Contains("光伏"))
                {
                    new ConditionService()
                        .Add(ConditionFilter.FilterCondition(phone, content));
                }
                else
                {
                    new HistoryRecordService().Add(new HistoryRecord()
                        {
                            Handler = Name,
                            PhoneNo = phone,
                            HandlerTime = DateTime.Now.ToLocalTime(),
                            Context = content
                        });

                }

            }
        }

        private string Name
        {
            get { return "收信"; }
        }

        private void port_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            if (!Instance.ReceiveEventEnabled) return;
            var port = (SerialPort) sender;
            var output = port.ReadExisting();
            MessageBox.Show(output, "AT指令错误");
        }

        #region Setter

        public Port SetPortName(string portName)
        {
            SerialPort.PortName = portName;
            return this;
        }
            
        public Port SetBaudRate(string baudRate)
        {
            SerialPort.BaudRate = Convert.ToInt32(baudRate);
            return this;
        }

        public Port SetDataBit(string dataBit)
        {
            SerialPort.DataBits = Convert.ToInt32(dataBit);
            return this;
        }

        public Port SetStopBit(string stopBit)
        {
            SerialPort.StopBits = Enum<StopBits>.Parse(stopBit);
            return this;
        }

        public Port SetParity(string parity)
        {
            SerialPort.Parity = Enum<Parity>.Parse(parity);
            return this;
        }

        #endregion
    }
}