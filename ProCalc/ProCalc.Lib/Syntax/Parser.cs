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
        private Evaluator m_Evaluator = new Evaluator();
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
                throw new UnexpectedTokenParsingException(e.Current, TokenType.EOF);
            HandleEof(e.Current);
            if (!m_Evaluator.HasResult)
                throw new ParsingException("internal error", e.Current);
            return m_Evaluator.Result;
        }

        private void EvaluateExpression(IEnumerator<Token> e)
        {
            while (true)
            {
                // operators at start of expression; must be a unary:
                while (e.Current.Type == TokenType.Operator)
                {
                    if (IsUnary(e.Current))
                    {
                        HandleUnaryOperator(new Token(TokenType.UnaryOperator, e.Current));
                        e.MoveNext();
                    }
                    else
                    {
                        throw new ParsingException($"invalid unary operator: {e.Current.Value}", e.Current);
                    }
                }

                switch (e.Current.Type)
                {
                    case TokenType.Number:
                        HandleNumber(e.Current);
                        e.MoveNext();
                        break;
                    case TokenType.Identifier:
                        // can either be a function call or a variable, need to look-ahead to find out:
                        {
                            var ident = e.Current;
                            e.MoveNext();
                            if (e.Current.Type == TokenType.OpenParen)
                            {
                                // function call
                                EvaluateFunctionCall(ident, e);
                            }
                            else
                            {
                                // variable
                                HandleVariable(ident);
                            }
                        }
                        break;
                    case TokenType.OpenParen:
                        HandleOpenParen(e.Current);
                        e.MoveNext();
                        EvaluateExpression(e);
                        if (e.Current.Type == TokenType.CloseParen)
                        {
                            HandleCloseParen(e.Current);
                            e.MoveNext();
                        }
                        else if (e.Current.Type == TokenType.EOF)
                        {
                            HandleCloseParen(e.Current);
                        }
                        else
                        {
                            throw new UnexpectedTokenParsingException(e.Current, TokenType.CloseParen);
                        }
                        break;
                    default:
                        throw new UnexpectedTokenParsingException(e.Current, TokenType.UnaryOperator, TokenType.Number, TokenType.Identifier, TokenType.OpenParen);
                }

                if (e.Current.Type != TokenType.Operator)
                    break;

                HandleOperator(e.Current);
                e.MoveNext();
            }
        }

        private void EvaluateFunctionCall(Token ident, IEnumerator<Token> e)
        {
            Debug.Assert(e.Current.Type == TokenType.OpenParen);

            int arity = 0;

            HandleOpenParen(e.Current);
            e.MoveNext();
            while (true)
            {
                ++arity;
                EvaluateExpression(e);
                if (e.Current.Type == TokenType.CloseParen)
                {
                    HandleCloseParen(e.Current);
                    e.MoveNext();
                    break;
                }
                else if (e.Current.Type == TokenType.EOF)
                {
                    HandleCloseParen(e.Current);
                    break;
                }
                else if (e.Current.Type == TokenType.Comma)
                {
                    HandleComma(e.Current);
                    e.MoveNext();
                }
                else
                {
                    throw new UnexpectedTokenParsingException(e.Current, TokenType.CloseParen, TokenType.Comma);
                }
            }

            m_Evaluator.ApplyFunction(ident, arity);
        }

        private void HandleNumber(Token t)
        {
            m_Evaluator.PushNumber(t);
        }

        private void HandleVariable(Token t)
        {
            m_Evaluator.PushVariable(t);
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
                        m_Evaluator.ApplyOperator(m_Ops.Pop());
                        break;
                    case TokenType.UnaryOperator:
                        m_Evaluator.ApplyUnaryOperator(m_Ops.Pop());
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

        private void HandleComma(Token t)
        {
            Debug.Assert(t.Type == TokenType.Comma);
            while (m_Ops.Count > 0)
            {
                switch (m_Ops.Peek().Type)
                {
                    case TokenType.OpenParen:
                        return;
                    case TokenType.Operator:
                        m_Evaluator.ApplyOperator(m_Ops.Pop());
                        break;
                    case TokenType.UnaryOperator:
                        m_Evaluator.ApplyUnaryOperator(m_Ops.Pop());
                        break;
                    default:
                        throw new ParsingException("internal error", t);
                }
            }

            throw new ParsingException("no matching function call", t);
        }

        private void HandleCloseParen(Token t)
        {
            Debug.Assert(t.Type == TokenType.CloseParen || t.Type == TokenType.EOF);
            while (m_Ops.Count > 0)
            {
                switch (m_Ops.Peek().Type)
                {
                    case TokenType.OpenParen:
                        m_Ops.Pop();
                        return;
                    case TokenType.Operator:
                        m_Evaluator.ApplyOperator(m_Ops.Pop());
                        break;
                    case TokenType.UnaryOperator:
                        m_Evaluator.ApplyUnaryOperator(m_Ops.Pop());
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
                        m_Evaluator.ApplyOperator(m_Ops.Pop());
                        break;
                    case TokenType.UnaryOperator:
                        m_Evaluator.ApplyUnaryOperator(m_Ops.Pop());
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
