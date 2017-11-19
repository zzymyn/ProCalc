using System;
using System.Runtime.InteropServices;

namespace ProCalc.Lib.MPIR
{
    internal static partial class MPIR
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
    }
}
