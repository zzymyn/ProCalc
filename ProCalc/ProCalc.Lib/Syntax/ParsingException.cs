using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCalc.Lib.Syntax
{
    public class ParsingException : Exception
    {
        private Token m_Token;

        public ParsingException(string reason, Token token)
            : base(reason)
        {
            m_Token = token;
        }
    }

    public class UnexpectedTokenParsingException : ParsingException
    {
        public UnexpectedTokenParsingException(Token t, params TokenType[] expected)
            : base($"unexpected token {t.Type} \"{t.Value}\", expected {string.Join(" or ", expected)}", t)
        {
        }
    }
}
