using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveTilmeldning.Code
{
    internal class PersonModel
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public CountryCode Country { get; set; }
        public DateTime Fødselsdato { get; set; }
    }
}