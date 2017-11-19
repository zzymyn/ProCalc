using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCalc.Lib.Lexer
{
    [DebuggerDisplay("{Type}: {Value}")]
    public struct Token
    {
        public TokenType Type { get; private set; }
        public int Index { get; private set; }
        public int Length { get; private set; }

        private string m_Source;

        public string Value
        {
            get { return m_Source.Substring(Index, Length); }
        }

        public Token(TokenType type, string value)
        {
            Type = type;
            Index = 0;
            Length = value.Length;
            m_Source = value;
        }

        internal Token(TokenType type, int index, int length, string source)
        {
            Type = type;
            Index = index;
            Length = length;
            m_Source = source;
        }
    }
}
