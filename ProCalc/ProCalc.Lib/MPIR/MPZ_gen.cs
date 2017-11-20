using System;

namespace ProCalc.Lib.MPIR
{
    public partial class MPZ
    {
        // Constructors:
        public MPZ(long a)
        {
            MPIR.mpz_init_set_si(ref S, a);
        }

        public MPZ(ulong a)
        {
            MPIR.mpz_init_set_ui(ref S, a);
        }

        public MPZ(double a)
        {
            MPIR.mpz_init_set_d(ref S, a);
        }


        // Conversions:
        public static explicit operator MPZ(MPF a)
        {
            return new MPZ(a);
        }

        public static explicit operator MPZ(MPQ a)
        {
            return new MPZ(a);
        }

        public static implicit operator MPZ(int a)
        {
            return new MPZ(a);
        }

        public static implicit operator MPZ(uint a)
        {
            return new MPZ(a);
        }

        public static implicit operator MPZ(long a)
        {
            return new MPZ(a);
        }

        public static implicit operator MPZ(ulong a)
        {
            return new MPZ(a);
        }

        public static explicit operator MPZ(double a)
        {
            return new MPZ(a);
        }


        // Unary ops:
        public static MPZ operator -(MPZ a)
        {
            var r = new MPZ();
            MPIR.mpz_neg(ref r.S, ref a.S);
            return r;
        }


        // Binary ops:
        public MPZ Add(MPZ b)
        {
            MPIR.mpz_add(ref S, ref S, ref b.S);
            return this;
        }

        public static MPZ operator +(MPZ a, MPZ b)
        {
            var r = new MPZ();
            MPIR.mpz_add(ref r.S, ref a.S, ref b.S);
            return r;
        }

        public MPZ Sub(MPZ b)
        {
            MPIR.mpz_sub(ref S, ref S, ref b.S);
            return this;
        }

        public static MPZ operator -(MPZ a, MPZ b)
        {
            var r = new MPZ();
            MPIR.mpz_sub(ref r.S, ref a.S, ref b.S);
            return r;
        }

        public MPZ Mul(MPZ b)
        {
            MPIR.mpz_mul(ref S, ref S, ref b.S);
            return this;
        }

        public static MPZ operator *(MPZ a, MPZ b)
        {
            var r = new MPZ();
            MPIR.mpz_mul(ref r.S, ref a.S, ref b.S);
            return r;
        }

        public MPZ Div(MPZ b)
        {
            MPIR.mpz_tdiv_q(ref S, ref S, ref b.S);
            return this;
        }

        public static MPZ operator /(MPZ a, MPZ b)
        {
            var r = new MPZ();
            MPIR.mpz_tdiv_q(ref r.S, ref a.S, ref b.S);
            return r;
        }

        public MPZ Rem(MPZ b)
        {
            MPIR.mpz_tdiv_r(ref S, ref S, ref b.S);
            return this;
        }

        public static MPZ operator %(MPZ a, MPZ b)
        {
            var r = new MPZ();
            MPIR.mpz_tdiv_r(ref r.S, ref a.S, ref b.S);
            return r;
        }

        public MPZ And(MPZ b)
        {
            MPIR.mpz_and(ref S, ref S, ref b.S);
            return this;
        }

        public static MPZ operator &(MPZ a, MPZ b)
        {
            var r = new MPZ();
            MPIR.mpz_and(ref r.S, ref a.S, ref b.S);
            return r;
        }

        public MPZ Or(MPZ b)
        {
            MPIR.mpz_ior(ref S, ref S, ref b.S);
            return this;
        }

        public static MPZ operator |(MPZ a, MPZ b)
        {
            var r = new MPZ();
            MPIR.mpz_ior(ref r.S, ref a.S, ref b.S);
            return r;
        }

        public MPZ XOr(MPZ b)
        {
            MPIR.mpz_xor(ref S, ref S, ref b.S);
            return this;
        }

        public static MPZ operator ^(MPZ a, MPZ b)
        {
            var r = new MPZ();
            MPIR.mpz_xor(ref r.S, ref a.S, ref b.S);
            return r;
        }


        // Funcs:
        public MPZ GetAbs()
        {
            var r = new MPZ();
            MPIR.mpz_abs(ref r.S, ref S);
            return r;
        }


        // Comparison ops:
        public static bool operator <(MPZ a, MPZ b)
        {
            return a.CompareTo(b) < 0;
        }

        public static bool operator >(MPZ a, MPZ b)
        {
            return a.CompareTo(b) > 0;
        }

        public static bool operator <=(MPZ a, MPZ b)
        {
            return a.CompareTo(b) <= 0;
        }

        public static bool operator >=(MPZ a, MPZ b)
        {
            return a.CompareTo(b) >= 0;
        }

        public static bool operator ==(MPZ a, MPZ b)
        {
            return a.CompareTo(b) == 0;
        }

        public static bool operator !=(MPZ a, MPZ b)
        {
            return a.CompareTo(b) != 0;
        }

    }
}
