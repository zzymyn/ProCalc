using System;

namespace ProCalc.Lib.GMP
{
    public partial class MPQ
    {
        // Constructors:
        public MPQ(int a) : this()
        {
            GMP.mpq_set_si(ref S, a, 1);
            GMP.mpq_canonicalize(ref S);
        }

        public MPQ(int a, uint b) : this()
        {
            GMP.mpq_set_si(ref S, a, b);
            GMP.mpq_canonicalize(ref S);
        }

        public MPQ(uint a) : this()
        {
            GMP.mpq_set_ui(ref S, a, 1);
            GMP.mpq_canonicalize(ref S);
        }

        public MPQ(uint a, uint b) : this()
        {
            GMP.mpq_set_ui(ref S, a, b);
            GMP.mpq_canonicalize(ref S);
        }

        public MPQ(long a) : this(a.ToString())
        {
        }

        public MPQ(long a, ulong b) : this(string.Format("{0}/{1}", a, b))
        {
        }

        public MPQ(ulong a) : this(a.ToString())
        {
        }

        public MPQ(ulong a, ulong b) : this(string.Format("{0}/{1}", a, b))
        {
        }

        public MPQ(double a) : this()
        {
            GMP.mpq_set_d(ref S, a);
            GMP.mpq_canonicalize(ref S);
        }

        internal MPQ(ref GMP.mpq_t a) : this()
        {
            GMP.mpq_set(ref S, ref a);
        }

        public MPQ(MPQ a) : this(ref a.S)
        {
        }

        internal MPQ(ref GMP.mpz_t a) : this()
        {
            GMP.mpq_set_z(ref S, ref a);
            GMP.mpq_canonicalize(ref S);
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
            GMP.mpq_neg(ref r.S, ref a.S);
            return r;
        }

        public static MPQ operator +(MPQ a, MPQ b)
        {
            var r = new MPQ();
            GMP.mpq_add(ref r.S, ref a.S, ref b.S);
            return r;
        }

        public static MPQ operator -(MPQ a, MPQ b)
        {
            var r = new MPQ();
            GMP.mpq_sub(ref r.S, ref a.S, ref b.S);
            return r;
        }

        public static MPQ operator *(MPQ a, MPQ b)
        {
            var r = new MPQ();
            GMP.mpq_mul(ref r.S, ref a.S, ref b.S);
            return r;
        }

        public static MPQ operator /(MPQ a, MPQ b)
        {
            var r = new MPQ();
            GMP.mpq_div(ref r.S, ref a.S, ref b.S);
            return r;
        }

        // Funcs:
        public MPQ GetAbs()
        {
            var r = new MPQ();
            GMP.mpq_abs(ref r.S, ref S);
            return r;
        }

        public MPQ GetInv()
        {
            var r = new MPQ();
            GMP.mpq_inv(ref r.S, ref S);
            return r;
        }

        public MPQ Add(MPQ b)
        {
            GMP.mpq_add(ref S, ref S, ref b.S);
            return this;
        }

        internal MPQ Add(ref GMP.mpq_t b)
        {
            GMP.mpq_add(ref S, ref S, ref b);
            return this;
        }

        public MPQ Sub(MPQ b)
        {
            GMP.mpq_sub(ref S, ref S, ref b.S);
            return this;
        }

        internal MPQ Sub(ref GMP.mpq_t b)
        {
            GMP.mpq_sub(ref S, ref S, ref b);
            return this;
        }

        public MPQ Mul(MPQ b)
        {
            GMP.mpq_mul(ref S, ref S, ref b.S);
            return this;
        }

        internal MPQ Mul(ref GMP.mpq_t b)
        {
            GMP.mpq_mul(ref S, ref S, ref b);
            return this;
        }

        public MPQ Div(MPQ b)
        {
            GMP.mpq_div(ref S, ref S, ref b.S);
            return this;
        }

        internal MPQ Div(ref GMP.mpq_t b)
        {
            GMP.mpq_div(ref S, ref S, ref b);
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
