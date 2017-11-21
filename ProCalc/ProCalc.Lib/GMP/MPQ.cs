using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProCalc.Lib.GMP
{
    public partial class MPQ : IDisposable, IComparable<MPQ>, IEquatable<MPQ>
    {
        internal GMP.mpq_t S;

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
            GMP.mpq_init(ref S);
        }

        public MPQ(string a)
            : this(a, 10)
        {
        }

        public MPQ(string a, int numericBase)
            : this()
        {
            var r = GMP.mpq_set_str(ref S, a, numericBase);
            if (r != 0)
                throw new FormatException("not a number");
            GMP.mpq_canonicalize(ref S);
        }

        ~MPQ()
        {
            Free();
        }

        public int CompareTo(MPQ a)
        {
            if (ReferenceEquals(a, null))
                return 1;
            if (GMP.mpq_equal(ref S, ref a.S) != 0)
                return 0;
            return GMP.mpq_cmp(ref S, ref a.S);
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
            var size = (int)GMP.mpz_sizeinbase(ref S._mp_num, numericBase) + (int)GMP.mpz_sizeinbase(ref S._mp_den, numericBase) + 2;
            var sb = new StringBuilder(size + 1);
            GMP.mpq_get_str(sb, numericBase, ref S);
            return sb.ToString();
        }

        public void Dispose()
        {
            Free();
            GC.SuppressFinalize(this);
        }

        private void Free()
        {
            GMP.mpq_clear(ref S);
        }

    }
}
