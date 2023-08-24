using System;
using System.Collections.Generic;
using System.Globalization;

namespace TecTilmeldning.Code
{


    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            while (true)
            {
                Console.Write("\nIndtast tal 1 for at afspille lyden: ");
                string talinput = Console.ReadLine();
                if (talinput == "1´")
                {
                    string myCurrentDer = System.IO.Directory.GetCurrentDirectory();
                    string appDir = System.IO.Path.Combine(myCurrentDer, "Soundtest");
                    appDir = System.IO.Path.Combine(appDir, "ost.wav");

                    System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();
                    soundPlayer.SoundLocation = appDir;
                    soundPlayer.Play();
                }
                else
                {
                    Console.Clear();
                }
            }*/




            Console.ForegroundColor = ConsoleColor.Green;
            /*Elev? nieels = new("Niels", "Egon Olsen", new DateTime(1970, 7, 23));
             Elev? Patrik = new("Patrik", "Petersen", new DateTime(1996, 7, 23));
             Teacher? Nielsole = new("Niels", "Olesen", new DateTime(1960, 8, 24), "CIT");
             Teacher? niels = new("Jacob", "Hauritz Bodholdt", new DateTime(2005, 7, 23), "CIT");
             PersonModel personInfo = niels.PersonInfo;
             PersonModel personInfo1 = Nielsole.PersonInfo;*/

            Teacher? niels = new("Niels", "Olesen", new DateTime(1970, 7, 23), "CIT");
            Teacher? henrik = new("Henrik", "Paulsen", new DateTime(1996, 7, 23), "CIT");
            Teacher? jack = new("Jack", "Baltzer", new DateTime(1960, 8, 24), "CIT");
            Teacher? bo = new("Bo", "Elbæk", new DateTime(2005, 7, 23), "CIT");

            Fag grundlæggendeprogrammering = new("Grundlæggende programmering", niels.PersonInfo);
            Fag oop = new("OOP", niels.PersonInfo);
            Fag Studieteknik = new("Studeteknik", niels.PersonInfo);
            Fag Netværk = new("Netværk", henrik.PersonInfo);
            Fag Clientsideprogrammering = new("Clientside programmering", jack.PersonInfo);
            Fag Databaseprogrammering = new("Database programmering", jack.PersonInfo);
            Fag Computerteknologi = new("Computerteknologi", bo.PersonInfo);



            /*Console.WriteLine($"{oop.Fornavn}, teacher \nNavn: {personInfo.Fornavn} {personInfo.Efternavn} \nJacob's Alder: {niels.Alder}");
            Console.WriteLine($"\n\nNiels alder: {nieels.Alder} \nPatriks alder: {Patrik.Alder} \nOOP lærer er: {personInfo1.Fornavn} {personInfo1.Efternavn} ");*/

            Console.Clear();


            List<Elev> tilmeldteElever = new List<Elev>();
        Start:
            Console.Clear();
            Console.Write("\nAngiv elev fornavn: ");
            string fornavn = Console.ReadLine();
            Console.Write("\nAngiv elev efternavn: ");
            string efternavn = Console.ReadLine();
            Console.Write("\nAngiv elev fødselsdato (dd-MM-yyyy): ");
            string fødselsdatoInput = Console.ReadLine();

            DateTime fødselsdato;
            if (DateTime.TryParseExact(fødselsdatoInput, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fødselsdato))
            {
                // Nu har du en korrekt formateret DateTime-værdi i fødselsdato
            }
            else
            {
                Console.WriteLine("Ugyldigt datoformat. Brug dd-MM-yyyy format.");
            }

            // Opret en liste af fagnavne
            List<string> fagListe = new List<string>
            {
                "Grundlæggendeprogrammering",
                "OOP",
                "Studieteknik",
                "Netværk",
                "Clientside programmering",
                "Databse programmering",
                "Computerteknologi"
            };

            Console.WriteLine("\nFag id: 1, fag navn: Grundlæggendeprogrammering");
            Console.WriteLine("Fag id: 2, fag navn: OOP");
            Console.WriteLine("Fag id: 3, fag navn: Studieteknik");
            Console.WriteLine("Fag id: 4, fag navn: Netværk");
            Console.WriteLine("Fag id: 5, fag navn: Clientside programmering");
            Console.WriteLine("Fag id: 6, fag navn: Database programmering");
            Console.WriteLine("Fag id: 7, fag navn: Computerteknologi");

            Console.Write("\nAngiv ID for det fag, som elev skal tilmeldes: ");
            int valg = int.Parse(Console.ReadLine());

            if (valg >= 1 && valg <= 7)
            {
                string valgtFag = fagListe[valg - 1];
                Console.WriteLine($"\n{fornavn} {efternavn} er nu tilmeldt: {fagListe[valg - 1]}");
            }
            else
            {
                Console.WriteLine("Ugyldigt valg.");
            }


            Console.WriteLine("\nTimeld ny elev [J/N]");
            string tast = Console.ReadLine();
            if (tast.ToLower() == "j")
            {
                tilmeldteElever.Add(new Elev(fornavn, efternavn, fødselsdato)); // Tilføj den nye elev til listen
                Console.WriteLine("\nTilmeldte elever:");
                foreach (Elev elev in tilmeldteElever)
                {
                    string valgtFag = fagListe[valg - 1];
                    int alder = (int)((DateTime.Now - fødselsdato).TotalDays / 365.25);
                    Console.WriteLine($"\n{fornavn} {efternavn} ({alder} år gammel) er tilmeldt {valgtFag}");
                    Console.WriteLine($"\nAntal tilmeldte elever: {tilmeldteElever.Count}");
                    Console.WriteLine("Tryk enter for at lave en ny elev");
                    Console.ReadKey();
                    goto Start;

                }
                if (tast.ToLower() == "n")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Ugyldigt valg");
                }

            }

        }
    }
}