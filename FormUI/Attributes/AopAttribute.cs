using System;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Contexts;

namespace FormUI.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AopAttribute : Attribute, IContextAttribute
    {
        public bool IsContextOK(Context ctx, IConstructionCallMessage msg)
        {
            return false;
        }

        public void GetPropertiesForNewContext(IConstructionCallMessage msg)
        {
            msg.ContextProperties.Add(new LogProperty());
        }
    }
}