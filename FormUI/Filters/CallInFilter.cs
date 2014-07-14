using System;
using FormUI.OperationLayer;
using TomorrowSoft.BLL;
using TomorrowSoft.Model;

namespace FormUI.Filters
{
    public class CallInFilter : Filter
    {
        public override string Phone { get; protected set; }
        public override DateTime Time {
            get { return DateTime.Now.ToLocalTime(); }
        }
        public override string Context { get; set; }
        public override string Name {
            get { return "来电"; }
        }
        private static string PhoneNo;
        private static int Times;
       
        public CallInFilter(Filter next) : base(next)
        {
        }

        public override Filter Run()
        {
            if (Content.Length >= 2 && Content[0] == "RING")
            {
                var list = Content[1].Split(new[] {"\""}, StringSplitOptions.RemoveEmptyEntries);
                if (list.Length > 1)
                {
                    Phone = list[1];
                    if (White.PhoneExists(Phone) || Terminal.PhoneExists(Phone))
                    {
                        if (PhoneNo != Phone || Times > 3)
                        {
                            new HistoryRecordService().Add(new HistoryRecord()
                                {
                                    Handler = Name,
                                    PhoneNo = PhoneNo,
                                    HandlerTime = Time,
                                });
                            Times = 0;
                            PhoneNo = PhoneNo;
                        }
                        else
                        {
                            Times++;
                        }
                        return this;
                    }
                    At.HangUp();
                    return null;
                }
            }
            return base.Run();
        }
    }
}