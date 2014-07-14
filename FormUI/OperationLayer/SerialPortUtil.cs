using System;
using System.Configuration;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FormUI.OperationLayer
{
    /// <summary>
    /// 串口开发辅助类
    /// </summary>
    public class SerialPortUtil
    {
        /// <summary>
        /// 接收事件是否有效 false表示有效
        /// </summary>
        public bool ReceiveEventFlag = false;
        /// <summary>
        /// 结束符比特
        /// </summary>
        public byte EndByte = 0x23;//string End = "#";

        /// <summary>
        /// 完整协议的记录处理事件
        /// </summary>
        public event DataReceivedEventHandler DataReceived;
        public event SerialErrorReceivedEventHandler Error;
        //public event SerialDataReceivedEventHandler DataRing;
        #region 变量属性
        private string _portName;//串口号，默认COM1
        private SerialPortBaudRates _baudRate = SerialPortBaudRates.BaudRate_115200;//波特率
        private Parity _parity = Parity.None;//校验位
        private StopBits _stopBits = StopBits.One;//停止位
        private SerialPortDatabits _dataBits = SerialPortDatabits.EightBits;//数据位

        private static SerialPortUtil _serialPortUtil;

        public SerialPort comPort = new SerialPort();

        /// <summary>
        /// 串口号
        /// </summary>
        public string PortName
        {
            get { return _portName; }
            set { _portName = value; comPort.PortName = _portName; }
        }

        /// <summary>
        /// 波特率
        /// </summary>
        public SerialPortBaudRates BaudRate
        {
            get { return _baudRate; }
            set { _baudRate = value; comPort.BaudRate = (int)_baudRate; }
        }

        /// <summary>
        /// 奇偶校验位
        /// </summary>
        public Parity Parity
        {
            get { return _parity; }
            set { _parity = value; comPort.Parity = _parity; }
        }

        /// <summary>
        /// 数据位
        /// </summary>
        public SerialPortDatabits DataBits
        {
            get { return _dataBits; }
            set { _dataBits = value; comPort.DataBits = (int)_dataBits; }
        }

        /// <summary>
        /// 停止位
        /// </summary>
        public StopBits StopBits
        {
            get { return _stopBits; }
            set { _stopBits = value; comPort.StopBits = _stopBits; }
        }

        #endregion

        #region 构造函数

        public SerialPortUtil(string name,SerialPortBaudRates baudRate)
        {
            _portName = name;
            _baudRate = baudRate;
            _parity = Parity.None;
            _dataBits = SerialPortDatabits.EightBits;
            _stopBits = StopBits.One;
            comPort.DataReceived += comPort_DataReceived;
            comPort.ErrorReceived += comPort_ErrorReceived;
            _serialPortUtil = this;
        }

        /// <summary>
        /// 参数构造函数（使用枚举参数构造）
        /// </summary>
        /// <param name="baud">波特率</param>
        /// <param name="par">奇偶校验位</param>
        /// <param name="sBits">停止位</param>
        /// <param name="dBits">数据位</param>
        /// <param name="name">串口号</param>
        public SerialPortUtil(string name, SerialPortBaudRates baud, Parity par, SerialPortDatabits dBits, StopBits sBits)
        {
            _portName = name;
            _baudRate = baud;
            _parity = par;
            _dataBits = dBits;
            _stopBits = sBits;

            comPort.DataReceived += new SerialDataReceivedEventHandler(comPort_DataReceived);
            comPort.ErrorReceived += new SerialErrorReceivedEventHandler(comPort_ErrorReceived);
        }

        /// <summary>
        /// 参数构造函数（使用字符串参数构造）
        /// </summary>
        /// <param name="baud">波特率</param>
        /// <param name="par">奇偶校验位</param>
        /// <param name="sBits">停止位</param>
        /// <param name="dBits">数据位</param>
        /// <param name="name">串口号</param>
        public SerialPortUtil(string name, string baud, string par, string dBits, string sBits)
        {
            _portName = name;
            _baudRate = (SerialPortBaudRates)Enum.Parse(typeof(SerialPortBaudRates), baud);
            _parity = (Parity)Enum.Parse(typeof(Parity), par);
            _dataBits = (SerialPortDatabits)Enum.Parse(typeof(SerialPortDatabits), dBits);
            _stopBits = (StopBits)Enum.Parse(typeof(StopBits), sBits);

            comPort.DataReceived += new SerialDataReceivedEventHandler(comPort_DataReceived);
            comPort.ErrorReceived += new SerialErrorReceivedEventHandler(comPort_ErrorReceived);
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public SerialPortUtil()
        {
            _parity = Parity.None;
            _dataBits = SerialPortDatabits.EightBits;
            _stopBits = StopBits.One;

            comPort.DataReceived += new SerialDataReceivedEventHandler(comPort_DataReceived);
            comPort.ErrorReceived += new SerialErrorReceivedEventHandler(comPort_ErrorReceived);
        } 

	    #endregion

        /// <summary>
        /// 端口是否已经打开
        /// </summary>
        public bool IsOpen
        {
            get
            {
                return comPort.IsOpen;
            }
        }

        /// <summary>
        /// 打开端口
        /// </summary>
        /// <returns></returns>
        public bool Open(string portName,string baudRate)
        {
            if (comPort.IsOpen) comPort.Close();

            comPort.PortName = _portName = portName;
            comPort.BaudRate = (int)(_baudRate = (SerialPortBaudRates)Enum.Parse(typeof(SerialPortBaudRates), baudRate));
            comPort.Parity = _parity;
            comPort.DataBits = (int)_dataBits;
            comPort.StopBits = _stopBits;

            try
            {
                comPort.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }

        /// <summary>
        /// 关闭端口
        /// </summary>
        public void Close()
        {
            if (comPort.IsOpen) comPort.Close();
        }

        /// <summary>
        /// 丢弃来自串行驱动程序的接收和发送缓冲区的数据
        /// </summary>
        public void DiscardBuffer()
        {
            comPort.DiscardInBuffer();
            comPort.DiscardOutBuffer();
        }

        /// <summary>
        /// 数据接收处理
        /// </summary>
        void comPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            ////禁止接收事件时直接退出
            //if (ReceiveEventFlag) return;

            //#region 根据结束字节来判断是否全部获取完成
            //List<byte> _byteData = new List<byte>();
            //bool found = false;//是否检测到结束符号
            //while (com.BytesToRead > 0 || !found)
            //{
            //    byte[] readBuffer = new byte[com.ReadBufferSize + 1];
            //    int count = com.Read(readBuffer, 0, com.ReadBufferSize);
            //    for (int i = 0; i < count; i++)
            //    {
            //        _byteData.Add(readBuffer[i]);

            //        if (readBuffer[i] == EndByte)
            //        {
            //            found = true;
            //        }
            //    }
            //}
            //#endregion

            ////字符转换
            //string readString = System.Text.Encoding.Default.GetString(_byteData.ToArray(), 0, _byteData.Count);

            
            ////触发整条记录的处理
            //if (DataReceived != null)
            //{
            //    DataReceived(new DataReceivedEventArgs(readString));
            //}


            //原协议不好 这边做工业处理 传出byte数组
            byte[] receviedBuf;
            receviedBuf = new byte[comPort.BytesToRead];

            int itemp = comPort.BytesToRead;
            int rcvByteLen = 0;
            try
            {
                for (int i = 0; i < itemp; i++)
                {
                    receviedBuf[i] = Convert.ToByte(comPort.ReadByte());
                    rcvByteLen++;
                }
                if (receviedBuf != null)
                {
                    DataReceived(new DataReceivedEventArgs(receviedBuf));
                }
            }
            catch (Exception ex)
            {
            	
            }
        }

        /// <summary>
        /// 错误处理函数
        /// </summary>
        void comPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            if (Error != null)
            {
                Error(sender, e);
            }
        }

        #region 数据写入操作

        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="msg"></param>
        public void WriteData(string msg)
        {
            try
            {
                comPort.Write(msg);
                Thread.Sleep(Convert.ToInt32(ConfigurationManager.AppSettings.Get("TimeOut"))); //用一个线程来延时100毫秒
            }
            catch (Exception ex)
            {
            	
            }
            
        }

        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="msg">写入端口的字节数组</param>
        public void WriteData(byte[] msg)
        {
            try
            {
                comPort.Write(msg, 0, msg.Length);
            }
            catch (Exception ex)
            {
            	
            }
            
        }

        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="msg">包含要写入端口的字节数组</param>
        /// <param name="offset">参数从0字节开始的字节偏移量</param>
        /// <param name="count">要写入的字节数</param>
        public void WriteData(byte[] msg, int offset, int count)
        {
            //if (!(com.IsOpen)) com.Open();
            try
            {
                comPort.Write(msg, offset, count);
            }
            catch (Exception ex)
            {
            	
            }
            
        }

        /// <summary>
        /// 发送串口命令
        /// </summary>
        /// <param name="SendData">发送数据</param>
        /// <param name="ReceiveData">接收数据</param>
        /// <param name="Overtime">重复次数</param>
        /// <returns></returns>
        public int SendCommand(byte[] SendData, ref  byte[] ReceiveData, int Overtime)
        {
            if (!(comPort.IsOpen)) comPort.Open();

            ReceiveEventFlag = true;        //关闭接收事件
            comPort.DiscardInBuffer();      //清空接收缓冲区                 
            comPort.Write(SendData, 0, SendData.Length);
            
            int num = 0, ret = 0;
            while (num++ < Overtime)
            {
                if (comPort.BytesToRead >= ReceiveData.Length) break;
                Thread.Sleep(1);
            }

            if (comPort.BytesToRead >= ReceiveData.Length)
            {
                ret = comPort.Read(ReceiveData, 0, ReceiveData.Length);
            }

            ReceiveEventFlag = false;       //打开事件
            return ret;
        }

        #endregion

        #region 常用的列表数据获取和绑定操作

        /// <summary>
        /// 封装获取串口号列表
        /// </summary>
        /// <returns></returns>
        public static string[] GetPortNames()
        {
            return SerialPort.GetPortNames();
        }

        /// <summary>
        /// 设置串口号
        /// </summary>
        /// <param name="obj"></param>
        public static void SetPortNameValues(ComboBox obj)
        {
            obj.Items.Clear();
            foreach (string str in SerialPort.GetPortNames())
            {
                obj.Items.Add(str);
            }
        }

        /// <summary>
        /// 设置波特率
        /// </summary>
        public static void SetBauRateValues(ComboBox obj)
        {
            obj.Items.Clear();
            foreach (SerialPortBaudRates rate in Enum.GetValues(typeof(SerialPortBaudRates)))
            {
                obj.Items.Add(((int)rate).ToString());
            }
        }

        /// <summary>
        /// 设置数据位
        /// </summary>
        public static void SetDataBitsValues(ComboBox obj)
        {
            obj.Items.Clear();
            foreach (SerialPortDatabits databit in Enum.GetValues(typeof(SerialPortDatabits)))
            {
                obj.Items.Add(((int)databit).ToString());
            }
        }

        /// <summary>
        /// 设置校验位列表
        /// </summary>
        public static  void SetParityValues(ComboBox obj)
        {
            obj.Items.Clear();
            foreach (string str in Enum.GetNames(typeof(Parity)))
            {
                obj.Items.Add(str);
            }
            //foreach (Parity party in Enum.GetValues(typeof(Parity)))
            //{
            //    obj.Items.Add(((int)party).ToString());
            //}
        }

        /// <summary>
        /// 设置停止位
        /// </summary>
        public static void SetStopBitValues(ComboBox obj)
        {
            obj.Items.Clear();
            foreach (string str in Enum.GetNames(typeof(StopBits)))
            {
                obj.Items.Add(str);
            }
        }

        #endregion

        #region 格式转换
        /// <summary>
        /// 转换十六进制字符串到字节数组
        /// </summary>
        /// <param name="msg">待转换字符串</param>
        /// <returns>字节数组</returns>
        public static byte[] HexToByte(string msg)
        {
            msg = msg.Replace(" ", "");//移除空格

            byte[] comBuffer = new byte[msg.Length / 2];
            for (int i = 0; i < msg.Length; i += 2)
            {
                comBuffer[i / 2] = (byte)Convert.ToByte(msg.Substring(i, 2), 16);
            }

            return comBuffer;
        }

        /// <summary>
        /// 转换字节数组到十六进制字符串
        /// </summary>
        /// <param name="comByte">待转换字节数组</param>
        /// <returns>十六进制字符串</returns>
        public static string ByteToHex(byte[] comByte)
        {
            ////StringBuilder builder = new StringBuilder(comByte.Length * 3);
            //string strRtn = "";
            //foreach (byte data in comByte)
            //{
            //    //builder.Append(Convert.ToString(data, 16).PadLeft(2, '0').PadRight(3, ' '));
            //    strRtn += Convert.ToString(data, 16) + " ";
            //}

            ////return builder.ToString().ToUpper();
            //return strRtn;
            string returnStr = "";
            if (comByte != null)
            {
                for (int i = 0; i < comByte.Length; i++)
                {
                    returnStr += comByte[i].ToString("X2")+" ";
                }
            }
            return returnStr;
        }
        #endregion

        /// <summary>
        /// 检查端口名称是否存在
        /// </summary>
        /// <param name="port_name"></param>
        /// <returns></returns>
        public static bool Exists(string port_name)
        {
            foreach (string port in SerialPort.GetPortNames()) if (port == port_name) return true;
            return false;
        }

        /// <summary>
        /// 格式化端口相关属性
        /// </summary>
        /// <param name="port"></param>
        /// <returns></returns>
        public static string Format(SerialPort port)
        {
            return String.Format("{0} ({1},{2},{3},{4},{5})",
                port.PortName, port.BaudRate, port.DataBits, port.Parity, port.StopBits, port.Handshake);
        }

        public static void SetPortNameValues(string portName)
        {
            throw new NotImplementedException();
        }

        public static SerialPortUtil GetInstance()
        {
            return _serialPortUtil ?? (_serialPortUtil=new SerialPortUtil());
        }
    }

    public class DataReceivedEventArgs : EventArgs
    {
        public string DataReceived;
        public byte[] DataRecv;
        public DataReceivedEventArgs(string m_DataReceived)
        {
            DataReceived = m_DataReceived;
        }
        public DataReceivedEventArgs(byte[] m_DataRecv)
        {
            DataRecv = m_DataRecv;
        }
    }

    public delegate void DataReceivedEventHandler(DataReceivedEventArgs e);

    public delegate void DataReceivedEventGet(DataReceivedEventArgs e);
    
    /// <summary>
    /// 串口数据位列表（5,6,7,8）
    /// </summary>
    public enum SerialPortDatabits : int
    {
        FiveBits = 5,
        SixBits = 6,
        SeventBits = 7,
        EightBits = 8
    }

    /// <summary>
    /// 串口波特率列表。
    /// 75,110,150,300,600,1200,2400,4800,9600,14400,19200,28800,38400,56000,57600,
    /// 115200,128000,230400,256000
    /// </summary>
    public enum SerialPortBaudRates : int
    {
        BaudRate_75 = 75,
        BaudRate_110 = 110,
        BaudRate_150 = 150,
        BaudRate_300 = 300,
        BaudRate_600 = 600,
        BaudRate_1200 = 1200,
        BaudRate_2400 = 2400,
        BaudRate_4800 = 4800,
        BaudRate_9600 = 9600,
        BaudRate_14400 = 14400,
        BaudRate_19200 = 19200,
        BaudRate_28800 = 28800,
        BaudRate_38400 = 38400,
        BaudRate_56000 = 56000,
        BaudRate_57600 = 57600,
        BaudRate_115200 = 115200,
        BaudRate_128000 = 128000,
        BaudRate_230400 = 230400,
        BaudRate_256000 = 256000
    }
}
