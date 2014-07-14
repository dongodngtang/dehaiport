using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using Infrastructure;
using TomorrowSoft.BLL;
using TomorrowSoft.Model;

namespace FormUI.OperationLayer
{

    public class AT
    {
        private readonly Port _port = Port.Instance;
        private HistoryRecordService _bllHistory = new HistoryRecordService();
        private HistoryRecord history = new HistoryRecord();
        #region 指令
        /// <summary>
        ///     检测 Module 与串口是否连通，能否接收 AT 命令
        /// </summary>
        private string TEST = "AT";

        /// <summary>
        ///     打开命令字符回显
        /// </summary>
        private string ECHO_ON = "ATE0";

        /// <summary>
        ///     设置DCE响应格式:发送长型 (字符型) 结果码
        /// </summary>
        private string CHAR_MODE = "ATV1";

        /// <summary>
        ///     使短信支持立即显示模式
        /// </summary>
        private string SMS_NEW_AT = "AT+CSMS=1";

        /// <summary>
        ///     短信不保存，直接发送到串口
        /// </summary>
        private string SMS_ALERT = "AT+CNMI=1,2";

        /// <summary>
        ///     短信格式：中文
        /// </summary>
        private string SMS_CH = "AT+CMGF=0";

        /// <summary>
        ///     短信格式：英文
        /// </summary>
        private string SMS_EN = "AT+CMGF=1";

        /// <summary>
        ///     接听电话
        /// </summary>
        private static string ANSWER = "ATA";

        /// <summary>
        ///     挂机
        /// </summary>
        private string HANG_UP = "ATH";

        /// <summary>
        ///     拨号
        /// </summary>
        private string CALL = "ATD{0};";

        /// <summary>
        ///     激活Clip,
        ///     来电返回来电的号码姓名等信息。
        /// </summary>
        private string CLIP_ON = "AT+CLIP=1";

        /// <summary>
        ///     发送短信至：{0}
        /// </summary>
        private string SMS = "AT+CMGS={0}";

        /// <summary>
        ///     获取指定索引的短信
        /// </summary>
        private string GET_SMS = "AT+CMGR={0}";

        /// <summary>
        ///     中文短信格式
        /// </summary>
        private string CHINESE_SMS_TEMP = "0011000D9168{0}0008A0{1}{2}";

        /// <summary>
        ///     短信结束符
        /// </summary>
        private byte[] END_OF_SMS = SerialPortUtil.HexToByte("1A");

        /// <summary>
        ///     手机号码结束补位
        /// </summary>
        private static string END_OF_PHONE = "F";

        /// <summary>
        /// 新信息确认应答
        /// </summary>
        private static string SMS_ANSWER = "AT+CNMA";

        private string SMCRAD_MESSAGE = "AT+CPMS="+"SM" + "," + "SM" + ","+"SM";
        #endregion

        public AT()
        {
            
        }
       
        private string Call(string phoneNo)
        {
            return string.Format(CALL, phoneNo);
        }

        /// <summary>
        ///     发送短信至
        /// </summary>
        /// <param name="phoneNo">目的手机号</param>
        /// <returns>指令</returns>
        private string SMSTo(string phoneNo)
        {
            return string.Format(SMS, string.Format("\"{0}\"", phoneNo));
        }

        private string GetSMS(string index)
        {
            return string.Format(GET_SMS, index);
        }

