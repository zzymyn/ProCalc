using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProCalc.Lib.MPIR
{
    public partial class MPQ : IDisposable, IComparable<MPQ>, IEquatable<MPQ>
    {
        internal MPIR.mpq_t S;

        public MPZ Numerator
        {
            get { return new MPZ(ref S._mp_num); }
        }

        public MPZ Denominator
        {
            get { return new MPZ(ref S._mp_den); }
        }

        public MPQ()
        {
            MPIR.mpq_init(ref S);
        }

        private MPQ(ref MPIR.mpq_t a)
            : this()
        {
            MPIR.mpq_set(ref S, ref a);
        }

        public MPQ(MPQ a)
            : this(ref a.S)
        {
        }

        public MPQ(string a)
            : this(a, 10)
        {
        }

        public MPQ(string a, int numericBase)
            : this()
        {
            var r = MPIR.mpq_set_str(ref S, a, numericBase);
            if (r != 0)
                throw new FormatException("not a number");
            MPIR.mpq_canonicalize(ref S);
        }

        ~MPQ()
        {
            Free();
        }

        public int CompareTo(MPQ a)
        {
            if (ReferenceEquals(a, null))
                return 1;
            if (MPIR.mpq_equal(ref S, ref a.S) != 0)
                return 0;
            return MPIR.mpq_cmp(ref S, ref a.S);
        }

        // TODO: make better
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as MPQ);
        }

        public bool Equals(MPQ a)
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
            var size = (int)MPIR.mpz_sizeinbase(ref S._mp_num, numericBase) + (int)MPIR.mpz_sizeinbase(ref S._mp_den, numericBase) + 2;
            var sb = new StringBuilder(size + 1);
            MPIR.mpq_get_str(sb, numericBase, ref S);
            return sb.ToString();
        }

        public void Dispose()
        {
            Free();
            GC.SuppressFinalize(this);
        }

        private void Free()
        {
            MPIR.mpq_clear(ref S);
        }

    }
}
