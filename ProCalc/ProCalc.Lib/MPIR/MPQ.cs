using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProCalc.Lib.MPIR
{
    public class MPQ : SafeHandle
    {
        public override bool IsInvalid
        {
            get
            {
                return handle != IntPtr.Zero;
            }
        }

        public MPQ()
            : base(IntPtr.Zero, true)
        {
            SetHandle(Marshal.AllocHGlobal(MPIR.MPQSize));
            MPIR.mpq_init(this);
        }

        protected override bool ReleaseHandle()
        {
            MPIR.mpq_clear(this);
            Marshal.FreeHGlobal(handle);
            return true;
        }
    }
}
