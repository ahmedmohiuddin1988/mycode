using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KnockKnock.Test
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(-3, new KnockKnock.Process.FibonacciProcess().NthFibonacciNumber(-4));
        }

        [TestMethod]
        public void TestMethodNegFive()
        {
            Assert.AreEqual(5, new KnockKnock.Process.FibonacciProcess().NthFibonacciNumber(-5));
        }
        [TestMethod]
        public void TestMethodZero()
        {
            Assert.AreEqual(0, new KnockKnock.Process.FibonacciProcess().NthFibonacciNumber(0));
        }
        [TestMethod]
        public void TestMethodOne()
        {
            Assert.AreEqual(1, new KnockKnock.Process.FibonacciProcess().NthFibonacciNumber(1));
        }
        [TestMethod]
        public void TestMethodNegSix()
        {
            Assert.AreEqual(-8, new KnockKnock.Process.FibonacciProcess().NthFibonacciNumber(-6));
        }

        [TestMethod]
        public void TestMethodThree()
        {
            Assert.AreEqual(2, new KnockKnock.Process.FibonacciProcess().NthFibonacciNumber(3));
        }
        [TestMethod]
        public void TestMethodFour()
        {
            Assert.AreEqual(3, new KnockKnock.Process.FibonacciProcess().NthFibonacciNumber(4));
        }
        [TestMethod]
        public void TestMethodFive()
        {
            Assert.AreEqual(5, new KnockKnock.Process.FibonacciProcess().NthFibonacciNumber(5));
        }
        [TestMethod]
        public void TestMethodSix()
        {
            Assert.AreEqual(8, new KnockKnock.Process.FibonacciProcess().NthFibonacciNumber(6));
        }

        [TestMethod]
        public void TestMethodFifityFive()
        {
            Assert.AreEqual(139583862445, new KnockKnock.Process.FibonacciProcess().NthFibonacciNumber(55));
        }
        [TestMethod]
        public void TestMethodNegFiftySeven()
        {
            Assert.AreEqual(365435296162, new KnockKnock.Process.FibonacciProcess().NthFibonacciNumber(57));
        }

        
    }
}
