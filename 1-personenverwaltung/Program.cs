using System;
using System.Collections.Generic;

class Programm
{
    static void Main(string[] args)
    {

        Adresse adresse = new Adresse("A1", "Hauptstraße 12a", 3340, "Waidhofen an der Ybbs", "Niederösterreich");
        Adresse adresse2 = new Adresse("A2", "Mariahilfer Straße 45", 1060, "Wien", "Wien");
        Adresse adresse3 = new Adresse("A3", "Herrengasse 8", 8010, "Graz", "Steiermark");
        Adresse adresse4 = new Adresse("A4", "Maria-Theresien-Straße 21", 6020, "Innsbruck", "Tirol");

        List<Person> personenListe = new List<Person>();

        personenListe.Add(new Person(1, "Anna", "Huber", DateTime.Parse("12.03.2009"), "anna.huber@example.at", adresse));
        personenListe.Add(new Person(2, "Markus", "Huber", DateTime.Parse("05.07.1980"), "markus.huber@example.at", adresse));
        personenListe.Add(new Person(3, "Sabine", "Huber", DateTime.Parse("19.11.1982"), "sabine.huber@example.at", adresse));
        personenListe.Add(new Person(4, "Lukas", "Gruber", DateTime.Parse("23.01.2001"), "lukas.gruber@example.at", adresse2));
        personenListe.Add(new Person(5, "Mira", "Yilmaz", DateTime.Parse("14.09.1999"), "mira.yilmaz@example.at", adresse2));
        personenListe.Add(new Person(6, "Thomas", "Bauer", DateTime.Parse("30.04.1975"), "thomas.bauer@example.at", adresse3));
        personenListe.Add(new Person(7, "Julia", "Steiner", DateTime.Parse("08.12.2004"), "julia.steiner@example.at", adresse4));
        personenListe.Add(new Person(8, "Felix", "Moser", DateTime.Parse("17.06.2003"), "felix.moser@example.at", adresse4));

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
