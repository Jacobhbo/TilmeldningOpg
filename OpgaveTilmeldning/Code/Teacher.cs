using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveTilmeldning.Code
{
    internal class Teacher : Person
    {
        public string Afdeling { get; set; }

        public Teacher(string? fornavn, string? efternavn, DateTime fødselsdag, string? afdeling) : base(fornavn, efternavn, fødselsdag)
        {

            Afdeling = afdeling;
            string fullname = ShowFullName();
            string defaultInfo = ShowAllInfo2();
        }

        protected override string ShowAllInfo()
        {
            return $"{PersonInfo.Fornavn} {PersonInfo.Efternavn}, afdeling {Afdeling}";
        }

        protected override string ShowAllInfo2()
        {
            return $"{PersonInfo.Fornavn} {PersonInfo.Efternavn}, afdeling {Afdeling}";
        }
    }
}