        /// <summary>
        ///     解析短信内容
        ///     08 91683108701305F1 20 10 A1 2125100816489333 00 08 31218122843223 04 6D4B8BD5       （中文）
        ///     08 91683108701305F1 20 10 A1 2125100816489333 00 00 31218122443323 08 31D98C56B3DD70 （英文）
        /// 
        ///     08：短信中心号码长度
        ///     91683108701305F1：  91：地址类型，国际格式号码（号码前加“+”）
        ///                         68：中国的国际区号，号码前加 +86
        ///                         3108200105F0：短信中心地址/号码，字节内反转，13800210500，F补齐长度为偶数。
        ///     20：PDU Type(区分长短信)http://www.cnblogs.com/Engin/archive/2010/11/02/GSM_PDU.html
        ///     10：目标地址数字个数共16 个十进制数
        ///     A1：目标地址格式
        ///     2125100816489333：目标地址号码，字节内反转，1252018873688664，F补齐长度为偶数。
        ///     00：协议标识(TP-PID) 是普通GSM 类型，点到点方式
        ///     08：用户信息编码方式(TP-DCS)(英文为00)
        ///     31218122443323：时间：09-11-27 13:18:06:23
        ///     04：短信内容长度(转换前)
        ///     6D4B8BD5：短信内容：一
        /// </summary>
        public static void GetSmsContent(string hex,out bool isLongMessage, out string phone, out DateTime time, out string content,out int current,out int total,out string identifier)
        {
            //前部分长度
            var head = 0;
            //短信中心号码长度
            var hex_smsc_length = 2;
            //PDU Type长度
            var hex_pdu_type_length = 2;
            //目标地址长度
            var hex_phone_length = 2;
            //目标地址格式长度
            var hex_phone_format_length = 2;
            //协议标识(TP-PID)长度
            var hex_pid = 2;
            //用户信息编码方式(TP-DCS)长度
            var hex_dcs = 2;
            //发送时间长度
            var hex_time_length = 14;
            //长短信标识头长度
            var hex_long_sms_protocol_head_length = 2;
            //短信内容长度
            var hex_content_length = 2;

            const int CHINESE_CODE = 8;
            const int ENGLISH_CODE = 0;

            current = 0;
            total = 0;
            identifier = string.Empty;
            var smsc_phone_length = Convert.ToInt32(hex.Substring(0, hex_smsc_length), 16)*2;
            head += hex_smsc_length;
            head += smsc_phone_length;

            isLongMessage = IsLongSms(hex.Substring(head,hex_pdu_type_length));

            head += hex_pdu_type_length;
            var phone_length = Convert.ToInt32(hex.Substring(head, hex_phone_length), 16);
            head += hex_phone_length;
            head += hex_phone_format_length;
            if (phone_length%2 != 0)
                phone_length += 1;
            var phoneHex = hex.Substring(head, phone_length);
            phone = PhoneDecoder(phoneHex);
            head += phone_length;
            head += hex_pid;
            var dcs = Convert.ToInt32(hex.Substring(head, hex_dcs),16);
            head += hex_dcs;
            time = HexToTime(hex.Substring(head, hex_time_length));
            head += hex_time_length;
            var content_length = Convert.ToInt32(hex.Substring(head, hex_content_length), 16);
            head += hex_content_length;
            if (isLongMessage)
            {
                var procotol_length = HexToDec(hex.Substring(head, hex_long_sms_protocol_head_length)) * 2;
                head += hex_long_sms_protocol_head_length;
                head += procotol_length;
                identifier = hex.Substring(head - 6, 2);
                total = Convert.ToInt32(hex.Substring(head - 4, 2));
                current = Convert.ToInt32(hex.Substring(head - 2, 2));
            }
            var hex_content = hex.Substring(head, hex.Length - head);
            switch (dcs)
            {
                case ENGLISH_CODE:
                    content = Gsm7bitDecoding(hex_content);
//                    content = PDU7bitDecoder(hex_content, content_length);
                    break;
                case CHINESE_CODE:
                    content = PDU8bitDecoder(hex_content);
                    break;
                default:
                    throw new ArgumentException("未知信息格式：" + dcs + ",内容："+hex_content);
                    break;
            }
        }

        /// <summary>
        /// 是否为长短信
        /// 当二进制八位的PDU类型第二位为1时，则为长短信（UDHI=1）
        /// 长短信是有规约的,协议头部分如果是0x40以下，则说明是普通短信，如果是0x40以上，
        /// 则是长短信，然后在短信内容部分，有六个字节分别定义短信唯一标识以及该短信是第几条，
        /// 所以长短信发送时每条实际为67个汉字。手机接收到之后，都会按照标准规约自动组合为一条短信，
        /// 而不是显示多条。
        /// </summary>
        /// <param name="pduType">PDU类型</param>
        /// <returns></returns>
        private static bool IsLongSms(string pduType)
        {
            var str1 = int.Parse(pduType, NumberStyles.HexNumber);
            var str2 = str1 & 0x40;

            return (int.Parse(pduType, NumberStyles.HexNumber) & 0x40)==0x40;

        }

