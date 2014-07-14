using FormUI.OperationLayer;
using Machine.Specifications;

namespace UnitTest.字符串转换测试
{
    public class 手机号码转换到十六进制
    {
        private Because 执行了 = () =>
        {
            result = AT.PhoneEncoder("18873688664");
        };

        private It 应该转换成功 = () =>
        {
            result.ShouldEqual("8160813439F3");
        };

        private static string result;
    }

    public class 十六进制转换到手机号码
    {
        private Because 执行了 = () =>
        {
            result = AT.PhoneDecoder("8160813439F3");
        };

        private It 应该转换成功 = () =>
        {
            result.ShouldEqual("18873688664");
        };

        private static string result;
    }

    public class 偶数号码转换到十六进制
    {
        private Because 执行了 = () =>
        {
            result = AT.PhoneEncoder("073612345678");
        };

        private It 应该转换成功 = () =>
        {
            result.ShouldEqual("706321436587");
        };

        private static string result;
    }

    public class 十六进制转换到偶数号码
    {
        private Because 执行了 = () =>
        {
            result = AT.PhoneDecoder("706321436587");
        };

        private It 应该转换成功 = () =>
        {
            result.ShouldEqual("073612345678");
        };

        private static string result;
    }

    public class 基数号码转换到十六进制
    {
        private Because 执行了 = () =>
        {
            result = AT.PhoneEncoder("10086");
        };

        private It 应该转换成功 = () =>
        {
            result.ShouldEqual("0180F6");
        };

        private static string result;
    }

    public class 十六进制转换到基数号码
    {
        private Because 执行了 = () =>
        {
            result = AT.PhoneDecoder("0180F6");
        };

        private It 应该转换成功 = () =>
        {
            result.ShouldEqual("10086");
        };

        private static string result;
    }
}