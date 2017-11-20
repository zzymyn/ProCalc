using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProCalc.Lib.MPIR;

namespace ProCalc.Tests
{
    [TestClass]
    public class MPIR_MPF_Tests
    {
        [TestMethod]
        public void Is64Bit()
        {
            Assert.AreEqual(8, IntPtr.Size, "Must run tests in 64-bit mode");
        }

        [TestMethod]
        public void InitAndDestroyTest()
        {
            using (var a = new MPF())
            {
            }
        }

        [TestMethod]
        public void ToStringTests()
        {
            Assert.AreEqual("1.2345678e3", new MPF("1234.5678").ToString());
            Assert.AreEqual("5.e3", new MPF("5000").ToString());
            Assert.AreEqual("5.e2", new MPF("500").ToString());
            Assert.AreEqual("5.e1", new MPF("50").ToString());
            Assert.AreEqual("5", new MPF("5").ToString());
            Assert.AreEqual("5.5e1", new MPF("55").ToString());
            Assert.AreEqual("0.5", new MPF("0.5").ToString());
            Assert.AreEqual("1.5", new MPF("1.5").ToString());
            Assert.AreEqual("5.e-2", new MPF("0.05").ToString());
            Assert.AreEqual("5.e-3", new MPF("0.005").ToString());
            Assert.AreEqual("5.e-4", new MPF("0.0005").ToString());
            Assert.AreEqual("0", new MPF("0").ToString());
            Assert.AreEqual("1.256e1", new MPF("12.56").ToString());
            Assert.AreEqual("5.e9", new MPF("5000000000").ToString());
            Assert.AreEqual("5.1e9", new MPF("5100000000").ToString());
            Assert.AreEqual("5.e-9", new MPF("0.000000005").ToString());
            Assert.AreEqual("0", new MPF("0").ToString());
        }

        [TestMethod]
        public void ToHumanTests()
        {
            Assert.AreEqual("1234.5678", new MPF("1234.5678").ToHuman());
            Assert.AreEqual("5000", new MPF("5000").ToHuman());
            Assert.AreEqual("55", new MPF("55").ToHuman());
            Assert.AreEqual("0.0005", new MPF("0.0005").ToHuman());
            Assert.AreEqual("0", new MPF("0").ToHuman());
            Assert.AreEqual("0.5", new MPF("0.5").ToHuman());
            Assert.AreEqual("1.5", new MPF("1.5").ToHuman());
            Assert.AreEqual("12.56", new MPF("12.56").ToHuman());
            Assert.AreEqual("5.1e9", new MPF("5100000000").ToHuman(5));

            Assert.AreEqual("5.e9", new MPF("5000000000").ToHuman(5));
            Assert.AreEqual("5.e8", new MPF("500000000").ToHuman(5));
            Assert.AreEqual("5.e7", new MPF("50000000").ToHuman(5));
            Assert.AreEqual("5.e6", new MPF("5000000").ToHuman(5));
            Assert.AreEqual("5.e5", new MPF("500000").ToHuman(5));
            Assert.AreEqual("50000", new MPF("50000").ToHuman(5));
            Assert.AreEqual("5000", new MPF("5000").ToHuman(5));
            Assert.AreEqual("500", new MPF("500").ToHuman(5));
            Assert.AreEqual("50", new MPF("50").ToHuman(5));
            Assert.AreEqual("5", new MPF("5").ToHuman(5));
            Assert.AreEqual("0.5", new MPF("0.5").ToHuman(5));
            Assert.AreEqual("0.05", new MPF("0.05").ToHuman(5));
            Assert.AreEqual("0.005", new MPF("0.005").ToHuman(5));
            Assert.AreEqual("0.0005", new MPF("0.0005").ToHuman(5));
            Assert.AreEqual("0.00005", new MPF("0.00005").ToHuman(5));
            Assert.AreEqual("5.e-6", new MPF("0.000005").ToHuman(5));
            Assert.AreEqual("5.e-7", new MPF("0.0000005").ToHuman(5));
            Assert.AreEqual("5.e-8", new MPF("0.00000005").ToHuman(5));
            Assert.AreEqual("5.e-9", new MPF("0.000000005").ToHuman(5));

            Assert.AreEqual("5.5556e9", new MPF("5555555555").ToHuman(5));
            Assert.AreEqual("5.5556e8", new MPF("555555555").ToHuman(5));
            Assert.AreEqual("5.5556e7", new MPF("55555555").ToHuman(5));
            Assert.AreEqual("5.5556e6", new MPF("5555555").ToHuman(5));
            Assert.AreEqual("5.5556e5", new MPF("555555").ToHuman(5));
            Assert.AreEqual("55555", new MPF("55555").ToHuman(5));
            Assert.AreEqual("5555", new MPF("5555").ToHuman(5));
            Assert.AreEqual("555", new MPF("555").ToHuman(5));
            Assert.AreEqual("55", new MPF("55").ToHuman(5));
            Assert.AreEqual("5", new MPF("5").ToHuman(5));
            Assert.AreEqual("5.5", new MPF("5.5").ToHuman(5));
            Assert.AreEqual("5.55", new MPF("5.55").ToHuman(5));
            Assert.AreEqual("5.555", new MPF("5.555").ToHuman(5));
            Assert.AreEqual("5.5555", new MPF("5.5555").ToHuman(5));
            Assert.AreEqual("0.55555", new MPF("0.55555").ToHuman(5));
            Assert.AreEqual("5.5555e-2", new MPF("0.055555").ToHuman(5));
            Assert.AreEqual("5.5555e-3", new MPF("0.0055555").ToHuman(5));
            Assert.AreEqual("5.5555e-4", new MPF("0.00055555").ToHuman(5));
            Assert.AreEqual("5.5555e-5", new MPF("0.000055555").ToHuman(5));

        }

        [TestMethod]
        public void ArithTests()
        {
        }
    }
}