        /// <summary>
        /// 7-bit解码
        /// </summary>
        /// <param name="textEncoded"></param>
        /// <returns></returns>
        public static string Gsm7bitDecoding(string textEncoded)
        {
            byte[] src = HexStringToBytes(textEncoded);
            if (src.Length == 0)
            {
                return string.Empty;
            }
            int srcLength = src.Length;
            int dstLength = srcLength*8/7;
            byte[] dst = new byte[dstLength];
            int a, b, k;
            for (a = 0, b = 0; b < srcLength; a++, b++)
            {
                k = a%8;
                if (a > 0)
                {
                    dst[a] = (byte) (((src[b] << k) & 0x7f) | (src[b - 1] >> 8 - k));
                }
                else
                {
                    dst[a] = (byte) (src[b] & 0x7f);
                }
                if (k == 7 && a > 0)
                {
                    dst[++a] = (byte) (src[b] & 0x7f);
                }
            }
            return Encoding.ASCII.GetString(dst);
        }

        static byte[] HexStringToBytes(string hexString)
        {
            int hexStringLength = hexString.Length;
            if (hexStringLength < 2 || hexStringLength%2 != 0)
            {
                return new byte[0];
            }
            byte[] data = new byte[hexStringLength/2];
            for (int i = 0, j = 0; i < hexStringLength; i += 2, j++)
            {
                data[j] = Byte.Parse(hexString.Substring(i, 2), NumberStyles.HexNumber);
            }
            return data;
        }

        /// <summary>
        /// 英文短信解析--
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public static string PDU7bitDecoder(string hex,int length)
        {
            var charArray = HexReverse(hex).ToCharArray();
            Array.Reverse(charArray);
            var binary = HexToBinary(new string(charArray));
            var result = string.Empty;
            var i = binary.Length;
            do
            {
                i -= 7;
                result += Encoding.ASCII.GetString(new[] { (byte)Convert.ToInt32(binary.Substring(i, 7), 2) });

            } while (i != result.Length);

            return result;
        }

     
        /// <summary>
        /// 十六进制转二进制
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        private static string HexToBinary(string hex)
        {
            var result = string.Empty;
            for (int i = 0; i < hex.Length; i++)
            {
                result += Convert.ToString(Convert.ToInt32(hex[i].ToString(), 16),2).PadLeft(4, '0');
            }
            return result;
        }
        /// <summary>
        /// 十六进制转十进制
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        private static int HexToDec(string hex)
        {
            return Convert.ToInt32(hex, 16);
        }

        private static DateTime HexToTime(string hex)
        {
            int year = Convert.ToInt32("20"+hex[1] + hex[0]);
            int month = Convert.ToInt32(hex[3] + hex[2].ToString());
            int day = Convert.ToInt32(hex[5] + hex[4].ToString());
            int hour = Convert.ToInt32(hex[7] + hex[6].ToString());
            int min = Convert.ToInt32(hex[9] + hex[8].ToString());
            int sec = Convert.ToInt32(hex[11] + hex[10].ToString());
            int millisecond = Convert.ToInt32(hex[13] + hex[12].ToString());
            return new DateTime(year, month, day, hour, min, sec, millisecond);
        }

        /// <summary>
        ///     中文短信长度初始化校验和
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        private string CheckSum(int length)
        {
            return string.Format(SMS, length);
        }

        /// <summary>
        ///     来短信提醒
        /// </summary>
        public void MessageHint()
        {
            _port.Send(ECHO_ON)
                .Send(CHAR_MODE)
                .Send(SMS_NEW_AT)
                .Send(SMS_ALERT)
                .Send(SMS_CH)
                .Send(CLIP_ON)
                .Send(SMCRAD_MESSAGE);
        }

        /// <summary>
        ///     电话拨打
        /// </summary>
        /// <param name="phoneNo"></param>
        public void CallUp(string phoneNo)
        {
            _port.SendNoResponse(Call(phoneNo));

            SaveHistoryRecord(phoneNo,"拨号", DateTime.Now.ToLocalTime(), null);
        }

        /// <summary>
        ///     电话接听
        /// </summary>
        public void CallAnswer()
        {
            _port.Send(ANSWER);
        }

        /// <summary>
        ///     电话挂机
        /// </summary>
        public void HangUp()
        {
            _port.Send(HANG_UP);
        }

