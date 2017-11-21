using System;

namespace ProCalc.Lib.GMP
{
    public partial class MPFR
    {
        // Constructors:
        public MPFR(int a) : this()
        {
            GMP.mpfr_set_si(ref S, a, DefaultRnd);
        }

        public MPFR(uint a) : this()
        {
            GMP.mpfr_set_ui(ref S, a, DefaultRnd);
        }

        public MPFR(float a) : this()
        {
            GMP.mpfr_set_flt(ref S, a, DefaultRnd);
        }

        public MPFR(double a) : this()
        {
            GMP.mpfr_set_d(ref S, a, DefaultRnd);
        }

        public MPFR(long a) : this(a.ToString())
        {
        }

        public MPFR(ulong a) : this(a.ToString())
        {
        }

        internal MPFR(ref GMP.mpfr_t a) : this()
        {
            GMP.mpfr_set(ref S, ref a, DefaultRnd);
        }

        public MPFR(MPFR a) : this(ref a.S)
        {
        }

        internal MPFR(ref GMP.mpz_t a) : this()
        {
            GMP.mpfr_set_z(ref S, ref a, DefaultRnd);
        }

        public MPFR(MPZ a) : this(ref a.S)
        {
        }

        internal MPFR(ref GMP.mpq_t a) : this()
        {
            GMP.mpfr_set_q(ref S, ref a, DefaultRnd);
        }

        public MPFR(MPQ a) : this(ref a.S)
        {
        }

        internal MPFR(ref GMP.mpf_t a) : this()
        {
            GMP.mpfr_set_f(ref S, ref a, DefaultRnd);
        }

        public MPFR(MPF a) : this(ref a.S)
        {
        }

        // Conversions:
        public static explicit operator MPFR(MPZ a)
        {
            return new MPFR(a);
        }

        public static explicit operator MPFR(MPQ a)
        {
            return new MPFR(a);
        }

        public static explicit operator MPFR(MPF a)
        {
            return new MPFR(a);
        }

        public static implicit operator MPFR(int a)
        {
            return new MPFR(a);
        }

        public static implicit operator MPFR(uint a)
        {
            return new MPFR(a);
        }

        public static implicit operator MPFR(long a)
        {
            return new MPFR(a);
        }

        public static implicit operator MPFR(ulong a)
        {
            return new MPFR(a);
        }

        public static explicit operator MPFR(float a)
        {
            return new MPFR(a);
        }

        public static explicit operator MPFR(double a)
        {
            return new MPFR(a);
        }

        // Operators:
        public static MPFR operator -(MPFR a)
        {
            var r = new MPFR();
            GMP.mpfr_neg(ref r.S, ref a.S, DefaultRnd);
            return r;
        }

        public static MPFR operator +(MPFR a, MPFR b)
        {
            var r = new MPFR();
            GMP.mpfr_add(ref r.S, ref a.S, ref b.S, DefaultRnd);
            return r;
        }

        public static MPFR operator -(MPFR a, MPFR b)
        {
            var r = new MPFR();
            GMP.mpfr_sub(ref r.S, ref a.S, ref b.S, DefaultRnd);
            return r;
        }

        public static MPFR operator *(MPFR a, MPFR b)
        {
            var r = new MPFR();
            GMP.mpfr_mul(ref r.S, ref a.S, ref b.S, DefaultRnd);
            return r;
        }

        public static MPFR operator /(MPFR a, MPFR b)
        {
            var r = new MPFR();
            GMP.mpfr_div(ref r.S, ref a.S, ref b.S, DefaultRnd);
            return r;
        }

        // Funcs:
        public MPFR Abs()
        {
            var r = new MPFR();
            GMP.mpfr_abs(ref r.S, ref S, DefaultRnd);
            return r;
        }

        public MPFR Sqrt()
        {
            var r = new MPFR();
            GMP.mpfr_sqrt(ref r.S, ref S, DefaultRnd);
            return r;
        }

        public MPFR CubicRoot()
        {
            var r = new MPFR();
            GMP.mpfr_cbrt(ref r.S, ref S, DefaultRnd);
            return r;
        }

        public MPFR Pow(MPFR b)
        {
            var r = new MPFR();
            GMP.mpfr_pow (ref r.S, ref S, ref b.S, DefaultRnd);
            return r;
        }

        public MPFR Log()
        {
            var r = new MPFR();
            GMP.mpfr_log(ref r.S, ref S, DefaultRnd);
            return r;
        }

        public MPFR Log2()
        {
            var r = new MPFR();
            GMP.mpfr_log2(ref r.S, ref S, DefaultRnd);
            return r;
        }

