using System;
using System.Collections.Generic;
using ProCalc.Lib.GMP;

namespace ProCalc.Lib.Syntax
{
    /// <summary>
    /// Simple stack-based evaluator, expects calls in postfix order, eg 1 1 + for "1 + 1".
    /// </summary>
    internal partial class Evaluator
    {
        private Stack<object> m_Vals = new Stack<object>();

        public bool HasResult
        {
            get { return m_Vals.Count == 1; }
        }

        public object Result
        {
            get { return m_Vals.Peek(); }
        }

        public Evaluator()
        {
        }

        public void PushNumber(Token t)
        {
            m_Vals.Push(ParseNumber(t));
        }

        // TODO: use a State class/interface for looking up variables/constants
        public void PushVariable(Token t)
        {
            switch (t.Value)
            {
                case "pi":
                    m_Vals.Push(new MPQ("314159265358979323846264338327950288419716939937510582/100000000000000000000000000000000000000000000000000000"));
                    break;
                default:
                    throw new ParsingException($"unknown variable: {t.Value}", t);
            }
        }

        // TODO: better function lookup:
        public void ApplyFunction(Token t, int arity)
        {
            if (arity == 1)
            {
                var a = m_Vals.Pop();
                switch (t.Value)
                {
                    case "sqrt":
                        a = Sqrt(a);
                        break;
                    default:
                        goto error;
                }
                m_Vals.Push(a);
                return;
            }

            error:
            throw new ParsingException($"unknown function: {t.Value}/{arity}", t);
        }

        public void ApplyOperator(Token t)
        {
            var b = m_Vals.Pop();
            var a = m_Vals.Pop();

            switch (t.Value)
            {
                case "*":
                    m_Vals.Push(Mul(a, b));
                    break;
                case "/":
                    m_Vals.Push(Div(a, b));
                    break;
                case "+":
                    m_Vals.Push(Add(a, b));
                    break;
                case "-":
                    m_Vals.Push(Sub(a, b));
                    break;
                default:
                    throw new ParsingException("internal error", t);
            }
        }

        public void ApplyUnaryOperator(Token t)
        {
            var a = m_Vals.Pop();

            switch (t.Value)
            {
                case "+":
                    m_Vals.Push(a);
                    return;
                case "-":
                    m_Vals.Push(Negate(a));
                    return;
                default:
                    throw new ParsingException("internal error", t);
            }
        }

        private MPQ ParseNumber(Token t)
        {
            var num = new MPZ(0);
            var den = new MPZ(1);

            bool afterDec = false;

            foreach (var c in t.Value)
            {
                switch (c)
                {
                    case '.':
                        afterDec = true;
                        break;
                    default:
                        break;
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        num.Mul(10).Add(c - '0');
                        if (afterDec)
                            den.Mul(10);
                        break;
                }
            }

            return new MPQ(num, den);
        }

        private static object Negate(object a)
        {
            var aQ = a as MPQ;
            var aF = a as MPFR;

            if (aQ != null)
            {
                return -aQ;
            }
            else if (aF != null)
            {
                return -aF;
            }

            throw new Exception("internal error");
        }

        private static object Sqrt(object a)
        {
            var aQ = a as MPQ;
            var aF = a as MPFR;

            if (aQ != null)
            {
                return ((MPFR)aQ).Sqrt();
            }
            else if (aF != null)
            {
                return aF.Sqrt();
            }

            throw new Exception("internal error");
        }
    }
}
