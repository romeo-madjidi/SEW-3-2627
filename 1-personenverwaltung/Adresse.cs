using System;

class Adresse
{
    public Adresse(){}

    public Adresse(string hausnummer, string strasse, int plz, string ort, string bundesland)
    {
        Hausnummer = hausnummer;
        Strasse = strasse;
        Plz = plz;
        Ort = ort;
        Bundesland = bundesland;
        Land = land;
    }

    public Adresse(string hausnummer, string strasse, int plz, string ort, string bundesland, string land) : this(hausnummer, strasse, plz, ort, bundesland)
    {
        Land = land;
    }

    private string strasse;
    public string Strasse
    {
        get
        {
            return strasse;
        }
        set
        {
            if(value != string.Empty)
            {
                strasse = value;
            }
        }
    }
    private string hausnummer;
    public string Hausnummer
    {
        get
        {
            return hausnummer;
        }
        set
        {
            if(value != string.Empty)
            {
                hausnummer = value;
            }
        }
    }
    private int plz;
    public int Plz
    {
        get
        {
            return plz;
        }
        set
        {
            if(value < 10000 && value > 999)
            {
                plz = value;
            }
        }
    }
    private string ort;
    public string Ort
    {
        get
        {
            return ort;
        }
        set
        {
            if(value != string.Empty)
            {
                ort = value;
            }
        }
    }
    private string bundesland;
    public string Bundesland
    {
        get
        {
            return bundesland;
        }
        set
        {
            if(value != string.Empty)
            {
                bundesland = value;
            }
        }
    }
    private string land = "Österreich";
    public string Land
    {
        get
        {
            return land;
        }
        set
        {
            if(value != string.Empty)
            {
                land = value;
            }
        }
    }

    public override string ToString()
    {
        return Hausnummer + "." + Strasse + ", " + Plz + " " + Ort + " " + Bundesland + " " + Land;
    }
}