        public MPFR Log10()
        {
            var r = new MPFR();
            GMP.mpfr_log10(ref r.S, ref S, DefaultRnd);
            return r;
        }

        public MPFR Exp()
        {
            var r = new MPFR();
            GMP.mpfr_exp(ref r.S, ref S, DefaultRnd);
            return r;
        }

        public MPFR Exp2()
        {
            var r = new MPFR();
            GMP.mpfr_exp2(ref r.S, ref S, DefaultRnd);
            return r;
        }

        public MPFR Exp10()
        {
            var r = new MPFR();
            GMP.mpfr_exp10(ref r.S, ref S, DefaultRnd);
            return r;
        }

        public MPFR Cos()
        {
            var r = new MPFR();
            GMP.mpfr_cos(ref r.S, ref S, DefaultRnd);
            return r;
        }

        public MPFR Sin()
        {
            var r = new MPFR();
            GMP.mpfr_sin(ref r.S, ref S, DefaultRnd);
            return r;
        }

        public MPFR Tan()
        {
            var r = new MPFR();
            GMP.mpfr_tan(ref r.S, ref S, DefaultRnd);
            return r;
        }

        public MPFR Sec()
        {
            var r = new MPFR();
            GMP.mpfr_sec(ref r.S, ref S, DefaultRnd);
            return r;
        }

        public MPFR Csc()
        {
            var r = new MPFR();
            GMP.mpfr_csc(ref r.S, ref S, DefaultRnd);
            return r;
        }

        public MPFR Cot()
        {
            var r = new MPFR();
            GMP.mpfr_cot(ref r.S, ref S, DefaultRnd);
            return r;
        }

        public MPFR ACos()
        {
            var r = new MPFR();
            GMP.mpfr_acos(ref r.S, ref S, DefaultRnd);
            return r;
        }

        public MPFR ASin()
        {
            var r = new MPFR();
            GMP.mpfr_asin(ref r.S, ref S, DefaultRnd);
            return r;
        }

        public MPFR ATan()
        {
            var r = new MPFR();
            GMP.mpfr_atan(ref r.S, ref S, DefaultRnd);
            return r;
        }

        public MPFR ATan2(MPFR b)
        {
            var r = new MPFR();
            GMP.mpfr_atan2(ref r.S, ref S, ref b.S, DefaultRnd);
            return r;
        }

        public MPFR Cosh()
        {
            var r = new MPFR();
            GMP.mpfr_cosh(ref r.S, ref S, DefaultRnd);
            return r;
        }

        public MPFR Sinh()
        {
            var r = new MPFR();
            GMP.mpfr_sinh(ref r.S, ref S, DefaultRnd);
            return r;
        }

        public MPFR Tanh()
        {
            var r = new MPFR();
            GMP.mpfr_tanh(ref r.S, ref S, DefaultRnd);
            return r;
        }

        public MPFR Sech()
        {
            var r = new MPFR();
            GMP.mpfr_sech(ref r.S, ref S, DefaultRnd);
            return r;
        }

        public MPFR Csch()
        {
            var r = new MPFR();
            GMP.mpfr_csch(ref r.S, ref S, DefaultRnd);
            return r;
        }

        public MPFR Coth()
        {
            var r = new MPFR();
            GMP.mpfr_coth(ref r.S, ref S, DefaultRnd);
            return r;
        }

        public MPFR ACosh()
        {
            var r = new MPFR();
            GMP.mpfr_acosh(ref r.S, ref S, DefaultRnd);
            return r;
        }

        public MPFR ASinh()
        {
            var r = new MPFR();
            GMP.mpfr_asinh(ref r.S, ref S, DefaultRnd);
            return r;
        }

        public MPFR ATanh()
        {
            var r = new MPFR();
            GMP.mpfr_atanh(ref r.S, ref S, DefaultRnd);
            return r;
        }

        // Comparison ops:
        public static bool operator <(MPFR a, MPFR b)
        {
            return a.CompareTo(b) < 0;
        }

        public static bool operator >(MPFR a, MPFR b)
        {
            return a.CompareTo(b) > 0;
        }

        public static bool operator <=(MPFR a, MPFR b)
        {
            return a.CompareTo(b) <= 0;
        }

        public static bool operator >=(MPFR a, MPFR b)
        {
            return a.CompareTo(b) >= 0;
        }

        public static bool operator ==(MPFR a, MPFR b)
        {
            return a.CompareTo(b) == 0;
        }

        public static bool operator !=(MPFR a, MPFR b)
        {
            return a.CompareTo(b) != 0;
        }

    }
}
