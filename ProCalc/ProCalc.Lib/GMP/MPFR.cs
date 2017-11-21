using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProCalc.Lib.GMP
{
    public partial class MPFR : IDisposable, IComparable<MPFR>, IEquatable<MPFR>
    {
        internal const GMP.mpfr_rnd_t DefaultRnd = GMP.mpfr_rnd_t.MPFR_RNDN;

        internal GMP.mpfr_t S;

        public static int DefaultPrecision
        {
            get { return GMP.mpfr_get_default_prec(); }
            set { GMP.mpfr_set_default_prec(value); }
        }

        public int Precision
        {
            get { return GMP.mpfr_get_prec(ref S); }
            set { GMP.mpfr_set_prec(ref S, value); }
        }

        public MPFR()
        {
            GMP.mpfr_init(ref S);
        }

        public MPFR(string a)
            : this(a, 10)
        {
        }

        public MPFR(string a, int numericBase)
        {
            var r = GMP.mpfr_init_set_str(ref S, a, numericBase, DefaultRnd);
            if (r != 0)
                throw new FormatException("not a number");
        }

        ~MPFR()
        {
            Free();
        }

        public int CompareTo(MPFR a)
        {
            if (ReferenceEquals(a, null))
                return 1;
            return GMP.mpfr_cmp(ref S, ref a.S);
        }

        // TODO: make better
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as MPFR);
        }

        public bool Equals(MPFR a)
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
            var r = GMP.mpfr_get_str(sb, ref exp, numericBase, (ulong)prec, ref S, DefaultRnd);

            FormatScientific(sb, exp, numericBase);

            return sb.ToString();
        }

        public string ToHuman(int prec = 32, int numericBase = 10)
        {
            var sb = new StringBuilder(prec + 1);
            int exp = 0;
            var r = GMP.mpfr_get_str(sb, ref exp, numericBase, (ulong)prec, ref S, DefaultRnd);

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
            GMP.mpfr_clear(ref S);
        }
    }
}
