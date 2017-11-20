using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TextTemplating;

namespace ProCalc.TT
{
    public struct ClassDef
    {
        public string Name;
        public InitDef[] Inits;
        public ConvDef[] Convs;
        public OpDef[] Ops;
        public GetDef[] Gets;
        public FuncDef[] Funcs;
    }
}
