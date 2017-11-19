using System.Diagnostics;

namespace ProCalc.Lib.Syntax
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

        public Token(TokenType newType, Token t)
        {
            Type = newType;
            Index = t.Index;
            Length = t.Length;
            m_Source = t.m_Source;
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
