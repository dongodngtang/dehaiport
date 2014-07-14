using System;
using System.Runtime.Remoting.Messaging;
using FormUI.OperationLayer;
using TomorrowSoft.BLL;
using TomorrowSoft.Model;

namespace FormUI.Attributes
{
    public class LogSink : IMessageSink
    {
        public LogSink(IMessageSink nextSink)
        {
            NextSink = nextSink;
        }

        public IMessage SyncProcessMessage(IMessage msg)
        {
            var call = msg as IMethodCallMessage;
            var attributes = call.MethodBase.GetCustomAttributes(false);
            Array.Exists(attributes,x=>x.GetType()==typeof(OperationAttribute));
            BeforeProcess(call);
            var retMsg = NextSink.SyncProcessMessage(msg);
            LogProcess(call);
            return retMsg;
        }

        public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
        {
            return null;
        }

        public IMessageSink NextSink { get; private set; }

        private void BeforeProcess(IMethodCallMessage call)
        {
            var attributes = call.MethodBase.GetCustomAttributes(typeof(OperationAttribute), false);
            if (attributes.Length <= 0) return;
            Port.Instance.ReceiveEventEnabled = false;
        }

        private void LogProcess(IMethodCallMessage call)
        {
            var operation = call.MethodBase.GetCustomAttributes(typeof(OperationAttribute), false);
            if (operation.Length <= 0) return;
            Port.Instance.ReceiveEventEnabled = true;
        }
    }
}