        /// <summary>
        ///     发送英文短信
        /// </summary>
        /// <param name="phoneNo"></param>
        /// <param name="messageText"></param>
        public void SendEnglishMessage(string phoneNo, string messageText)
        {
            _port.Send(CHAR_MODE)
                .Send(SMS_EN)
                .Send(SMSTo(phoneNo))
                .Send(messageText)
                .Send(END_OF_SMS);

            SaveHistoryRecord(phoneNo, "发信",
                              DateTime.Now.ToLocalTime(),
                messageText);
        }

        /// <summary>
        ///     读取英文短信
        /// </summary>
        public void GetMessage(string index)
        {
            _port.Send("AT+CMGF=0");
           _port.Send(GetSMS(index));
        }

        /// <summary>
        ///     短信接收成功反馈
        /// </summary>
        public void SmsAnswer()
        {
            _port.Send(SMS_ANSWER);
        }

        /// <summary>
        ///     发送中文短信
        /// </summary>
        /// <param name="phoneNo"></param>
        /// <param name="context"></param>
        public void SendChineseMessage(string terminal,string phoneNo, string context)
        {
            try
            {
                var hex = PDU8bitEncoder(context);
                var length = (hex.Length/2).ToString("X2");

                string content = string.Format(CHINESE_SMS_TEMP,
                                               PhoneEncoder(phoneNo), length, hex);
                _port.Send(CHAR_MODE)
                     .Send(SMS_CH)
                     .Send(CheckSum(content.Length/2 - 1))
                     .SendNoWrap(content)
                     .Send(END_OF_SMS);
                SaveHistoryRecord(phoneNo, "发信", DateTime.Now.ToLocalTime(), context);
                new TerminalMonitor().OnListBox1Listener(terminal, context);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        ///     汉字转Unicode码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string PDU8bitEncoder(string str)
        {
            var result = string.Empty;
            var bytes = Encoding.Unicode.GetBytes(str);
            for (var i = 0; i < bytes.Length; i += 2)
            {
                result += bytes[i + 1].ToString("X2") + bytes[i].ToString("X2"); //前后翻转
            }
            return result;
        }

        /// <summary>
        ///     Unicode字符串转为正常字符串
        /// </summary>
        /// <param name="unicode"></param>
        /// <returns></returns>
        public static string PDU8bitDecoder(string unicode)
        {
            var result = string.Empty;
            for (var i = 0; i < unicode.Length; i += 4)
            {
                result += ((char) int.Parse(unicode.Substring(i, 4), NumberStyles.HexNumber)).ToString();
            }
            return result;
        }



        private void SaveHistoryRecord(string phoneNo, string ways, DateTime time, string context)
        {
          
            history.PhoneNo = phoneNo;
            history.Handler = ways;
            history.HandlerTime = time;
            history.Context = context;
            _bllHistory.Add(history);
        }

        /// <summary>
        ///     发送中文短信时电话转16进制
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public static string PhoneEncoder(string phone)
        {
            if (phone.Length%2 != 0)
                phone += END_OF_PHONE;
            return HexReverse(phone);
        }

        /// <summary>
        ///    接收短信时16进制转电话
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public static string PhoneDecoder(string phone)
        {
            return HexReverse(phone).Replace(END_OF_PHONE, string.Empty);
        }
        
        /// <summary>
        /// 删除位置1所在的短信
        /// </summary>
        public void DeleteReadMes()
        {
            
            _port.Send("AT+CMGD=1");
        }
        /// <summary>
        /// 读取位置为1的短信
        /// </summary>
        public void ReadSdCradMes()
        {
            _port.Send("AT+CMGL=1");
        }
        private static string HexReverse(string str)
        {
            if( str.Length % 2 != 0 )
                throw new ArgumentException("参数长度应该为偶数",str);
            var result = string.Empty;
            for (var i = 0; i < str.Length; i += 2)
            {
                result += str[i + 1] + str[i].ToString();
            }
            return result;
        }
        /// <summary>
        /// 查询
        /// </summary>
        public void Test()
        {
            _port.Send(TEST);
        }

        /// <summary>
        ///获取全部短信
        /// </summary>
        public void GetAllMessage()
        {
            _port.Send("AT+CMGF=0")
                 .Send("AT+CMGL=4");
        }
        /// <summary>
        /// 删除短信
        /// </summary>
        public void DeleteMes(string index)
        {
               _port.Send(string.Format("AT+CMGD={0}", index));
        }

        public void SendAt()
        {
            _port.Send(TEST);
        }
    }
}