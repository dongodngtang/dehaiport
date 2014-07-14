using System;

namespace TomorrowSoft.Model
{
    /// <summary>
    /// 状态
    /// </summary>
    public class Condition
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual int Id { get; set; }
        /// <summary>
        /// 终端号码
        /// </summary>
        public virtual string PhoneNo { get; set; }
        /// <summary>
        /// 光伏
        /// </summary>
        public virtual string Photovoltaic { get; set; }
        /// <summary>
        /// 电池
        /// </summary>
        public virtual string Battery { get; set; }
        /// <summary>
        /// 市电
        /// </summary>
        public virtual string PowerSource { get; set; }
        
        /// <summary>
        /// 功放已开（关）
        /// </summary>
        public virtual string QS { get; set; }
        /// <summary>
        /// 喇叭正(异)常
        /// </summary>
        public virtual string Horn1 { get; set; }
        /// <summary>
        /// 充电电压
        /// </summary>
        public virtual string Horn2 { get; set; }
        /// <summary>
        /// 放电电压
        /// </summary>
        public virtual string Horn3 { get; set; }
        /// <summary>
        /// 音量
        /// </summary>
        public virtual string Horn4 { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        public virtual DateTime  HandlerTime { get; set; }
    }
}