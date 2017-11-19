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
            : base("Parsing failed: " + reason)
        {
            m_Token = token;
        }
    }
}
