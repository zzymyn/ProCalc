namespace ProCalc.Lib.Syntax
{
    public enum TokenType
    {
        Invalid,
        Whitespace,
        Number,
        Identifier,
        Operator,
        UnaryOperator,
        OpenParen,
        CloseParen,
        Comma,
        EOF,
    }
}
