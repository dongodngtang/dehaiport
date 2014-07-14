using System;

namespace Domain.Model
{
    public class HistoryRecord
    {
        public virtual int Id { get; set;}
        public virtual string Handler { get; set; }
        public virtual string PhoneNo { get; set; }

        public virtual DateTime HandlerTime { get; set; }
        public virtual string Context { get; set; }

    }
}