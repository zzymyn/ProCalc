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
    public partial class MPZ : SafeHandle, IComparable<MPZ>, IEquatable<MPZ>
    {
        public override bool IsInvalid
        {
            get
            {
                return handle != IntPtr.Zero;
            }
        }

        public MPZ()
            : base(IntPtr.Zero, true)
        {
            Alloc();
            MPIR.mpz_init(this);
        }

        public MPZ(MPF a)
            : this()
        {
            MPIR.mpz_set_f(this, a);
        }

        public MPZ(MPQ a)
            : this()
        {
            MPIR.mpz_set_q(this, a);
        }

        public MPZ(string a)
            : this(a, 10)
        {
        }

        public MPZ(string a, int numericBase)
            : base(IntPtr.Zero, true)
        {
            Alloc();
            var r = MPIR.mpz_init_set_str(this, a, numericBase);
            if (r != 0)
                throw new FormatException("not a number");
        }

        public int CompareTo(MPZ a)
        {
            if (ReferenceEquals(a, null))
                return 1;
            return MPIR.mpz_cmp(this, a);
        }

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
            var size = (int)MPIR.mpz_sizeinbase(this, numericBase);
            var sb = new StringBuilder(size + 1);
            var r = MPIR.mpz_get_str(sb, numericBase, this);
            return sb.ToString();
        }

        private void Alloc()
        {
            SetHandle(Marshal.AllocHGlobal(MPIR.MPZSize));
        }

        protected override bool ReleaseHandle()
        {
            MPIR.mpz_clear(this);
            Marshal.FreeHGlobal(handle);
            return true;
        }
    }
}
