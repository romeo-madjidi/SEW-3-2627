using System;

namespace Versicherung
{
class Versicherungsvertrag
{
    Versicherungsgesellschaft versicherungsgesellschaft;
    public Versicherungsgesellschaft Versicherungsgesellschaft
        {
            get; set
            {
                versicherungsgesellschaft = value;
            }
        }
    Person versicherungsNehmer;
    List<Person> mitversicherte = new List<Person>();
}
}