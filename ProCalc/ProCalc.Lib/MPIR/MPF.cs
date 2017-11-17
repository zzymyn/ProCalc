using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProCalc.Lib.MPIR
{
    public class MPF : SafeHandle
    {
        public override bool IsInvalid
        {
            get
            {
                return handle != IntPtr.Zero;
            }
        }

        public MPF()
            : base(IntPtr.Zero, true)
        {
            SetHandle(Marshal.AllocHGlobal(MPIR.MPFSize));
            MPIR.mpf_init(this);
        }

        protected override bool ReleaseHandle()
        {
            MPIR.mpf_clear(this);
            Marshal.FreeHGlobal(handle);
            return true;
        }
    }
}
