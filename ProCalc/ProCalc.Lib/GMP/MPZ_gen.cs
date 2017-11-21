using System;

namespace ProCalc.Lib.GMP
{
    public partial class MPZ
    {
        // Constructors:
        public MPZ(int a) 
        {
            GMP.mpz_init_set_si(ref S, a);
        }

        public MPZ(uint a) 
        {
            GMP.mpz_init_set_ui(ref S, a);
        }

        public MPZ(long a) : this(a.ToString())
        {
        }

        public MPZ(ulong a) : this(a.ToString())
        {
        }

        internal MPZ(ref GMP.mpz_t a) 
        {
            GMP.mpz_init_set(ref S, ref a);
        }

        public MPZ(MPZ a) : this(ref a.S)
        {
        }

        internal MPZ(ref GMP.mpq_t a) : this()
        {
            GMP.mpz_set_q(ref S, ref a);
        }

        public MPZ(MPQ a) : this(ref a.S)
        {
        }

        internal MPZ(ref GMP.mpf_t a) : this()
        {
            GMP.mpz_set_f(ref S, ref a);
        }

        public MPZ(MPF a) : this(ref a.S)
        {
        }

        internal MPZ(ref GMP.mpfr_t a) : this()
        {
            GMP.mpfr_get_z(ref S, ref a, MPFR.DefaultRnd);
        }

        public MPZ(MPFR a) : this(ref a.S)
        {
        }

        // Conversions:
        public static explicit operator MPZ(MPQ a)
        {
            return new MPZ(a);
        }

        public static explicit operator MPZ(MPF a)
        {
            return new MPZ(a);
        }

        public static explicit operator MPZ(MPFR a)
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

        // Operators:
        public static MPZ operator -(MPZ a)
        {
            var r = new MPZ();
            GMP.mpz_neg(ref r.S, ref a.S);
            return r;
        }

        public static MPZ operator +(MPZ a, MPZ b)
        {
            var r = new MPZ();
            GMP.mpz_add(ref r.S, ref a.S, ref b.S);
            return r;
        }

        public static MPZ operator -(MPZ a, MPZ b)
        {
            var r = new MPZ();
            GMP.mpz_sub(ref r.S, ref a.S, ref b.S);
            return r;
        }

        public static MPZ operator *(MPZ a, MPZ b)
        {
            var r = new MPZ();
            GMP.mpz_mul(ref r.S, ref a.S, ref b.S);
            return r;
        }

        public static MPZ operator /(MPZ a, MPZ b)
        {
            var r = new MPZ();
            GMP.mpz_tdiv_q(ref r.S, ref a.S, ref b.S);
            return r;
        }

        public static MPZ operator %(MPZ a, MPZ b)
        {
            var r = new MPZ();
            GMP.mpz_tdiv_r(ref r.S, ref a.S, ref b.S);
            return r;
        }

        public static MPZ operator &(MPZ a, MPZ b)
        {
            var r = new MPZ();
            GMP.mpz_and(ref r.S, ref a.S, ref b.S);
            return r;
        }

        public static MPZ operator |(MPZ a, MPZ b)
        {
            var r = new MPZ();
            GMP.mpz_ior(ref r.S, ref a.S, ref b.S);
            return r;
        }

        public static MPZ operator ^(MPZ a, MPZ b)
        {
            var r = new MPZ();
            GMP.mpz_xor(ref r.S, ref a.S, ref b.S);
            return r;
        }

        // Funcs:
        public MPZ Abs()
        {
            var r = new MPZ();
            GMP.mpz_abs(ref r.S, ref S);
            return r;
        }

        public MPZ Add(MPZ b)
        {
            GMP.mpz_add(ref S, ref S, ref b.S);
            return this;
        }

        internal MPZ Add(ref GMP.mpz_t b)
        {
            GMP.mpz_add(ref S, ref S, ref b);
            return this;
        }

        public MPZ Add(uint b)
        {
            GMP.mpz_add_ui(ref S, ref S, b);
            return this;
        }

        public MPZ Sub(MPZ b)
        {
            GMP.mpz_sub(ref S, ref S, ref b.S);
            return this;
        }

        internal MPZ Sub(ref GMP.mpz_t b)
        {
            GMP.mpz_sub(ref S, ref S, ref b);
            return this;
        }

        public MPZ Sub(uint b)
        {
            GMP.mpz_sub_ui(ref S, ref S, b);
            return this;
        }

        public MPZ Mul(MPZ b)
        {
            GMP.mpz_mul(ref S, ref S, ref b.S);
            return this;
        }

        internal MPZ Mul(ref GMP.mpz_t b)
        {
            GMP.mpz_mul(ref S, ref S, ref b);
            return this;
        }

        public MPZ Mul(int b)
        {
            GMP.mpz_mul_si(ref S, ref S, b);
            return this;
        }

        public MPZ Mul(uint b)
        {
            GMP.mpz_mul_ui(ref S, ref S, b);
            return this;
        }

        public MPZ Div(MPZ b)
        {
            GMP.mpz_tdiv_q(ref S, ref S, ref b.S);
            return this;
        }

        internal MPZ Div(ref GMP.mpz_t b)
        {
            GMP.mpz_tdiv_q(ref S, ref S, ref b);
            return this;
        }

        internal MPZ Div(uint b)
        {
            GMP.mpz_tdiv_q_ui(ref S, ref S, b);
            return this;
        }

        public MPZ Rem(MPZ b)
        {
            GMP.mpz_tdiv_r(ref S, ref S, ref b.S);
            return this;
        }

        internal MPZ Rem(ref GMP.mpz_t b)
        {
            GMP.mpz_tdiv_r(ref S, ref S, ref b);
            return this;
        }

        internal MPZ Rem(uint b)
        {
            GMP.mpz_tdiv_r_ui(ref S, ref S, b);
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
            if (ReferenceEquals(a, b))
                return true;
            if (ReferenceEquals(a, null))
                return false;
            if (ReferenceEquals(b, null))
                return false;
            return a.CompareTo(b) == 0;
        }

        public static bool operator !=(MPZ a, MPZ b)
        {
            if (ReferenceEquals(a, b))
                return false;
            if (ReferenceEquals(a, null))
                return true;
            if (ReferenceEquals(b, null))
                return true;
            return a.CompareTo(b) != 0;
        }

    }
}
