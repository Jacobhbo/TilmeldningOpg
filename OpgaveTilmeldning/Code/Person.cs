
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveTilmeldning.Code
{
    public enum CountryCode
    {
        DK,
        EN
    }

    // Abstract 
    //klasse er base klasse for teacher og studen
    internal abstract class Person
    {
        public PersonModel? PersonInfo { get; set; }
        public DateTime Fødselsdag { get; set; }
        public int Alder { get; set; }


        public Person(string? fornavn, string? efternavn, DateTime fødselsdag)
        {
            PersonInfo = new() { Fornavn = fornavn, Efternavn = efternavn };
            Fødselsdag = fødselsdag;
            Alder = new AgeConverter(fødselsdag).Age;
        }

        protected string ShowFullName()
        {
            return $"{PersonInfo.Fornavn} {PersonInfo.Efternavn}";
        }

        protected abstract string ShowAllInfo();



        protected virtual string ShowAllInfo2()
        {
            return $"{PersonInfo.Fornavn} {PersonInfo.Efternavn}";
        }


    }
}