using Machine.Specifications;

namespace UnitTest.端口连接测试
{
    public class 开机读取GSM中的短信:端口连接基类
    {
        private Because 开机读取短信 = () => AT.ReadSdCradMes();

     
    }
}