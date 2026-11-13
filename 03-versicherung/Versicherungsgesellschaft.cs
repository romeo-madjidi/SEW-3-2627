using System;

namespace Versicherung
{
class Versicherungsgesellschaft
{
    List<Versicherungsvertrag> vertraege = new List<Versicherungsvertrag>();

    public string Name{ get; set; }

    public void vertragHinzufuegen(Versicherungsvertrag vertrag)
    {
        vertraege.Add(vertrag);
    }
}
}