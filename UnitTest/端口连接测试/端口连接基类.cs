using System.IO.Ports;
using FormUI.OperationLayer;
using Machine.Specifications;

namespace UnitTest.端口连接测试
{
    public class 端口连接基类
    {
        private Establish init = () =>
        {
            Port.SetPortName("COM3")
                .SetBaudRate(SerialPortBaudRates.BaudRate_115200.ToString("D"))
                .SetDataBit(SerialPortDatabits.EightBits.ToString("D"))
                .SetParity(Parity.None.ToString())
                .SetStopBit(StopBits.One.ToString());
            Port.ReceiveEventEnabled = false;
            Port.Open();
        };

        protected static readonly Port Port=Port.Instance;

        protected static readonly AT AT=new AT();
    }
}