using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveTilmeldning.Code
{
    internal class Enrollment
    {
        public Elev Elev { get; set; }
        public Fag? Fag { get; set; }

        public Enrollment(Elev elev, Fag? fag)
        {
            Elev = elev;
            Fag = fag;
        }
    }
}