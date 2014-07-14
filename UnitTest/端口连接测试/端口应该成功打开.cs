using Machine.Specifications;

namespace UnitTest.端口连接测试
{
    public class 端口应该成功打开:端口连接基类
    {
        private Because execute = () => AT.Test();

        private It 应该成功打开端口 = () => Port.SerialPort.ReadExisting().ShouldContain("AT\r\r\nOK\r\n");
    }
}