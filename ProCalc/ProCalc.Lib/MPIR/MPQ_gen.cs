using System;

namespace ProCalc.Lib.MPIR
{
    public partial class MPQ
    {
        // Constructors:
        public MPQ(long a) : this()
        {
            MPIR.mpq_set_si(ref S, a, 1ul);
            MPIR.mpq_canonicalize(ref S);
        }

        public MPQ(long a, ulong b) : this()
        {
            MPIR.mpq_set_si(ref S, a, b);
            MPIR.mpq_canonicalize(ref S);
        }

        public MPQ(ulong a) : this()
        {
            MPIR.mpq_set_ui(ref S, a, 1ul);
            MPIR.mpq_canonicalize(ref S);
        }

        public MPQ(ulong a, ulong b) : this()
        {
            MPIR.mpq_set_ui(ref S, a, b);
            MPIR.mpq_canonicalize(ref S);
        }

        public MPQ(double a) : this()
        {
            MPIR.mpq_set_d(ref S, a);
            MPIR.mpq_canonicalize(ref S);
        }

        internal MPQ(ref MPIR.mpq_t a) : this()
        {
            MPIR.mpq_set(ref S, ref a);
        }

        public MPQ(MPQ a) : this(ref a.S)
        {
        }

        internal MPQ(ref MPIR.mpz_t a) : this()
        {
            MPIR.mpq_set_z(ref S, ref a);
            MPIR.mpq_canonicalize(ref S);
        }

        public MPQ(MPZ a) : this(ref a.S)
        {
        }

        // Conversions:
        public static implicit operator MPQ(MPZ a)
        {
            return new MPQ(a);
        }

        public static implicit operator MPQ(int a)
        {
            return new MPQ(a);
        }

        public static implicit operator MPQ(uint a)
        {
            return new MPQ(a);
        }

        public static implicit operator MPQ(long a)
        {
            return new MPQ(a);
        }

        public static implicit operator MPQ(ulong a)
        {
            return new MPQ(a);
        }

        public static explicit operator MPQ(double a)
        {
            return new MPQ(a);
        }

        // Operators:
        public static MPQ operator -(MPQ a)
        {
            var r = new MPQ();
            MPIR.mpq_neg(ref r.S, ref a.S);
            return r;
        }

        public static MPQ operator +(MPQ a, MPQ b)
        {
            var r = new MPQ();
            MPIR.mpq_add(ref r.S, ref a.S, ref b.S);
            return r;
        }

        public static MPQ operator -(MPQ a, MPQ b)
        {
            var r = new MPQ();
            MPIR.mpq_sub(ref r.S, ref a.S, ref b.S);
            return r;
        }

        public static MPQ operator *(MPQ a, MPQ b)
        {
            var r = new MPQ();
            MPIR.mpq_mul(ref r.S, ref a.S, ref b.S);
            return r;
        }

        public static MPQ operator /(MPQ a, MPQ b)
        {
            var r = new MPQ();
            MPIR.mpq_div(ref r.S, ref a.S, ref b.S);
            return r;
        }

        // Funcs:
        public MPQ GetAbs()
        {
            var r = new MPQ();
            MPIR.mpq_abs(ref r.S, ref S);
            return r;
        }

        public MPQ GetInv()
        {
            var r = new MPQ();
            MPIR.mpq_inv(ref r.S, ref S);
            return r;
        }

        public MPQ Add(MPQ b)
        {
            MPIR.mpq_add(ref S, ref S, ref b.S);
            return this;
        }

        internal MPQ Add(ref MPIR.mpq_t b)
        {
            MPIR.mpq_add(ref S, ref S, ref b);
            return this;
        }

        public MPQ Sub(MPQ b)
        {
            MPIR.mpq_sub(ref S, ref S, ref b.S);
            return this;
        }

        internal MPQ Sub(ref MPIR.mpq_t b)
        {
            MPIR.mpq_sub(ref S, ref S, ref b);
            return this;
        }

        public MPQ Mul(MPQ b)
        {
            MPIR.mpq_mul(ref S, ref S, ref b.S);
            return this;
        }

        internal MPQ Mul(ref MPIR.mpq_t b)
        {
            MPIR.mpq_mul(ref S, ref S, ref b);
            return this;
        }

        public MPQ Div(MPQ b)
        {
            MPIR.mpq_div(ref S, ref S, ref b.S);
            return this;
        }

        internal MPQ Div(ref MPIR.mpq_t b)
        {
            MPIR.mpq_div(ref S, ref S, ref b);
            return this;
        }

        // Comparison ops:
        public static bool operator <(MPQ a, MPQ b)
        {
            return a.CompareTo(b) < 0;
        }

        public static bool operator >(MPQ a, MPQ b)
        {
            return a.CompareTo(b) > 0;
        }

        public static bool operator <=(MPQ a, MPQ b)
        {
            return a.CompareTo(b) <= 0;
        }

        public static bool operator >=(MPQ a, MPQ b)
        {
            return a.CompareTo(b) >= 0;
        }

        public static bool operator ==(MPQ a, MPQ b)
        {
            return a.CompareTo(b) == 0;
        }

        public static bool operator !=(MPQ a, MPQ b)
        {
            return a.CompareTo(b) != 0;
        }

    }
}
