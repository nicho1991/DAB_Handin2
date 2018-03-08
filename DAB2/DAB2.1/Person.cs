using System.Collections.Generic;

public class Person
{
    public int PersonID { get; set; }
    public string PersonType { get; set; }
    public virtual ICollection<TypeOfAdress> TypeOfAdress { get; set; }
    public Email Email { get; set; }
    public string FamilyName { get; set; }
    private Adress FRa { get; set; }
    public string GivenName { get; set; }
    public string MiddleName { get; set; }

    public List<Telephone> Telephones = new List<Telephone>();

    //public Person(Telephone phone, Adress primaryAdress, string name, string famileName, string middleName, string type,
    //    Email mail = null)
    //{
    //    PersonType = type;
    //    Email = mail;
    //    Telephones.Add(phone);
    //    FRa = primaryAdress;

    //    var bla = new Item();
    //    bla.Type = "alternative adress";
    //    bla.Personer = this;
    //    bla.Adresse = primaryAdress;

    //    GivenName = name;
    //    MiddleName = middleName;
    //    FamilyName = famileName;
    //}

    //public void AddAlternativeAdress(Adress altAdress)
    //{
    //    if (altAdress == FRa) return;

    //    var bla = new Item();
    //    bla.Type = "alternative adress";
    //    bla.Personer = this;
    //    bla.Adresse = altAdress;

    //    //typeOfAdress
    //}

    //public void ReplaceMail(Email mail)
    //{
    //    Email = mail;
    //}
}