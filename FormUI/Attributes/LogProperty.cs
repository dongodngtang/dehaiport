using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;

namespace FormUI.Attributes
{
    public class LogProperty : IContextProperty, IContributeServerContextSink
    {
        public bool IsNewContextOK(Context newCtx)
        {
            return true;
        }

        public void Freeze(Context newContext)
        {
        }

        public string Name { get { return "AOP"; } }


        public IMessageSink GetServerContextSink(IMessageSink nextSink)
        {
            return new LogSink(nextSink);
        }
    }
}