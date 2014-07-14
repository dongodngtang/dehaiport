using System;
using FormUI.Filters;
using Machine.Specifications;

namespace UnitTest.过滤器测试
{
    public class 过滤器测试基类
    {
        private Establish 初始化 = () =>
        {
            
        };

        protected static string[] GetContents(string message)
        {
            return message.Replace("\r", string.Empty).Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
        }

        protected static string[] RecieveMessage;
        protected static Filter Result;
    }
}