//using System;
//using System.Text;
//using FormUI.OperationLayer;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace UnitTest
//{
//    [TestClass]
//    public class Test
//    {
//        [TestMethod]
//        public void Unicode2Chinese()
//        {
//            Assert.AreEqual("蓄电池光伏开关：V", AT.PDU8bitDecoder("84C475356C6051494F0F5F005173FF1A0056"));
//        }

//        [TestMethod]
//        public void Chinese2Unicode()
//        {
//            Assert.AreEqual("84C475356C6051494F0F5F005173FF1A0056", AT.PDU8bitEncoder("蓄电池光伏开关：V"));
//        }

//        [TestMethod]
//        public void GenerateLength()
//        {
//            var length = ("84C475356C6051494F0F5F005173FF1A0056".Length/2).ToString("X2");
//            Assert.AreEqual("12", length);
//        }

//        [TestMethod]
//        public void GenerateShortLength()
//        {
//            var length = ("4E00".Length / 2).ToString("X2");
//            Assert.AreEqual("02", length);
//        }


//        [TestMethod]
//        public void TestNull()
//        {
//            Assert.AreEqual("", null+"");
//        }
//    }
//}