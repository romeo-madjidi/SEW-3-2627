using System;

namespace Versicherung
{
class Person
{
    List<Versicherungsvertrag> versicherungen = new List<Versicherungsvertrag>();
    public void hinzufuegenVersicherungsvertrag(Versicherungsvertrag versicherungsvertrag)
    {
        versicherungen.Add(versicherungsvertrag);
    }
    List<Versicherungsvertrag> mitversicherter = new List<Versicherungsvertrag>();
    public void hinzufuegenMitversicherter(Versicherungsvertrag mitversichert)
    {
        mitversicherter.Add(mitversichert);
    }
}
}