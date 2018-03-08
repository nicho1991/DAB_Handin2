
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
                adressOne.HouseNumber = "22A";
                adressOne.StreetName = "Værkmestergade";

                Person per = new Person();
                Email persEmail = new Email();
                persEmail.UniqueEmail = "perVers";
                per.Email = persEmail;
                per.FamilyName = "adsdsa";
                per.GivenName = "asdsad";
                per.MiddleName = "sdasdas";
                per.PersonType = "trans";

                TypeOfAdress PersonAdresseRelation = new TypeOfAdress();
                PersonAdresseRelation.PersonID = per.PersonID; // sæt persons id til relation
                PersonAdresseRelation.AdressId = adressOne.AdressID;
                PersonAdresseRelation.AdressType = "Primary";
                     
                db.AdressesSet.Add(adressOne);
                db.EmailSet.Add(persEmail);
                db.PersonSet.Add(per);
                db.TypeOfAdressesSet.Add(PersonAdresseRelation);

                db.SaveChanges();
            }
        }
    }

}