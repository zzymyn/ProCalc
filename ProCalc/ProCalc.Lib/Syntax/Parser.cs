using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProCalc.Lib.MPIR;

namespace ProCalc.Lib.Syntax
{
    public class Parser
    {
        private Stack<MPQ> m_Vals = new Stack<MPQ>();
        private Stack<Token> m_Ops = new Stack<Token>();

        private Parser()
        {
        }

        public static MPQ Evaluate(string expression)
        {
            return new Parser().EvaluateExpression(Lexer.Lex(expression));
        }

        private MPQ EvaluateExpression(IEnumerable<Token> tokens)
        {
            var e = tokens.GetEnumerator();
            e.MoveNext();
            EvaluateExpression(e);
            if (e.Current.Type != TokenType.EOF)
                throw new ParsingException($"unexpected token: {e.Current.Type}", e.Current);
            HandleEof(e.Current);
            if (m_Vals.Count != 1)
                throw new ParsingException("internal error", e.Current);
            return m_Vals.Peek();
        }

        private void EvaluateExpression(IEnumerator<Token> e)
        {
            switch (e.Current.Type)
            {
                case TokenType.Number:
                    HandleNumber(e.Current);
                    e.MoveNext();
                    if (e.Current.Type == TokenType.Operator)
                    {
                        HandleOperator(e.Current);
                        e.MoveNext();
                        EvaluateExpression(e);
                    }
                    break;
                case TokenType.Operator:
                    // operator at start of expression must be a unary:
                    if (IsUnary(e.Current))
                    {
                        HandleUnaryOperator(new Token(TokenType.UnaryOperator, e.Current));
                        e.MoveNext();
                        EvaluateExpression(e);
                    }
                    else
                    {
                        throw new ParsingException($"invalid unary operator: {e.Current.Value}", e.Current);
                    }
                    break;
                case TokenType.OpenParen:
                    HandleOpenParen(e.Current);
                    e.MoveNext();
                    EvaluateExpression(e);
                    e.MoveNext();
                    if (e.Current.Type != TokenType.CloseParen)
                        throw new ParsingException("missing closing parenthesis", e.Current);
                    HandleCloseParen(e.Current);
                    break;
                case TokenType.EOF:
                    break;
                default:
                    throw new ParsingException($"unexpected token: {e.Current.Type}", e.Current);
            }
        }

        private void EvalNumber(Token t)
        {
            m_Vals.Push(new MPQ(t.Value));
        }

        private void EvalOperator(Token t)
        {
            var b = m_Vals.Pop();

            switch (t.Value)
            {
                case "*":
                    m_Vals.Peek().Mul(b);
                    break;
                case "/":
                    m_Vals.Peek().Div(b);
                    break;
                case "+":
                    m_Vals.Peek().Add(b);
                    break;
                case "-":
                    m_Vals.Peek().Sub(b);
                    break;
                default:
                    throw new ParsingException("internal error", t);
            }
        }

        private void EvalUnaryOperator(Token t)
        {
            switch (t.Value)
            {
                case "+":
                    // nothing
                    return;
                case "-":
                    m_Vals.Peek().Negate();
                    return;
                default:
                    throw new ParsingException("internal error", t);
            }
        }

        private void HandleNumber(Token t)
        {
            Debug.Assert(t.Type == TokenType.Number);
            EvalNumber(t);
        }

        private void HandleOperator(Token t)
        {
            Debug.Assert(t.Type == TokenType.Operator);
            var precedence = GetPrecedence(t);

            while (m_Ops.Count > 0)
            {
                switch (m_Ops.Peek().Type)
                {
                    case TokenType.OpenParen:
                        goto done;
                    case TokenType.Operator:
                        if (GetPrecedence(m_Ops.Peek()) < precedence)
                            goto done;
                        EvalOperator(m_Ops.Pop());
                        break;
                    case TokenType.UnaryOperator:
                        EvalUnaryOperator(m_Ops.Pop());
                        break;
                    default:
                        throw new ParsingException("internal error", t);
                }
            }

            done:
            m_Ops.Push(t);
        }

        private void HandleUnaryOperator(Token t)
        {
            Debug.Assert(t.Type == TokenType.UnaryOperator);
            m_Ops.Push(t);
        }

        private void HandleOpenParen(Token t)
        {
            Debug.Assert(t.Type == TokenType.OpenParen);
            m_Ops.Push(t);
        }

        private void HandleCloseParen(Token t)
        {
            Debug.Assert(t.Type == TokenType.CloseParen);
            while (m_Ops.Count > 0)
            {
                switch (m_Ops.Peek().Type)
                {
                    case TokenType.OpenParen:
                        m_Ops.Pop();
                        return;
                    case TokenType.Operator:
                        EvalOperator(m_Ops.Pop());
                        break;
                    case TokenType.UnaryOperator:
                        EvalUnaryOperator(m_Ops.Pop());
                        break;
                    default:
                        throw new ParsingException("internal error", t);
                }
            }

            throw new ParsingException("unmatched closing parenthesis", t);
        }

        private void HandleEof(Token t)
        {
            Debug.Assert(t.Type == TokenType.EOF);
            while (m_Ops.Count > 0)
            {
                switch (m_Ops.Peek().Type)
                {
                    case TokenType.OpenParen:
                        throw new ParsingException("missing closing parenthesis", t);
                    case TokenType.Operator:
                        EvalOperator(m_Ops.Pop());
                        break;
                    case TokenType.UnaryOperator:
                        EvalUnaryOperator(m_Ops.Pop());
                        break;
                    default:
                        throw new ParsingException("internal error", t);
                }
            }
        }

        private static bool IsUnary(Token t)
        {
            switch (t.Value)
            {
                case "+":
                case "-":
                    return true;
                default:
                    return false;
            }
        }

        private static int GetPrecedence(Token t)
        {
            if (t.Type != TokenType.Operator)
                throw new ParsingException("internal error", t);

            switch (t.Value)
            {
                case "*":
                case "/":
                    return 4;
                case "+":
                case "-":
                    return 3;
                default:
                    throw new ParsingException("internal error", t);
            }
        }
    }
}
