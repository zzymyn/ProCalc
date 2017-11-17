﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProCalc.Lib.MPIR
{
    public class MPZ : SafeHandle
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
            SetHandle(Marshal.AllocHGlobal(MPIR.MPZSize));
            MPIR.mpz_init(this);
        }

        protected override bool ReleaseHandle()
        {
            MPIR.mpz_clear(this);
            Marshal.FreeHGlobal(handle);
            return true;
        }
    }
}
