using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KnockKnock.Test
{
    [TestClass]
    public class ReserveWordTest
    {
        
        [TestMethod]
        public void TestMethod1()
        {
             Assert.AreEqual("owt sps", new Process.ReverseWordProcess().Reverse("two sps"));
        }

        [TestMethod]
        public void TestMethod2()
        {
             Assert.AreEqual("two sps", new Process.ReverseWordProcess().Reverse("owt sps"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("", new Process.ReverseWordProcess().Reverse(""));
        }

        [TestMethod]
        public void TestMethod4()
        {
              Assert.AreEqual("sadasd wqwsadsa qwq eqweqw", new Process.ReverseWordProcess().Reverse("dsadas asdaswqw qwq wqewqe"));
        }

        [TestMethod]
        public void TestMethod5()
        {
               Assert.AreEqual("A H M E D", new Process.ReverseWordProcess().Reverse("A H M E D"));
        }
    }
}
