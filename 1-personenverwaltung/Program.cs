using System;
using System.Collections.Generic;

class Programm
{
    static void Main(string[] args)
    {
        Adresse adresse = new Adresse();
        adresse.Hausnummer = "A1";
        adresse.Strasse = "Hauptstraße 12a";
        adresse.Plz = 3340;
        adresse.Ort = "Waidhofen an der Ybbs";
        adresse.Bundesland = "Niederösterreich";

        Adresse adresse2 = new Adresse();
        adresse2.Hausnummer = "A2";
        adresse2.Strasse = "Mariahilfer Straße 45";
        adresse2.Plz = 1060;
        adresse2.Ort = "Wien";
        adresse2.Bundesland = "Wien";

        Adresse adresse3 = new Adresse();
        adresse3.Hausnummer = "A3";
        adresse3.Strasse = "Herrengasse 8";
        adresse3.Plz = 8010;
        adresse3.Ort = "Graz";
        adresse3.Bundesland = "Steiermark";

        Adresse adresse4 = new Adresse();
        adresse4.Hausnummer = "A4";
        adresse4.Strasse = "Maria-Theresien-Straße 21";
        adresse4.Plz = 6020;
        adresse4.Ort = "Innsbruck";
        adresse4.Bundesland = "Tirol";

        List<Person> personenListe = new List<Person>();

        Person person = new Person();
        person.Id = 1;
        person.Vorname = "Anna";
        person.Nachname = "Huber";
        person.Geburtsdatum = DateTime.Parse("12.03.2009");
        person.EMail = "anna.huber@example.at";
        person.Hauptwohnsitz = adresse;
        personenListe.Add(person);

        Person person2 = new Person();
        person2.Id = 2;
        person2.Vorname = "Markus";
        person2.Nachname = "Huber";
        person2.Geburtsdatum = DateTime.Parse("05.07.1980");
        person2.EMail = "markus.huber@example.at";
        person2.Hauptwohnsitz = adresse;
        personenListe.Add(person2);

        Person person3 = new Person();
        person3.Id = 3;
        person3.Vorname = "Sabine";
        person3.Nachname = "Huber";
        person3.Geburtsdatum = DateTime.Parse("19.11.1982");
        person3.EMail = "sabine.huber@example.at";
        person3.Hauptwohnsitz = adresse;
        personenListe.Add(person3);

        Person person4 = new Person();
        person4.Id = 4;
        person4.Vorname = "Lukas";
        person4.Nachname = "Gruber";
        person4.Geburtsdatum = DateTime.Parse("23.01.2001");
        person4.EMail = "lukas.gruber@example.at";
        person4.Hauptwohnsitz = adresse2;
        personenListe.Add(person4);

        Person person5 = new Person();
        person5.Id = 5;
        person5.Vorname = "Mira";
        person5.Nachname = "Yilmaz";
        person5.Geburtsdatum = DateTime.Parse("14.09.1999");
        person5.EMail = "mira.yilmaz@example.at";
        person5.Hauptwohnsitz = adresse2;
        personenListe.Add(person5);

        Person person6 = new Person();
        person6.Id = 6;
        person6.Vorname = "Thomas";
        person6.Nachname = "Bauer";
        person6.Geburtsdatum = DateTime.Parse("30.04.1975");
        person6.EMail = "thomas.bauer@example.at";
        person6.Hauptwohnsitz = adresse3;
        personenListe.Add(person6);

        Person person7 = new Person();
        person7.Id = 7;
        person7.Vorname = "Julia";
        person7.Nachname = "Steiner";
        person7.Geburtsdatum = DateTime.Parse("08.12.2004");
        person7.EMail = "julia.steiner@example.at";
        person7.Hauptwohnsitz = adresse4;
        personenListe.Add(person7);

        Person person8 = new Person();
        person8.Id = 8;
        person8.Vorname = "Felix";
        person8.Nachname = "Moser";
        person8.Geburtsdatum = DateTime.Parse("17.06.2003");
        person8.EMail = "felix.moser@example.at";
        person8.Hauptwohnsitz = adresse4;
        personenListe.Add(person8);

        //Ausgabe
        Console.WriteLine("Aufgabe1:");
        int durchschnitt = 0;
        for(int i = 0; i < personenListe.Count; i++)
        {
            Console.WriteLine(personenListe[i].VollerName() + " " + personenListe[i].Hauptwohnsitz);
            durchschnitt += personenListe[i].BerechneAlter();
        }
        Console.Write("Durchschnittsalter: ");
        durchschnitt = durchschnitt / personenListe.Count;
        Console.WriteLine(durchschnitt);

        Console.WriteLine("ALLE ADRESSEN:");

        List<Adresse> adressen = new List<Adresse>();

        foreach (Person p in personenListe)
        {
            if (!adressen.Contains(p.Hauptwohnsitz))
            {
                adressen.Add(p.Hauptwohnsitz);
            }
        }

        foreach (Adresse a in adressen)
        {
            int anzahl = 0;

            Console.WriteLine("\nAdresse: " + a);

            foreach (Person p in personenListe)
            {
                if (p.Hauptwohnsitz == a)
                {
                    Console.WriteLine(p.Vorname + " " + p.Nachname);
                    anzahl++;
                }
            }

            Console.WriteLine("Anzahl Personen: " + anzahl);
        }

        Console.Write("Bundesland eingeben:");
        string bundesland = Console.ReadLine();

        foreach (Person p in personenListe)
        {
            if (p.Hauptwohnsitz.Bundesland.ToLower() == bundesland.ToLower())
            {
                Console.WriteLine(p.Vorname + " " + p.Nachname);
            }
        }

        Console.Write("ID der Person eingeben:");
        int id = Convert.ToInt32(Console.ReadLine());

        Person ausgewaehltePerson = null;

        foreach (Person p in personenListe)
        {
            if (p.Id == id)
            {
                ausgewaehltePerson = p;
            }
        }

        if (ausgewaehltePerson != null)
        {
            Console.WriteLine("Mitbewohner:");

            foreach (Person p in personenListe)
            {
                if (p.Hauptwohnsitz == ausgewaehltePerson.Hauptwohnsitz && p.Id != ausgewaehltePerson.Id)
                {
                    Console.WriteLine(p.Vorname + " " + p.Nachname);
                }
            }
        }
        else
        {
            Console.WriteLine("Person nicht gefunden!");
        }
    }
}
