using System;

namespace TomorrowSoft.Model
{
    public class LongSms
    {
        public virtual int Id { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Content { get; set; }
        public virtual int Current { get; set; }
        public virtual int Total { get; set; }
        public virtual string Identifier { get; set; }
        public virtual DateTime Time { get; set; }
    }
}