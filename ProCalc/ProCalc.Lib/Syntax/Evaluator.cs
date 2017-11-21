using ProCalc.Lib.GMP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCalc.Lib.Syntax
{
    /// <summary>
    /// Simple stack-based evaluator, expects calls in postfix order, eg 1 1 + for "1 + 1".
    /// </summary>
    internal class Evaluator
    {
        private Stack<MPQ> m_Vals = new Stack<MPQ>();

        public bool HasResult
        {
            get { return m_Vals.Count == 1; }
        }

        public MPQ Result
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
            try
            {
                return new MPQ(t.Value);
            }
            catch (FormatException)
            {
                throw new ParsingException("internal error", t);
            }
        }

        #region MPQ

        private static MPQ Add(MPQ a, MPQ b)
        {
            return a + b;
        }

        private static MPQ Sub(MPQ a, MPQ b)
        {
            return a - b;
        }

        private static MPQ Mul(MPQ a, MPQ b)
        {
            return a * b;
        }

        private static MPQ Div(MPQ a, MPQ b)
        {
            return a / b;
        }

        private static MPQ Negate(MPQ a)
        {
            return -a;
        }

        private static MPQ Abs(MPQ a)
        {
            return a.GetAbs();
        }

        #endregion
    }
}
