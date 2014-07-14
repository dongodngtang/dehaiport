
using System;
using FormUI.OperationLayer;
using TomorrowSoft.BLL;

namespace FormUI.Filters
{
    public class Filter
    {
        protected readonly string[] Content;
        private readonly Filter _next;
        protected readonly WhiteListService White = new WhiteListService();
        protected readonly TerminalService Terminal = new TerminalService();
        protected readonly AT At = new AT();
        public virtual string Name { get; set; }
        public virtual string Phone { get; protected set; }
        public virtual string Context { get; set; }
        public virtual DateTime Time { get; set; }
        public virtual bool IsQsDown { get; set; }
       
        protected Filter(Filter next)
        {
            _next = next;
            Content = next.Content;
        }

        protected Filter(string[] content)
        {
            Content = content;
        }

        public virtual Filter Run()
        {
            return _next.Run();
        }
    }
}