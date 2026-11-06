using System;

class Person
{
    public int Id { get; set;}
    private string vorname;
    public string Vorname {
        get
        {
            return vorname;
        }
        set
        {
            if(value != string.Empty)
            {
                vorname = value;
            }
        }
    }
    private string nachname;
    public string Nachname{
        get
        {
            return nachname;
        }
        set
        {
            if(value != string.Empty)
            {
                nachname = value;
            }
        }
    }
    private string email;
    public string EMail{
        get
        {
            return email;
        }
        set
        {
            if(value.Contains("@"))
            {
                email = value;
            }
        }
    }
    private DateTime geburtsdatum;
    public DateTime Geburtsdatum{
        get
        {
            return geburtsdatum;
        }
        set
        {
            if(value < DateTime.UtcNow)
            {
                geburtsdatum = value;
            }
        }
    }
    private Adresse hauptwohnsitz;
    public Adresse Hauptwohnsitz{
        get
        {
            return hauptwohnsitz;
        }
        set
        {
            if(value != null)
            {
                hauptwohnsitz = value;
            }
        }
    }

    //
    public int BerechneAlter()
    {
        int alter = DateTime.Now.Year - Geburtsdatum.Year;

        if (DateTime.Now < Geburtsdatum.AddYears(alter))
        {
            alter--;
        }

        return alter;
    }

    public string VollerName()
    {
        return vorname + " " + nachname;
    }
}