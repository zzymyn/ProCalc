using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProCalc.Lib.MPIR;
using System.Runtime.InteropServices;

namespace ProCalc.Tests
{
    [TestClass]
    public class MPIR_Tests
    {
        [TestMethod]
        public void InitTest()
        {
            var a = Marshal.AllocHGlobal(MPIR.MPZSize);
            MPIR.mpz_init(a);
            MPIR.mpz_clear(a);
        }
    }
}
