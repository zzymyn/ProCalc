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

        internal MPZ(ref MPIR.mpz_t a) 
        {
            MPIR.mpz_init_set(ref S, ref a);
        }

        public MPZ(MPZ a) : this(ref a.S)
        {
        }

        internal MPZ(ref MPIR.mpq_t a) : this()
        {
            MPIR.mpz_set_q(ref S, ref a);
        }

        public MPZ(MPQ a) : this(ref a.S)
        {
        }

        internal MPZ(ref MPIR.mpf_t a) : this()
        {
            MPIR.mpz_set_f(ref S, ref a);
        }

        public MPZ(MPF a) : this(ref a.S)
        {
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

        // Operators:
        public static MPZ operator -(MPZ a)
        {
            var r = new MPZ();
            MPIR.mpz_neg(ref r.S, ref a.S);
            return r;
        }

        public static MPZ operator +(MPZ a, MPZ b)
        {
            var r = new MPZ();
            MPIR.mpz_add(ref r.S, ref a.S, ref b.S);
            return r;
        }

        public static MPZ operator +(MPZ a, ulong b)
        {
            var r = new MPZ();
            MPIR.mpz_add_ui(ref r.S, ref a.S, b);
            return r;
        }

        public static MPZ operator -(MPZ a, MPZ b)
        {
            var r = new MPZ();
            MPIR.mpz_sub(ref r.S, ref a.S, ref b.S);
            return r;
        }

        public static MPZ operator -(MPZ a, ulong b)
        {
            var r = new MPZ();
            MPIR.mpz_sub_ui(ref r.S, ref a.S, b);
            return r;
        }

        public static MPZ operator *(MPZ a, MPZ b)
        {
            var r = new MPZ();
            MPIR.mpz_mul(ref r.S, ref a.S, ref b.S);
            return r;
        }

        public static MPZ operator *(MPZ a, long b)
        {
            var r = new MPZ();
            MPIR.mpz_mul_si(ref r.S, ref a.S, b);
            return r;
        }

        public static MPZ operator *(MPZ a, ulong b)
        {
            var r = new MPZ();
            MPIR.mpz_mul_ui(ref r.S, ref a.S, b);
            return r;
        }

        public static MPZ operator /(MPZ a, MPZ b)
        {
            var r = new MPZ();
            MPIR.mpz_tdiv_q(ref r.S, ref a.S, ref b.S);
            return r;
        }

        public static MPZ operator /(MPZ a, ulong b)
        {
            var r = new MPZ();
            MPIR.mpz_tdiv_q_ui(ref r.S, ref a.S, b);
            return r;
        }

        public static MPZ operator %(MPZ a, MPZ b)
        {
            var r = new MPZ();
            MPIR.mpz_tdiv_r(ref r.S, ref a.S, ref b.S);
            return r;
        }

        public static MPZ operator %(MPZ a, ulong b)
        {
            var r = new MPZ();
            MPIR.mpz_tdiv_r_ui(ref r.S, ref a.S, b);
            return r;
        }

        public static MPZ operator &(MPZ a, MPZ b)
        {
            var r = new MPZ();
            MPIR.mpz_and(ref r.S, ref a.S, ref b.S);
            return r;
        }

        public static MPZ operator |(MPZ a, MPZ b)
        {
            var r = new MPZ();
            MPIR.mpz_ior(ref r.S, ref a.S, ref b.S);
            return r;
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

        public MPZ Add(MPZ b)
        {
            MPIR.mpz_add(ref S, ref S, ref b.S);
            return this;
        }

        internal MPZ Add(ref MPIR.mpz_t b)
        {
            MPIR.mpz_add(ref S, ref S, ref b);
            return this;
        }

        public MPZ Add(ulong b)
        {
            MPIR.mpz_add_ui(ref S, ref S, b);
            return this;
        }

        public MPZ Sub(MPZ b)
        {
            MPIR.mpz_sub(ref S, ref S, ref b.S);
            return this;
        }

        internal MPZ Sub(ref MPIR.mpz_t b)
        {
            MPIR.mpz_sub(ref S, ref S, ref b);
            return this;
        }

        public MPZ Sub(ulong b)
        {
            MPIR.mpz_sub_ui(ref S, ref S, b);
            return this;
        }

        public MPZ Mul(MPZ b)
        {
            MPIR.mpz_mul(ref S, ref S, ref b.S);
            return this;
        }

        internal MPZ Mul(ref MPIR.mpz_t b)
        {
            MPIR.mpz_mul(ref S, ref S, ref b);
            return this;
        }

        public MPZ Mul(long b)
        {
            MPIR.mpz_mul_si(ref S, ref S, b);
            return this;
        }

        public MPZ Mul(ulong b)
        {
            MPIR.mpz_mul_ui(ref S, ref S, b);
            return this;
        }

        public MPZ Div(MPZ b)
        {
            MPIR.mpz_tdiv_q(ref S, ref S, ref b.S);
            return this;
        }

        internal MPZ Div(ref MPIR.mpz_t b)
        {
            MPIR.mpz_tdiv_q(ref S, ref S, ref b);
            return this;
        }

        internal MPZ Div(ulong b)
        {
            MPIR.mpz_tdiv_q_ui(ref S, ref S, b);
            return this;
        }

        public MPZ Rem(MPZ b)
        {
            MPIR.mpz_tdiv_r(ref S, ref S, ref b.S);
            return this;
        }

        internal MPZ Rem(ref MPIR.mpz_t b)
        {
            MPIR.mpz_tdiv_r(ref S, ref S, ref b);
            return this;
        }

        internal MPZ Rem(ulong b)
        {
            MPIR.mpz_tdiv_r_ui(ref S, ref S, b);
            return this;
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
