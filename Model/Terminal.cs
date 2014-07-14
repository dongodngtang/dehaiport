using System;

namespace TomorrowSoft.Model
{
    /// <summary>
    /// 终端
    /// </summary>
    public class Terminal
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual int Id { get; set; }
        /// <summary>
        /// 终端地址
        /// </summary>
        public virtual string Address { get; set; }
        /// <summary>
        /// 电话号码
        /// </summary>
        public virtual string PhoneNo { get; set; }
        /// <summary>
        /// 所属组号
        /// </summary>
        public virtual string Grouping { get; set; } 
        /// <summary>
        /// 二级绑定号码
        /// </summary>
        public virtual string GroupPhone { get; set; }
        /// <summary>
        /// 一级绑定号码
        /// </summary>
        public virtual string AllPhone { get; set; }
        /// <summary>
        /// 终端名称
        /// </summary>
        public virtual string Name { get; set; }
    }
}