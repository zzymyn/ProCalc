using System;

namespace ProCalc.Lib.MPIR
{
    public partial class MPZ
    {
		// Constructors:
        public MPZ(MPZ a)
            : base(IntPtr.Zero, true)
        {
            Alloc();
            MPIR.mpz_init_set(this, a);
        }

        public MPZ(long a)
            : base(IntPtr.Zero, true)
        {
            Alloc();
            MPIR.mpz_init_set_si(this, a);
        }

        public MPZ(ulong a)
            : base(IntPtr.Zero, true)
        {
            Alloc();
            MPIR.mpz_init_set_ui(this, a);
        }

        public MPZ(double a)
            : base(IntPtr.Zero, true)
        {
            Alloc();
            MPIR.mpz_init_set_d(this, a);
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
            MPIR.mpz_neg(r, a);
            return r;
        }


		// Binary ops:
        public static MPZ operator +(MPZ a, MPZ b)
        {
            var r = new MPZ();
            MPIR.mpz_add(r, a, b);
            return r;
        }

        public static MPZ operator -(MPZ a, MPZ b)
        {
            var r = new MPZ();
            MPIR.mpz_sub(r, a, b);
            return r;
        }

        public static MPZ operator *(MPZ a, MPZ b)
        {
            var r = new MPZ();
            MPIR.mpz_mul(r, a, b);
            return r;
        }

        public static MPZ operator /(MPZ a, MPZ b)
        {
            var r = new MPZ();
            MPIR.mpz_tdiv_q(r, a, b);
            return r;
        }

        public static MPZ operator %(MPZ a, MPZ b)
        {
            var r = new MPZ();
            MPIR.mpz_tdiv_r(r, a, b);
            return r;
        }

        public static MPZ operator &(MPZ a, MPZ b)
        {
            var r = new MPZ();
            MPIR.mpz_and(r, a, b);
            return r;
        }

        public static MPZ operator |(MPZ a, MPZ b)
        {
            var r = new MPZ();
            MPIR.mpz_ior(r, a, b);
            return r;
        }

        public static MPZ operator ^(MPZ a, MPZ b)
        {
            var r = new MPZ();
            MPIR.mpz_xor(r, a, b);
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
