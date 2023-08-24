using OpgaveTilmeldning.Køretøjer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecTilmeldning.Køretøjer
{
    internal sealed class Bil : Kørtøj
    {
        public double MotorStørrelse { get; set; }


        public Bil(string? mærke, string? model, double motorStørrelse) : base(mærke, model)
        {
            MotorStørrelse = motorStørrelse;
        }
    }
}