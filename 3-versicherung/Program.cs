using System;

namespace Versicherung
{

class Program
{
    public static void Main(string[] args)
    {
        Versicherungsgesellschaft vgs = new Versicherungsgesellschaft();
        Versicherungsgesellschaft vgs1 = new Versicherungsgesellschaft();

        Versicherungsvertrag vv = new Versicherungsvertrag();
        vgs.vertragHinzufuegen(vv);
        vv.Versicherungsgesellschaft = vgs;
        Versicherungsvertrag vv1 = new Versicherungsvertrag();
        vgs.vertragHinzufuegen(vv1);
        vv1.Versicherungsgesellschaft = vgs;
        Versicherungsvertrag vv2 = new Versicherungsvertrag();
        vgs1.vertragHinzufuegen(vv2);
        vv2.Versicherungsgesellschaft = vgs1;
        Versicherungsvertrag vv3 = new Versicherungsvertrag();
        vgs1.vertragHinzufuegen(vv3);
        vv3.Versicherungsgesellschaft = vgs1;

        Person person = new Person();
        person.hinzufuegenVersicherungsvertrag(vv);
        Person person1 = new Person();
        person.hinzufuegenVersicherungsvertrag(vv1);
        Person person2 = new Person();
        person.hinzufuegenVersicherungsvertrag(vv2);
        Person person3 = new Person();
        person.hinzufuegenVersicherungsvertrag(vv3);
        Person person4 = new Person();
        person.hinzufuegenMitversicherter(vv);

        Console.WriteLine("Erstellt!");
    }
}

}