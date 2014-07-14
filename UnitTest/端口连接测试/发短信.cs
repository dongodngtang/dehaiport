using FormUI.OperationLayer;
using Machine.Specifications;

namespace UnitTest.端口连接测试
{
    public class 发中文短信 : 端口连接基类
    {
        private Because execute = () =>
        {
            new AT().SendChineseMessage("MINE","18873688664","你好");
        };

        private It 打个酱油卖个萌_断言不是重点 = () => Port.Instance.ShouldNotBeNull(); 
    }

    public class 发英文短信 : 端口连接基类
    {
        private Because execute = () =>
        {
            new AT().SendEnglishMessage("18873688664", "hello");
        };

        private It 打个酱油卖个萌_断言不是重点 = () =>
        {
            Port.Instance.ShouldNotBeNull();
        };
    }
}