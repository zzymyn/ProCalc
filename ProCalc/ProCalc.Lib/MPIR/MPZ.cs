using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProCalc.Lib.MPIR
{
    /// <summary>
    /// Wrapper around MPIR's mpz_t bigint class.
    /// </summary>
    public partial class MPZ : IDisposable, IComparable<MPZ>, IEquatable<MPZ>
    {
        internal MPIR.mpz_t S;

        public MPZ()
        {
            MPIR.mpz_init(ref S);
        }

        internal MPZ(ref MPIR.mpz_t a)
        {
            MPIR.mpz_init_set(ref S, ref a);
        }

        public MPZ(MPZ a)
            : this(ref a.S)
        {
        }

        public MPZ(MPQ a)
            : this()
        {
            MPIR.mpz_set_q(ref S, ref a.S);
        }

        public MPZ(MPF a)
            : this()
        {
            MPIR.mpz_set_f(ref S, ref a.S);
        }

        public MPZ(string a)
            : this(a, 10)
        {
        }

        public MPZ(string a, int numericBase)
        {
            var r = MPIR.mpz_init_set_str(ref S, a, numericBase);
            if (r != 0)
                throw new FormatException("not a number");
        }

        ~MPZ()
        {
            Free();
        }

        public MPZ DivWithRem(MPZ b, out MPZ rem)
        {
            var r = new MPZ();
            rem = new MPZ();
            MPIR.mpz_cdiv_qr(ref r.S, ref rem.S, ref S, ref b.S);
            return r;
        }

        public int CompareTo(MPZ a)
        {
            if (ReferenceEquals(a, null))
                return 1;
            return MPIR.mpz_cmp(ref S, ref a.S);
        }

        // TODO: make better
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as MPZ);
        }

        public bool Equals(MPZ a)
        {
            if (ReferenceEquals(a, null))
                return false;
            return CompareTo(a) == 0;
        }

        public override string ToString()
        {
            return ToString(10);
        }

        public string ToString(int numericBase)
        {
            var size = (int)MPIR.mpz_sizeinbase(ref S, numericBase) + 1;
            var sb = new StringBuilder(size);
            MPIR.mpz_get_str(sb, numericBase, ref S);
            return sb.ToString();
        }

        public double ToDouble()
        {
            return MPIR.mpz_get_d(ref S);
        }

        public long ToInt64()
        {
            if (MPIR.mpz_fits_si_p(ref S) == 0)
                throw new OverflowException();
            return MPIR.mpz_get_si(ref S);
        }

        public ulong ToUInt64()
        {
            if (MPIR.mpz_fits_ui_p(ref S) == 0)
                throw new OverflowException();
            return MPIR.mpz_get_ui(ref S);
        }

        public void Dispose()
        {
            Free();
            GC.SuppressFinalize(this);
        }

        private void Free()
        {
            MPIR.mpz_clear(ref S);
        }
    }
}
