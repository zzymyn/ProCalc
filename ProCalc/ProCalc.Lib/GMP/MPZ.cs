using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProCalc.Lib.GMP
{
    /// <summary>
    /// Wrapper around MPIR's mpz_t bigint class.
    /// </summary>
    public partial class MPZ : IDisposable, IComparable<MPZ>, IEquatable<MPZ>
    {
        internal GMP.mpz_t S;

        public MPZ()
        {
            GMP.mpz_init(ref S);
        }

        public MPZ(string a)
            : this(a, 10)
        {
        }

        public MPZ(string a, int numericBase)
        {
            var r = GMP.mpz_init_set_str(ref S, a, numericBase);
            if (r != 0)
                throw new FormatException("not a number");
        }

        ~MPZ()
        {
            Free();
        }

        public static MPZ Pow(uint a, uint b)
        {
            var r = new MPZ();
            GMP.mpz_ui_pow_ui(ref r.S, a, b);
            return r;
        }

        public MPZ DivWithRem(MPZ b, out MPZ rem)
        {
            var r = new MPZ();
            rem = new MPZ();
            GMP.mpz_cdiv_qr(ref r.S, ref rem.S, ref S, ref b.S);
            return r;
        }

        public int CompareTo(MPZ a)
        {
            if (ReferenceEquals(a, null))
                return 1;
            return GMP.mpz_cmp(ref S, ref a.S);
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
            return ToStringBuilder(numericBase).ToString();
        }

        public StringBuilder ToStringBuilder(int numericBase)
        {
            var size = (int)GMP.mpz_sizeinbase(ref S, numericBase) + 1;
            var sb = new StringBuilder(size);
            GMP.mpz_get_str(sb, numericBase, ref S);
            return sb;
        }

        public double ToDouble()
        {
            return GMP.mpz_get_d(ref S);
        }

        public int ToInt32()
        {
            if (GMP.mpz_fits_sint_p(ref S) == 0)
                throw new OverflowException();
            return GMP.mpz_get_si(ref S);
        }

        public uint ToUInt32()
        {
            if (GMP.mpz_fits_uint_p(ref S) == 0)
                throw new OverflowException();
            return GMP.mpz_get_ui(ref S);
        }

        public void Dispose()
        {
            Free();
            GC.SuppressFinalize(this);
        }

        private void Free()
        {
            GMP.mpz_clear(ref S);
        }
    }
}
