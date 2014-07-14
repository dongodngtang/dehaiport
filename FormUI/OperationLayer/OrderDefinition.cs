using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Infrastructure;

namespace FormUI.OperationLayer
{
    /// <summary>
    /// 命令定义
    /// 
    /// </summary>
    public class OrderDefinition
    {
        private AT comAT = new AT();

       
        private string manager = "管理";
        
        private string authorization = "授权";
        
        private string deletePhone = "删除";
       
        private string clearPhone = "清除";
      
        private string check = "查看";
       
        private string query = "查询";
   
        private string monitor = "监听";

        private string play = "播放";

        private string powerOff = "停播";
   
        private string voice = "音量";
    
        private string parameter = "参数";
    
        private string dayTime = "时间";
//        二、相关说明
//1、只有发送者的号码属于白名单的短信才是有效的，否则不予理睬。
//2、只有管理者才能设置白名单，且设置最多10个管理手机、20个授权手（话）机。
//3、书写命令短信不能空格，且格式必须紧凑。
//4、“< >”表示命令参数，这二个符号本身不能输入。
// 5、非命令短信，均作非法处理—回复短信：短信错误！。
        /// <summary>
        ///     播放方式
        /// </summary>
        public List<string> PlayStyle = new List<string>()
        {
            "单曲",
            "单曲循环",
            "大循环"
        };
        public static void SetPlayStyle(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            foreach (var value in Enum.GetValues(typeof (PlayStyle)))
            {
                comboBox.Items.Add(value);
            }
        }

        public static void SetMusicNo(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            foreach (var value in Enum.GetValues(typeof(MusicNo)))
            {
                comboBox.Items.Add(((int)value).ToString());
            }
        }

