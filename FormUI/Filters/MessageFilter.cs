using System;
using BLL;
using FormUI.OperationLayer;
using TomorrowSoft.BLL;
using TomorrowSoft.Model;

namespace FormUI.Filters
{
    public class MessageFilter : Filter
    {
        public override string Phone { get; protected set; }
        public override DateTime Time { get; set; }
        public override string Context { get; set; }
        public override bool IsQsDown { get; set; }
        
        public override string Name {
            get { return "收信"; }
        }
        private string phone;
        private DateTime time;
        private string content;
        private bool isQsDown;
        public MessageFilter(Filter next) : base(next)
        {
        }

        public override Filter Run()
        {
            if (Content.Length >= 2 && Content[0].Contains("+CMT:"))
            {
                new AT().SmsAnswer();
                bool isLongMessage;
                int current;
                int total;
                string identifier;
                AT.GetSmsContent(Content[1],out isLongMessage, out phone, out time, out content,out current,out total,out identifier);
                if (phone.StartsWith("86"))
                    phone=phone.Remove(0, 2);
                if (White.PhoneExists(phone) || Terminal.PhoneExists(phone))
                {
                    
                    if (isLongMessage)
                    {
                        var service = new LongSmsService();
                        service.Add(new LongSms
                            {
                                Content = content,
                                Current = current,
                                Identifier = identifier,
                                Phone = phone,
                                Time = time,
                                Total = total
                            });

                        var longSmses = service.GetBy(phone, identifier, time);
                        if (longSmses.Count < total)
                            return null;
                        content = string.Empty;
                        foreach (var sms in longSmses)
                        {
                            content += sms.Content;
                        }
                       
                    }

                    if (content.Contains("光伏")){
                        new ConditionService()
                            .Add(ConditionFilter.FilterCondition(phone, content));
                        isQsDown = ConditionFilter.PhotovoltaicCompare();
                    }
                    else
                    {
                       
                        var txt = content.Replace("\r\n", string.Empty);
                        for (int b = 1; b < (txt.Length/48); b++)
                        {
                            txt = txt.Insert(48*b, "\r\n");
                        }
                          new HistoryRecordService().Add(new HistoryRecord()
                            {
                                Handler = Name,
                                PhoneNo = phone,
                                HandlerTime = DateTime.Now.ToLocalTime(),
                                Context = txt,
                            });

                    }
                    new AT().DeleteReadMes();
                    Phone = phone;
                    Time = time;
                    Context = content;
                    IsQsDown = isQsDown;
                    if (isQsDown)
                    {
                        Context = string.Format("告警：光伏值低于{0}\r\n", new QsService().GetAll().Rows[0]["QsDown"]) + content;
                    }
                    return this;
                }
                return null;

            }
            return base.Run();
        }
    }
}