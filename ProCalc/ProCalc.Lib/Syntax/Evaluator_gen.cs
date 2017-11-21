using System;
using System.Collections.Generic;
using ProCalc.Lib.GMP;

namespace ProCalc.Lib.Syntax
{
    internal partial class Evaluator
    {
        private static object Add(object a, object b)
        {
            var aQ = a as MPQ;
            var aF = a as MPFR;
            var bQ = b as MPQ;
            var bF = b as MPFR;

            if (aQ != null)
            {
                if (bQ != null)
                {
                    return aQ + bQ;
                }
                else if (bF != null)
                {
                    return (MPFR)aQ + bF;
                }
            }
            else if (aF != null)
            {
                if (bQ != null)
                {
                    return aF + (MPFR)bQ;
                }
                else if (bF != null)
                {
                    return aF + bF;
                }
            }

            throw new Exception("internal error");
        }

        private static object Sub(object a, object b)
        {
            var aQ = a as MPQ;
            var aF = a as MPFR;
            var bQ = b as MPQ;
            var bF = b as MPFR;

            if (aQ != null)
            {
                if (bQ != null)
                {
                    return aQ - bQ;
                }
                else if (bF != null)
                {
                    return (MPFR)aQ - bF;
                }
            }
            else if (aF != null)
            {
                if (bQ != null)
                {
                    return aF - (MPFR)bQ;
                }
                else if (bF != null)
                {
                    return aF - bF;
                }
            }

            throw new Exception("internal error");
        }

        private static object Mul(object a, object b)
        {
            var aQ = a as MPQ;
            var aF = a as MPFR;
            var bQ = b as MPQ;
            var bF = b as MPFR;

            if (aQ != null)
            {
                if (bQ != null)
                {
                    return aQ * bQ;
                }
                else if (bF != null)
                {
                    return (MPFR)aQ * bF;
                }
            }
            else if (aF != null)
            {
                if (bQ != null)
                {
                    return aF * (MPFR)bQ;
                }
                else if (bF != null)
                {
                    return aF * bF;
                }
            }

            throw new Exception("internal error");
        }

        private static object Div(object a, object b)
        {
            var aQ = a as MPQ;
            var aF = a as MPFR;
            var bQ = b as MPQ;
            var bF = b as MPFR;

            if (aQ != null)
            {
                if (bQ != null)
                {
                    return aQ / bQ;
                }
                else if (bF != null)
                {
                    return (MPFR)aQ / bF;
                }
            }
            else if (aF != null)
            {
                if (bQ != null)
                {
                    return aF / (MPFR)bQ;
                }
                else if (bF != null)
                {
                    return aF / bF;
                }
            }

            throw new Exception("internal error");
        }

    }
}
