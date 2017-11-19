using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProCalc.Lib.MPIR;

namespace ProCalc.Tests
{
    [TestClass]
    public class MPIR_MPQ_Tests
    {
        [TestMethod]
        public void Is64Bit()
        {
            Assert.AreEqual(8, IntPtr.Size, "Must run tests in 64-bit mode");
        }

        [TestMethod]
        public void InitAndDestroyTest()
        {
            using (var a = new MPQ())
            {
            }
        }

        [TestMethod]
        public void ToStringTests()
        {
            Assert.AreEqual("1", new MPQ(1).ToString());
            Assert.AreEqual("987654321", new MPQ(987654321).ToString());
            Assert.AreEqual("1/2", new MPQ(1, 2).ToString());
            Assert.AreEqual("-2/3", new MPQ(-2, 3).ToString());
            Assert.AreEqual("3/4", new MPQ(0.75f).ToString());
            Assert.AreEqual("3/4", new MPQ(0.75).ToString());
            Assert.AreEqual("1/10", new MPQ(1, 10).ToString());
        }

        [TestMethod]
        public void ArithTests()
        {
            {
                var a = new MPQ(1);
                a /= 10;
                a += 5;
                Assert.AreEqual("51/10", a.ToString());
            }
            {
                var a = new MPQ("123456789123456789123456789123456789");
                a /= new MPZ("123456789123456789123456789123456789");
                Assert.AreEqual("1", a.ToString());
            }
        }


        [TestMethod]
        public void NomDem()
        {
            var a = new MPQ("22/7");
            Assert.AreEqual(a.Numerator, 22);
            Assert.AreEqual(a.Denominator, 7);
        }
    }
}
