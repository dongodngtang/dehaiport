using System;
using System.Windows.Forms.VisualStyles;
using FormUI.OperationLayer;
using Machine.Specifications;

namespace UnitTest.字符串转换测试
{
    public class 中文短信转换
    {
        private Because 接收到 = () =>
        {
            var hex="0891683108501755F5200D91683100248150F3000831217102207523449F505FB79F990028003100380030003600310038003400330039003300330029FF1A8D257B1455090020301053EF76F463A556DE590D3011301053D181EA66134FE13011";
            bool isLongMessage;
            int current;
            int total;
            string identifier;
            AT.GetSmsContent(hex,out isLongMessage, out phone, out time, out content,out current,out total,out identifier);
        };

        private It 应该解析成功 = () =>
        {
            phone.ShouldEqual("8613004218053");
            time.ShouldEqual(new DateTime(2013,12,17,20,02,57));
            content.ShouldEqual("齐德龙(18873688664)：败笔唉 【可直接回复】【发自易信】");
        };

        private static string phone;
        private static DateTime time;
        private static string content;
    }
}