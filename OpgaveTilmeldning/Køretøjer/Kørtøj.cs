using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecTilmeldning.Køretøjer
{
    internal class Kørtøj
    {
        public string? Mærke { get; set; }
        public string? Model { get; set; }


        public Kørtøj(string? mærke, string? model)
        {
            Mærke = mærke;
            Model = model;

        }
    }
}