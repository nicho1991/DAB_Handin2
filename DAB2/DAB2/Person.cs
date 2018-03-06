using System.Collections.Generic;

public class Person
{
    public Person(Telephone phone, Adress primaryAdress, string name, string famileName, string middleName, string type,
        Email mail = null)
    {
        _personType = type;
        _email = mail;
        telephones.Add(phone);
        fRA = primaryAdress;
        TypeOfAdress newAdress = new TypeOfAdress();

        newAdress.adresse = primaryAdress;
        newAdress.personer = this;
        newAdress.type = "primary Adress";

        _givenName = name;
        _middleName = middleName;
        _familyName = famileName;
        Adresses.Add(newAdress);
    }

    public void addAlternativeAdress(Adress altAdress)
    {
        if (altAdress == fRA)
        {
            return;
        }
        TypeOfAdress newAdress = new TypeOfAdress();
        newAdress.adresse = altAdress;
        newAdress.personer = this;
        newAdress.type = "Alternative adress";
    }

    public void replaceMail(Email mail)
    {
        _email = mail;
    }

    public string _personType;

    public Email _email { get; set; }
    public string _familyName { get; }
    public Adress fRA { get; }
    public string _givenName { get; }
    public string _middleName { get; }

    public List<Telephone> telephones { get; }
    

    static public List<TypeOfAdress> Adresses { get; set; }
}