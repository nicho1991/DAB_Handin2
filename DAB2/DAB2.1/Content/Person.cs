using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Person
{
    public string PersonType;

    public ICollection<Telephone> Telephones { get; set; } = new List<Telephone>();
    public ICollection<AltAdresse> altAdresser { get; set; } = new List<AltAdresse>();

    public Person()
    {
        
    }
    public Person(Telephone phone, Adress primaryAdress, string name, string famileName, string middleName, string type,
        Email mail = null)
    {
        PersonType = type;
        Email = mail;
        Telephones.Add(phone);
        FRa = primaryAdress;

        GivenName = name;
        MiddleName = middleName;
        FamilyName = famileName;
    }
    [Key]
    public int PersonID { get; set; }
    public Email Email { get; set; }
    public string FamilyName { get; set; }
    public Adress FRa { get; set; }
    public string GivenName { get; set; }
    public string MiddleName { get; set; }

    public void AddAlternativeAdress(AltAdresse altAdress)
    {
        if (altAdress.AlternativeAdress == FRa) return; //ingen folkeregister adresse som alt adr
        altAdresser.Add(altAdress);
        
    }

    public void ReplaceMail(Email mail)
    {
        Email = mail;
    }
}