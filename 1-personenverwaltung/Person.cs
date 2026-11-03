using System;

class Person
{
    public int Id { get; set;}
    public string Vorname { get;
        set
        {
            if(value != string.Empty)
            {
                Vorname = value;
            }
        }
    }
    public string Nachname{ get;
        set
        {
            if(value != string.Empty)
            {
                Vorname = value;
            }
        }
    }
    public string EMail{ get;
        set
        {
            if(value.Contains("@"))
            {
                Vorname = value;
            }
        }
    }
    public DateTime Geburtsdatum{ get;
        set
        {
            if(value < DateTime.UtcNow)
            {
                Geburtsdatum = value;
            }
        }
    }
    public Adresse Hauptwohnsitz{ get;
        set
        {
            if(Hauptwohnsitz != null)
            {
                Hauptwohnsitz = value;
            }
        }
    }


}