using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProCalc.Lib.Syntax;

namespace ProCalc.Tests
{
    [TestClass]
    public class Parser_Tests
    {
        [TestMethod]
        public void SimpleTests()
        {
            //Assert.AreEqual(2, Parser.Evaluate("1+1"));
            //Assert.AreEqual(1, Parser.Evaluate("1+1*0"));
            //Assert.AreEqual(0, Parser.Evaluate("(1+1)*0"));
            //Assert.AreEqual(-2, Parser.Evaluate("-1-1"));
            //Assert.AreEqual(-2, Parser.Evaluate("-1+-1"));
            //Assert.AreEqual(0, Parser.Evaluate("-1+--1"));
            //Assert.AreEqual(-2, Parser.Evaluate("-1+---1"));
            //Assert.AreEqual(20, Parser.Evaluate("10/-1*-2"));
        }

        [TestMethod]
        public void ClosingParensOptional()
        {
            //Assert.AreEqual(4, Parser.Evaluate("2*(1+1"));
            //Assert.AreEqual(10, Parser.Evaluate("2*(1+2*(1+1"));
        }
    }
}
