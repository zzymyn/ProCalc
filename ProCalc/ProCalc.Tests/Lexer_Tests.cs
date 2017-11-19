using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProCalc.Lib.MPIR;
using System.Runtime.InteropServices;
using ProCalc.Lib.Lexer;
using System.Linq;

namespace ProCalc.Tests
{
    [TestClass]
    public class Lexer_Tests
    {
        [TestMethod]
        public void SimpleLexTest()
        {
            var tokens = Lexer.Lex("1 + 22 - 12.56").ToList();

            AssertToken(tokens[0], TokenType.Number, "1");
            AssertToken(tokens[1], TokenType.Operator, "+");
            AssertToken(tokens[2], TokenType.Number, "22");
            AssertToken(tokens[3], TokenType.Operator, "-");
            AssertToken(tokens[4], TokenType.Number, "12.56");
            AssertToken(tokens[5], TokenType.EOF, "");
        }

        [TestMethod]
        public void EdgeCases()
        {
            AssertToken(Lexer.Lex("1 1", false).First(), TokenType.Number, "1 1");
            AssertToken(Lexer.Lex(" 1 1", false).First(), TokenType.Whitespace, " ");
            AssertToken(Lexer.Lex("1. 2", false).First(), TokenType.Number, "1. 2");
            AssertToken(Lexer.Lex("1 . 2", false).First(), TokenType.Number, "1 . 2");
            AssertToken(Lexer.Lex("1 2 3 4 5 6 7 8 9", false).First(), TokenType.Number, "1 2 3 4 5 6 7 8 9");
            AssertToken(Lexer.Lex(" 1 2 3 4 5 6 7 8 9", false).First(), TokenType.Whitespace, " ");

            AssertToken(Lexer.Lex("sin", false).First(), TokenType.Identifier, "sin");
            AssertToken(Lexer.Lex(" sin", false).First(), TokenType.Whitespace, " ");
            AssertToken(Lexer.Lex("si n", false).First(), TokenType.Identifier, "si");
        }

        private void AssertToken(Token t, TokenType type, string value)
        {
            Assert.AreEqual(type, t.Type);
            Assert.AreEqual(value, t.Value);
        }
    }
}
