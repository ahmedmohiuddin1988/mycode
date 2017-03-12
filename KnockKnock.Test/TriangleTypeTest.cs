using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KnockKnock.Test
{
    [TestClass]
    public class TriangleTypeTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Error", new KnockKnock.Process.TriangleTypeProcess().GetTriangleType(0, 0, 0));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("Isosceles", new KnockKnock.Process.TriangleTypeProcess().GetTriangleType(3, 3, 5));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("Isosceles", new KnockKnock.Process.TriangleTypeProcess().GetTriangleType(14, 1, 14));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual("Equilateral", new KnockKnock.Process.TriangleTypeProcess().GetTriangleType(1, 1, 1));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual("Scalene", new KnockKnock.Process.TriangleTypeProcess().GetTriangleType(4, 5, 3));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual("Scalene", new KnockKnock.Process.TriangleTypeProcess().GetTriangleType(5, 3, 4));
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual("Error", new KnockKnock.Process.TriangleTypeProcess().GetTriangleType(8, 8, 8000));
        }
    }
}
