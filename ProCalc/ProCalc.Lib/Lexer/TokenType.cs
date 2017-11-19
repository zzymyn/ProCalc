using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCalc.Lib.Lexer
{
    public enum TokenType
    {
        Invalid,
        Whitespace,
        Number,
        Identifier,
        Operator,
        OpenParen,
        CloseParen,
        Comma,
        EOF,
    }
}
