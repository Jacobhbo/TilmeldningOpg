using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecTilmeldning.Køretøjer
{
    internal class Cykel : Kørtøj
    {
        public string? HøjdeStørrelse { get; set; }

        public Cykel(string? mærke, string? model, string? højdeStørrelse) : base(mærke, model)
        {
            HøjdeStørrelse = højdeStørrelse;
        }
    }
}