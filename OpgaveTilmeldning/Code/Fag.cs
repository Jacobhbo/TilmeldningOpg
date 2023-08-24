using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveTilmeldning.Code
{
    internal class Fag
    {
        public string? Navn { get; set; }
        public PersonModel? Faglærer { get; set; }

        public Fag(string? navn, PersonModel? faglærer)
        {
            Navn = navn;
            Faglærer = faglærer;
        }

        /// <summary>
        /// Denne metode har en metode signatur som følgende: string
        /// </summary>
        /// <returns></returns>
        public string WriteText()
        {
            return "Hello world!";
        }

        /// <summary>
        /// Denne metode har en metode signatur som følgende: string, string
        /// </summary>
        /// <returns></returns>
        public string WriteText(string valueToDisplay)
        {
            return $"Hello {valueToDisplay}!";
        }

        /// <summary>
        /// Denne metode har en metode signatur som følgende: string, string, int
        /// </summary>
        /// <returns></returns>
        public string WriteText(string valueToDisplay, int alder)
        {
            return $"Hello {valueToDisplay}!, du er {alder.ToString()} år gammel.";
        }
    }
}