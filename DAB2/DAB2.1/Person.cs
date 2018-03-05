using System.Collections.Generic;

public class Person
{
    public string PersonType;

    public List<Telephone> Telephones = new List<Telephone>();

    public Person(Telephone phone, Adress primaryAdress, string name, string famileName, string middleName, string type,
        Email mail = null)
    {
        PersonType = type;
        Email = mail;
        Telephones.Add(phone);
        FRa = primaryAdress;

        var bla = new Item();
        bla.Type = "alternative adress";
        bla.Personer = this;
        bla.Adresse = primaryAdress;

        GivenName = name;
        MiddleName = middleName;
        FamilyName = famileName;
    }

    public Email Email { get; set; }
    public string FamilyName { get; }
    private Adress FRa { get; }
    public string GivenName { get; }
    public string MiddleName { get; }

    public void AddAlternativeAdress(Adress altAdress)
    {
        if (altAdress == FRa) return;

        var bla = new Item();
        bla.Type = "alternative adress";
        bla.Personer = this;
        bla.Adresse = altAdress;

        TypeOfAdress.Items.Add(bla);
    }

    public void ReplaceMail(Email mail)
    {
        Email = mail;
    }
}