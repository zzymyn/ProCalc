using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProCalc.Lib.MPIR
{
    public static class MPIR
    {
        public const int MPZSize = 128;

        [DllImport("mpir.dll", EntryPoint = "__gmpz_init")]
        public static extern void mpz_init(IntPtr a);

        [DllImport("mpir.dll", EntryPoint = "__gmpz_init")]
        public static extern void mpz_clear(IntPtr a);
    }
}
