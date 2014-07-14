using System;
using System.Globalization;
using FormUI.OperationLayer;
using Machine.Specifications;

namespace UnitTest.字符串转换测试
{
    public class 英文短信转换
    {
        private Because 接收到 = () =>
        {
            var hex = "E3B79B5E76D301";
            content=AT.PDU7bitDecoder(hex,7);
        };

        private It 应该解析成功 = () =>
        {
            content.ShouldEqual("content");
        };

        private static string phone;
        private static string time;
        private static string content; 
    }
}