        public static void SetVoice(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            foreach (var value in Enum.GetValues(typeof(Voice)))
            {
                comboBox.Items.Add(((int)value).ToString());
            }
        }
        /// <summary>
        /// 管理号码添加 
        /// </summary>
        public string AddManagerPhone(string terminalName,string phone,string order)
        {
            
            comAT.SendChineseMessage(terminalName,phone, manager+order);
            return manager + order;
        }
        /// <summary>
        /// 授权号码添加
        /// </summary>
        public string Authorization(string terminalName, string phone, string order)
        {
            comAT.SendChineseMessage(terminalName ,phone, authorization + order);
            return authorization + order;
        }
        /// <summary>
        /// 删除号码
        /// </summary>
        public string DeletePhone(string terminalName, string phone, string order)
        {
            comAT.SendChineseMessage(terminalName ,phone, deletePhone + order);
            return deletePhone + order;
        }
         /// <summary>
         /// 号码清除
         /// </summary>
        public string ClearPhone(string terminalName, string phone)
         {
             comAT.SendChineseMessage(terminalName ,phone,clearPhone);
             return clearPhone;
         }
         /// <summary>
         /// 号码查看
         /// </summary>
        public string PhoneCheck(string terminalName, string phone)
        {
            comAT.SendChineseMessage(terminalName ,phone,check );
             return check;
        }
        /// <summary>
        /// 状态查询
        /// </summary>
        /// <param name="phone"></param>
        public string ConditionQuery(string terminalName, string phone)
        {
            comAT.SendChineseMessage(terminalName ,phone, query);
            return query;
        }
        /// <summary>
        ///  广播监听 
        /// </summary>
        /// <param name="phone"></param>
        public string Monitor(string terminalName, string phone)
        {
            comAT.SendChineseMessage(terminalName,phone, monitor);
            return monitor;
        }
        /// <summary>
        /// 语音段播放
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="model">第1个参数×：模式，1位数字，取值0、1、2，分别对应单曲、单曲循环、全部循环，默认为单曲，取值1~9。</param>
        /// <param name="volume">第2个参数×：语音段编号，1位数字，取值1~9。</param>
        /// <param name="time">第3个参数××：循环播放时间，2位数字，取值01~99，以分钟为单位，默认为3分钟。</param>
        public string PlayMusic(string terminalName, string phone, string model, string music, string time)
        {
            string order = play + model + music + time;
            comAT.SendChineseMessage(terminalName ,phone, order);
            return order;
        }
        /// <summary>
        ///  语音段停播
        /// </summary>
        /// <param name="phone"></param>
        public string MusicStop(string terminalName, string phone)
        {
            comAT.SendChineseMessage(terminalName ,phone, powerOff);
            return powerOff;
        }
        /// <summary>
        /// 音量设置
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="volume"></param>
        /// <param name="music"></param>
        public string VolumeSetting(string terminalName, string phone, string volume)
        {
            comAT.SendChineseMessage(terminalName ,phone,voice+volume);
            return voice+volume;
        }
        /// <summary>
        /// 参数设置
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="batteryChargerUp"></param>
        /// <param name="batteryChargerDown"></param>
        /// <param name="electroDischargeUp"></param>
        /// <param name="electroDischargeDown"></param>
        public string ParameterSetting(string terminalName, string phone, string batteryChargerUp,
                                    string batteryChargerDown, string electroDischargeUp,
                                    string electroDischargeDown)
       {
           string order = parameter + batteryChargerUp + batteryChargerDown
                          + electroDischargeUp + electroDischargeDown;
           comAT.SendChineseMessage(terminalName ,phone, order.Trim());
           return order;
       }
        /// <summary>
       /// 日期时间设置
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="hour"></param>
        /// <param name="minute"></param>
        /// <param name="second"></param>
        public string TimeSetting(string terminalName, string phone, string year, string month, string day,
                              string hour, string minute, string second)
      {
          string order = dayTime + year + month + day + hour + minute + second;
          comAT.SendChineseMessage(terminalName ,phone, order.Trim());
            return order;
      }
        public void TimeSet(string terminalName, string phone, string date)
        {
            string order = dayTime + date;
            comAT.SendChineseMessage(terminalName, phone, order);
        }
        /// <summary>
        /// 文本语音
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="playTimes"></param>
        /// <param name="voiceText"></param>
        public void PlayTextVoice(string terminalName, string phone, string playTimes, string voiceText)
        {
            string order = "播放3" + playTimes + voiceText;
            comAT.SendChineseMessage(terminalName ,phone, order);
        }
        /// <summary>
        /// 开通C型终端
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="termianlType1"></param>
        /// <param name="terminalType2"></param>
        /// <param name="terminalType3"></param>
        /// <returns></returns>
        public string OpenCTerminal(string terminalName, string phone, string termianlType1, string terminalType2, string terminalType3)
        {
            string order = "开通" + termianlType1 + terminalType2 + terminalType3;
            comAT.SendChineseMessage(terminalName ,phone, order.Trim());
            return order.Trim();
        }
        /// <summary>
        /// 终端防盗加锁
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public string Lock(string terminalName,string phone)
        {
            comAT.SendChineseMessage(terminalName ,phone, "加锁");
            return "加锁";
        }
        /// <summary>
        /// 终端防盗解锁
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public string UnLock(string terminalName, string phone)
        {
            comAT.SendChineseMessage(terminalName ,phone, "解锁");
            return "解锁";
        }
        /// <summary>
        /// 终端警报
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="minute"></param>
        /// <returns></returns>
        public string Alarm(string terminalName, string phone, string minute)
        {
            comAT.SendChineseMessage(terminalName ,phone,"警报"+minute);
            return "警报";
        }
        /// <summary>
        /// 检测
        /// </summary>
        /// <param name="text"></param>
        /// <param name="toolTipText"></param>
        public void Detection(string terminalName, string phone)
        {
            comAT.SendChineseMessage(terminalName, phone,"检测");
            
        }
    }

    public enum PlayStyle :int
    {
        单曲 = 0,
        单曲循环 = 1,
        全部循环 = 2
    }

    public enum MusicNo : int
    {
        语音0 = 0,
        语音1 = 1,
        语音2 = 2,
        语音3 = 3,
        语音4 = 4,
        语音5 = 5,
        语音6 = 6,
        语音7 = 7,
        语音8 = 8,
        语音9 = 9

    }
    public enum Voice:int
    {
        音量0 = 0,
        音量1 = 1,
        音量2 = 2,
        音量3 = 3,
        音量4 = 4,
        音量5 = 5,
        音量6 = 6,
        音量7 = 7,
        音量8 = 8,
        音量9 = 9
    }
}