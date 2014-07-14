using System;

namespace TomorrowSoft.Model
{
    /// <summary>
    /// 历史记录
    /// </summary>
    public class HistoryRecord
    {
        
        /// <summary>
        /// 主键
        /// </summary>
        public virtual int Id { get; set;}
        /// <summary>
        /// 操作
        /// </summary>
        public virtual string Handler { get; set; }
        /// <summary>
        /// 电话号码
        /// </summary>
        public virtual string PhoneNo { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public virtual DateTime HandlerTime { get; set; }
        /// <summary>
        /// 操作内容
        /// </summary>
        public virtual string Context { get; set; }

    }
}