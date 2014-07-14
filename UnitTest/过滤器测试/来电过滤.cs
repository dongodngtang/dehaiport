using FormUI.Filters;
using Machine.Specifications;

namespace UnitTest.过滤器测试
{
    public class 来电过滤 : 过滤器测试基类
    {
        private Because it = () =>
        {
            RecieveMessage = GetContents("\r\nRING\r\n\r\n+CLIP: \"18873688664\",161,,,,0\r\n");
            Result=new FilterProcessor(RecieveMessage).Run();
        };

        private It 应该提示来电 = () =>
        {
            Result.ShouldBeOfType<CallInFilter>();
            Result.ToString().ShouldContain("18873688664");
        }; 
    }

    public class 挂断过滤 : 过滤器测试基类
    {
        private Because it = () =>
        {
            RecieveMessage = GetContents("\r\n NO CARRIER \r\n");
            Result = new FilterProcessor(RecieveMessage).Run();
        };

        private It 应该提示挂断 = () =>
        {
            Result.ShouldBeOfType<HangUpFilter>();
        }; 
    }

    public class 短信过滤 : 过滤器测试基类
    {
        private Because it = () =>
        {
            RecieveMessage = GetContents("\r\n+CMT: ,88\r\n0891683108501755F5200D91683100248150F3000831217102207523449F505FB79F990028003100380030003600310038003400330039003300330029FF1A8D257B1455090020301053EF76F463A556DE590D3011301053D181EA66134FE13011\r\n");
            Result = new FilterProcessor(RecieveMessage).Run();
        };

        private It 应该提示短信 = () =>
        {
            Result.ShouldBeOfType<MessageFilter>();
            Result.ToString().ShouldContain("齐德龙");
            Result.Name.ShouldEqual("新短信");
        };
    }

    public class 未知过滤 : 过滤器测试基类
    {
        private Because it = () =>
        {
            RecieveMessage = GetContents("\r\nERROR\r\n");
            Result = new FilterProcessor(RecieveMessage).Run();
        };

        private It 应该报错 = () =>
        {
            Result.ShouldBeOfType<ErrorFilter>();
        };
    }
}