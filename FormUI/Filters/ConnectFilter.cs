using System;

namespace FormUI.Filters
{
    public class ConnectFilter:Filter
    {
        private new const string name = "已接通";
        public override string Phone { get; protected set; }
        public override DateTime Time { get; set; }
        public override string Context { get; set; }
        public override string Name { get; set; }

        public ConnectFilter(Filter next) : base(next)
        {
        }

        public override Filter Run()
        {
            if (Content.Length ==1 && Content[0].Contains("OK"))
            {
                return null;
            }
            return base.Run();
        }
    }
}