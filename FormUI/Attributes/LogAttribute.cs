using System;

namespace FormUI.Attributes
{
    public class LogAttribute : Attribute
    {
        public LogAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}