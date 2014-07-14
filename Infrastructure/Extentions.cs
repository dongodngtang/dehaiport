using System;
using System.Windows.Forms;

namespace System.Runtime.CompilerServices
{
    public sealed class ExtensionAttribute : Attribute { }
}

namespace Infrastructure
{
    
    public static class Enum<T>
    {
        public static T Parse(string member)
        {
            return (T)Enum.Parse(typeof(T),member);
        }
    }
    
    public static class Extensions
    {
        public static void SetFocus(this TextBoxBase textBox)
        {
            textBox.Focus();
            textBox.SelectionStart = textBox.TextLength;
        }

        public static bool IsNullOrEmpty(this Object obj)
        {
            return obj == null || obj.ToString() == string.Empty;
        }
    }
}
