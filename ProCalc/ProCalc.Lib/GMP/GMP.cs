using System;
using System.Runtime.InteropServices;

namespace ProCalc.Lib.GMP
{
    internal static partial class GMP
    {
        [StructLayout(LayoutKind.Sequential)]
        internal struct mpz_t
        {
            internal int _mp_alloc;
            internal int _mp_size;
            internal IntPtr _mp_d;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct mpq_t
        {
            internal mpz_t _mp_num;
            internal mpz_t _mp_den;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct mpf_t
        {
            internal int _mp_prec;
            internal int _mp_size;
            internal int _mp_exp;
            internal IntPtr _mp_d;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct mpfr_t
        {
            internal int _mpfr_prec;
            internal int _mpfr_sign;
            internal int _mpfr_exp;
            internal IntPtr _mpfr_d;
        }

        internal enum mpfr_rnd_t : int
        {
            /// <summary>
            /// round to nearest, with ties to even
            /// </summary>
            MPFR_RNDN = 0,

            /// <summary>
            /// round toward zero
            /// </summary>
            MPFR_RNDZ,

            /// <summary>
            /// round toward +Inf
            /// </summary>
            MPFR_RNDU,

            /// <summary>
            /// round toward -Inf
            /// </summary>
            MPFR_RNDD,

            /// <summary>
            /// round away from zero
            /// </summary>
            MPFR_RNDA,

            /// <summary>
            /// faithful rounding (not implemented yet)
            /// </summary>
            MPFR_RNDF,

            /// <summary>
            /// round to nearest, with ties away from zero (mpfr_round)
            /// </summary>
            MPFR_RNDNA = -1
        }
    }
}
