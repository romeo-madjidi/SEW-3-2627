using System;

class Adresse
{
    public string Strasse
    {
        get;
        set
        {
            if(value != string.Empty)
            {
                Strasse = value;
            }
        }
    }
    public string Hausnummer
    {
        get;
        set
        {
            if(value != string.Empty)
            {
                Hausnummer = value;
            }
        }
    }
    public int Plz
    {
        get;
        set
        {
            if(value < 10000 && value > 999)
            {
                Plz = value;
            }
        }
    }
    public string Ort
    {
        get;
        set
        {
            if(value != string.Empty)
            {
                Ort = value;
            }
        }
    }
    public string Bundesland
    {
        get;
        set
        {
            if(value != string.Empty)
            {
                Bundesland = value;
            }
        }
    }
    public string Land
    {
        get;
        set
        {
            if(value != string.Empty)
            {
                Land = value;
            }
        }
    }

}