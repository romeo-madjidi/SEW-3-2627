using System;

static void Main(string[] args)
{
    Adresse adresse = new Adresse();
    Adresse adresse1 = new Adresse();
    Adresse adresse2 = new Adresse();
    Adresse adresse3 = new Adresse();

    Person person = new Person();
    person.Id = 1;
    person.Vorname = "Anna";
    person.Nachname = "Huber";
    person.Geburtsdatum = DateTime.Parse("12.03.2009");
    person.EMail = "anna.huber@example.at";

    Person person1 = new Person();
    person1.Id = 2;
    person1.Vorname = "Markus";
    person1.Nachname = "Huber";
    person1.Geburtsdatum = DateTime.Parse("05.07.1980");
    person1.EMail = "markus.huber@example.at";
}
