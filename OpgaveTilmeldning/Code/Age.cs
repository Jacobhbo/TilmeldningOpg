using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveTilmeldning.Code
{
    internal struct AgeConverter
    {
        public int Age { get; set; }

        public AgeConverter(DateTime Fødselsdag)
        {
            Age = DateTime.Now.Year - Fødselsdag.Year;
        }


    }
}