using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProCalc.Lib.MPIR;
using System.Runtime.InteropServices;

namespace ProCalc.Tests
{
    [TestClass]
    public class MPIR_MPZ_Tests
    {
        [TestMethod]
        public void Is64Bit()
        {
            Assert.AreEqual(8, IntPtr.Size, "Must run tests in 64-bit mode");
        }

        [TestMethod]
        public void InitAndDestroyTest()
        {
            using (var a = new MPZ())
            {
            }
        }

        [TestMethod]
        public void ToStringTests()
        {
            Assert.AreEqual("1", new MPZ(1).ToString());
            Assert.AreEqual("987654321", new MPZ(987654321).ToString());
            Assert.AreEqual("-1", new MPZ(-1).ToString());
            Assert.AreEqual("123456789123456789", new MPZ(123456789123456789L).ToString());
            Assert.AreEqual("-123456789123456789", new MPZ(-123456789123456789L).ToString());
            Assert.AreEqual("1", new MPZ("1").ToString());
            Assert.AreEqual("987654321987654321987654321987654321987654321987654321987654321987654321", new MPZ("987654321987654321987654321987654321987654321987654321987654321987654321").ToString());
            Assert.AreEqual("-1", new MPZ("-1").ToString());
            Assert.AreEqual("f", new MPZ("15").ToString(16));
        }

        [TestMethod]
        public void ConvEq()
        {
            Assert.AreEqual(1, new MPZ(1));
            Assert.AreEqual(987654321, new MPZ(987654321));
            Assert.AreEqual(-1, new MPZ(-1));
            Assert.AreEqual(123456789123456789L, new MPZ(123456789123456789L));
            Assert.AreEqual(-123456789123456789L, new MPZ(-123456789123456789L));
        }

        [TestMethod]
        public void ArithTests()
        {
            Assert.AreEqual(new MPZ(2), new MPZ(1) + new MPZ(1));
            Assert.AreEqual(new MPZ(101), new MPZ(1) + 100);
            Assert.AreEqual(new MPZ(98765432), new MPZ(12345679) * 8);
            Assert.AreEqual(new MPZ(111111110888888889), new MPZ(999999999) * new MPZ(111111111));
        }
    }
}
