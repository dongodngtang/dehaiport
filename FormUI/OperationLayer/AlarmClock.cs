using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FormUI.SettingForms;
using TomorrowSoft.BLL;
using TomorrowSoft.Model;
using Timer = System.Timers.Timer;

namespace FormUI.OperationLayer
{
    public class AlarmClock
    {
        private static volatile AlarmClock instance;
        private static readonly object syncRoot = new Object();
        private readonly OrderDefinition _order = new OrderDefinition();
        private readonly RegularPlayService _service = new RegularPlayService();
        public static string GroupName;
        public static string PlayTime;
        private IList<GroupMemoryPlay> _groupMemorys;
        private QsService _qsService = new QsService();
        private TerminalService _terminal = new TerminalService();
        
        public AlarmClock()
        {
            var aTimer = new Timer();
             aTimer.Elapsed += PhotovoltaicEventProcessor;
            aTimer.Elapsed += TimerEventProcessor; //到达时间的时候执行事件；
            aTimer.Elapsed += RegularEventProcessor;
           
            // 设置引发时间的时间间隔 此处设置为1秒（1000毫秒） 
            aTimer.Interval = 1000;
            aTimer.AutoReset = true; //设置是执行一次（false）还是一直执行(true)；
            aTimer.Enabled = true; //是否执行System.Timers.Timer.Elapsed事件；
        } 
        GroupMemoryPlayService memory = new GroupMemoryPlayService();
        
        /// <summary>
        ///     多线程单例模式
        /// </summary>
        /// <returns></returns>
       public static AlarmClock Instance
        {
            get
            {
                if (instance != null) return instance;
                lock (syncRoot)
                {
                    if (instance == null)
                        instance = new AlarmClock();
                }
                return instance;
            }
        }
        /// <summary>
        /// 光伏低值告警
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void PhotovoltaicEventProcessor(Object sender, EventArgs args)
        {
           var qs= _qsService.GetAll();
           if (qs.Rows.Count > 0 && DateTime.Now.ToString("HH:mm:ss").Equals(qs.Rows[0]["SendTime"]))
            {
                var terminals = _terminal.GetModelList("");
               
                foreach (var terminal in terminals)
                {
                    _order.Detection(terminal .Name ,terminal.PhoneNo);
                    new MessageBoxTimeOut().Show(3000, string.Format( "{0}：正在进行定时查询！",terminal .Name), "提示", MessageBoxButtons.OK);
                }
            }

        }
        /// <summary>
        /// 定时广播
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="mArgs"></param>
        private void RegularEventProcessor(Object sender, EventArgs mArgs)
        {
             Regular();
        }
        /// <summary>
        /// 记忆组播
        /// </summary>
        /// <param name="myObject"></param>
        /// <param name="myEventArgs"></param>
        private void TimerEventProcessor(Object myObject,
                                         EventArgs myEventArgs)
        {
           
            if (GroupName != null)
            {
                  MemoryPlay();
            }

        }
        
        private void MemoryPlay()
        {
            _groupMemorys = memory.GetModelList(string.Format("GroupName = '{0}'", GroupName));
            if (_groupMemorys == null) return;
            foreach (var group in _groupMemorys)
            {
                double delay = 0.07;
                if (group.PlayDelay != 0.0)
                {
                    delay = Convert.ToDouble(group.PlayDelay);
                }
                string thetime = Convert.ToDateTime(PlayTime).AddMinutes(delay).ToString("yyyy/MM/dd HH:mm:ss");
                if (DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss").Equals(thetime))
                {
                    
                    string context = _order.PlayMusic(group.TerminalName ,group.TerminalNo, group.PlayStyle, group.Music, group.PlayMinute);
                    new MessageBoxTimeOut().Show(3000, string.Format("{0}：正在进行组播活动！" ,group .TerminalName), "提示", MessageBoxButtons.OK);
                }
            }
        }

        private void Regular()
        {
            IList<RegularPlay> entities = _service.GetModelList("");
            if (entities == null || entities .Count <= 0) return;
            foreach (RegularPlay item in entities)
            {
                string[] type = item.RegularType.Split(new[] {"-"}, StringSplitOptions.RemoveEmptyEntries);
                if (type.Length == 0)
                    return;
                if (type[0] == "每月")
                {
                    string time = item.Time;
                    if (DateTime.Now.ToString("HH:mm:ss").Equals(time) &&
                        Convert.ToInt32(DateTime.Now.ToString("dd")).Equals(Convert.ToInt32(type[1])))
                    {
                        _order.PlayMusic(item.TerminalName ,item.Phone, item.PlayType, item.Music, item.PlayTimes);
                        UpdatePlayTimes(item);
                        new MessageBoxTimeOut().Show(6000, string.Format("{0}：正在进行定时广播！" ,item.TerminalName), "提示", MessageBoxButtons.OK);
                    }
                }
                if (type[0] == "每周")
                {
                    if (type[1].Contains(DateTime.Now.ToString("dddd")) &&
                        DateTime.Now.ToLongTimeString().Equals(item.Time))
                    {
                        _order.PlayMusic(item.TerminalName, item.Phone, item.PlayType, item.Music, item.PlayTimes);
                        UpdatePlayTimes(item);
                        new MessageBoxTimeOut().Show(6000, string.Format("{0}：正在进行定时广播！", item.TerminalName), "提示", MessageBoxButtons.OK);
                    }
                }
                if (type[0] == "每天")
                {
                    string nowtime = DateTime.Now.ToString("HH:mm:ss") + "*";
                    if (nowtime.Equals(type[1]))
                    {
                         _order.PlayMusic(item.TerminalName, item.Phone, item.PlayType, item.Music, item.PlayTimes);
                        UpdatePlayTimes(item);
                        new MessageBoxTimeOut().Show(6000, string.Format("{0}：正在进行定时广播！", item.TerminalName), "提示", MessageBoxButtons.OK);
                    }
                }
                if (type[0] == "指定时间")
                {
                    string time = type[1] + " " + item.Time;
                    if (DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss").Equals(time))
                    {
                         _order.PlayMusic(item.TerminalName, item.Phone, item.PlayType, item.Music, item.PlayTimes);
                        UpdatePlayTimes(item);
                        new MessageBoxTimeOut().Show(6000, string.Format("{0}：正在进行定时广播！", item.TerminalName), "提示", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void UpdatePlayTimes(RegularPlay item)
        {
            _service.Update(new RegularPlay
                {
                    Id = item.Id,
                    Time = item.Time,
                    Music = item.Music,
                    PlayType = item.PlayType,
                    RegularType = item.RegularType,
                    Status = ++item.Status,
                    Phone = item.Phone,
                    PlayTimes = item.PlayTimes
                });
        }
    }
}