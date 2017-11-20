using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProCalc.Lib.MPIR
{
    public partial class MPF : IDisposable, IComparable<MPF>, IEquatable<MPF>
    {
        internal MPIR.mpf_t S;

        public ulong Precision
        {
            get { return MPIR.mpf_get_prec(ref S); }
            set { MPIR.mpf_set_prec(ref S, value); }
        }

        public MPF()
        {
            MPIR.mpf_init2(ref S, 128);
        }

        private MPF(ref MPIR.mpf_t a)
            :this()
        {
            MPIR.mpf_set(ref S, ref a);
        }

        public MPF(MPF a)
            : this(ref a.S)
        {
        }

        public MPF(MPZ a)
            : this()
        {
            MPIR.mpf_set_z(ref S, ref a.S);
        }

        public MPF(MPQ a)
            : this()
        {
            MPIR.mpf_set_q(ref S, ref a.S);
        }

        public MPF(string a)
            : this(a, 10)
        {
        }

        public MPF(string a, int numericBase)
            : this()
        {
            var r = MPIR.mpf_set_str(ref S, a, numericBase);
            if (r != 0)
                throw new FormatException("not a number");
        }

        ~MPF()
        {
            Free();
        }

        public int CompareTo(MPF a)
        {
            if (ReferenceEquals(a, null))
                return 1;
            return MPIR.mpf_cmp(ref S, ref a.S);
        }

        // TODO: make better
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as MPF);
        }

        public bool Equals(MPF a)
        {
            if (ReferenceEquals(a, null))
                return false;
            return CompareTo(a) == 0;
        }

        public override string ToString()
        {
            return ToString(32, 10);
        }

        public string ToString(int prec, int numericBase)
        {
            var sb = new StringBuilder(prec + 1);
            int exp = 0;
            var r = MPIR.mpf_get_str(sb, ref exp, numericBase, (ulong)prec, ref S);

            FormatScientific(sb, exp, numericBase);

            return sb.ToString();
        }

        public string ToHuman(int prec = 32, int numericBase = 10)
        {
            var sb = new StringBuilder(prec + 1);
            int exp = 0;
            var r = MPIR.mpf_get_str(sb, ref exp, numericBase, (ulong)prec, ref S);

            if (exp > prec || sb.Length - exp > prec)
            {
                FormatScientific(sb, exp, numericBase);
            }
            else if (exp == 0 && sb.Length == 0)
            {
                sb.Append('0');
            }
            else if (exp > sb.Length)
            {
                sb.Append('0', exp - 1);
            }
            else if (exp >= 1)
            {
                if (sb.Length > exp)
                {
                    sb.Insert(exp, '.');
                }
            }
            else if (exp == 0)
            {
                sb.Insert(0, "0.");
            }
            else if (exp < 0)
            {
                sb.Insert(0, new string('0', -exp));
                sb.Insert(0, "0.");
            }

            return sb.ToString();
        }

        private void FormatScientific(StringBuilder sb, int exp, int numericBase)
        {
            if (exp == 1)
            {
                if (sb.Length > 1)
                {
                    sb.Insert(1, '.');
                }
            }
            else if (exp == 0)
            {
                if (sb.Length == 0)
                {
                    sb.Append('0');
                }
                else
                {
                    sb.Insert(0, "0.");
                }
            }
            else
            {
                sb.Insert(1, '.');
                if (numericBase <= 10)
                    sb.Append('e');
                else
                    sb.Append('@');
                sb.Append(exp - 1);
            }
        }

        public void Dispose()
        {
            Free();
            GC.SuppressFinalize(this);
        }

        private void Free()
        {
            MPIR.mpf_clear(ref S);
        }
    }
}
