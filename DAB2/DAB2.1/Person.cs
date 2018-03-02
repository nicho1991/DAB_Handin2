using System.Collections.Generic;
using System.Dynamic;

public class Person
{
    public Person(Telephone phone, Adress primaryAdress, string name, string famileName, string middleName, string type,
        Email mail = null)
    {
        _personType = type;
        _email = mail;
        telephones.Add(phone);
        fRA = primaryAdress;

        item bla = new item();
        bla.type = "alternative adress";
        bla.personer = this;
        bla.adresse = primaryAdress;

        _givenName = name;
        _middleName = middleName;
        _familyName = famileName;

    }

    public void addAlternativeAdress(Adress altAdress)
    {
        if (altAdress == fRA)
        {
            return;
        }

        item bla = new item();
        bla.type = "alternative adress";
        bla.personer = this;
        bla.adresse = altAdress;

        TypeOfAdress.items.Add(bla);
    }

    public void replaceMail(Email mail)
    {
        _email = mail;
    }

    public string _personType;

    public Email _email { get; set; }
    public string _familyName { get; }
    private Adress fRA { get; }
    public string _givenName { get; }
    public string _middleName { get; }

    public List<Telephone> telephones = new List<Telephone>();
    
}