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
        public void InitTest()
        {
            using (var a = new MPZ())
            {
            }
        }
    }
}
