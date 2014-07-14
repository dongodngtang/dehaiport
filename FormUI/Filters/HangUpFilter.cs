
using System;
using FormUI.OperationLayer;

namespace FormUI.Filters
{
    public class HangUpFilter : Filter
    {
        private const string name = "确定";
        public override string Phone { get; protected set; }
        public override DateTime Time {
            get { return DateTime.Now.ToLocalTime(); }
        }
        public override string Context { get; set; }
        public override string Name {
            get { return "未接通"; }
        }

        public HangUpFilter(Filter next) : base(next)
        {
        }

        public override Filter Run()
        {
            if (Content.Length > 0 && Content[0].Contains("NO CARRIER"))
            {
                return this;
            }
            return base.Run();
        }
    }
}