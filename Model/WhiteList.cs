using System;

namespace TomorrowSoft.Model
{
    /// <summary>
    /// 白名单
    /// </summary>
    public class WhiteList
    {
       
        /// <summary>
        /// 操纵者的ID
        /// </summary>
        public virtual int Id { get; set; }
        /// <summary>
        /// 操纵者的权限
        /// </summary>
        public virtual WhiteListType Type { get; set; }
        /// <summary>
        /// 电话号码
        /// </summary>
        public virtual string PhoneNo { get; set; }
    }

    public enum WhiteListType
    {
        中控机号码,
        管理号码,
        授权号码
    }
}