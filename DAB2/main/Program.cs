
using System.Data.Entity;

namespace DAB2_2
{
    public class Program
    {
        private static void Main()
        {
            using (var db = new personIndexContext())
            {
                Adress adressOne = new Adress();
                adressOne.ZipCode = "8000";
                adressOne.CityName = "Aarhus";
                adressOne.HouseNumber = "130";
                adressOne.StreetName = "Nygadeda";

                Person per = new Person();
                Email persEmail = new Email();
                persEmail.UniqueEmail = "anotherteste3new@mail.dk";
                per.Email = persEmail;
                per.FamilyName = "Hans";
                per.GivenName = "Lars";
                per.MiddleName = "";
                per.PersonType = "Mand";

                TypeOfAdress PersonAdresseRelation = new TypeOfAdress();
                PersonAdresseRelation.PersonID = per.PersonID; // sæt persons id til relation
                PersonAdresseRelation.AdressId = adressOne.AdressID;
                PersonAdresseRelation.AdressType = "Primary";

                Telephone tele = new Telephone();
                tele.PhoneCompany = "TDC";
                tele.TelephoneNumber = "20298780";
                tele.UsageOfTlf = "Privat";

                db.TelephoneSet.Add(tele);   
                db.AdressesSet.Add(adressOne);
                db.EmailSet.Add(persEmail);
                db.PersonSet.Add(per);
                db.TypeOfAdressesSet.Add(PersonAdresseRelation);

                db.SaveChanges();
            }
        }
    }

}