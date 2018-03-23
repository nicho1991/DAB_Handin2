using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        AltAdresse PrimaryAdress = new AltAdresse();
        PrimaryAdress.TypeOfAdress = "Primary";
        PrimaryAdress.AlternativeAdress = primaryAdress;
        altAdresser.Add(PrimaryAdress);

        Type = type;
        GivenName = name;
        MiddleName = middleName;
        FamilyName = famileName;
    }
    [Key]
    public int PersonID { get; set; }
    public Email Email { get; set; }
    public string FamilyName { get; set; }
    public string Type { get; set; }

    public string GivenName { get; set; }
    public string MiddleName { get; set; }

}