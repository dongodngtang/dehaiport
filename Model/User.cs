using System;

namespace TomorrowSoft.Model
{
    public class User
    {
        public virtual Guid Id { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        public virtual string Level  { get; set; }
        public virtual bool Remember { get; set; }
    }
}