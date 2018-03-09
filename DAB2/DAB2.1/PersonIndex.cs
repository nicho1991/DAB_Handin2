using System;

namespace DAB2._1
{
    public class PersonIndex
    {
        public void PrintPerson(Person printHim)
        {
            Console.WriteLine("Navn: " + printHim.GivenName + " " + printHim.MiddleName + " " +
                              printHim.FamilyName + " Køn " + printHim.PersonType);
            if (printHim.Email != null)
            {
                Console.WriteLine("Email: " + printHim.Email.UniqueEmail);
            }
           
            foreach (var variable in printHim.Telephones)
                Console.WriteLine("Telefon: " + variable.TelephoneNumber + " Type: " + variable.UsageOfTlf + " Teleselskab: " +
                                  variable.PhoneCompany);

            foreach (var pikItem in TypeOfAdress.Items) //print adresser
                if (pikItem.Personer == printHim)
                    Console.WriteLine("Adresse: " + " " + pikItem.Type + " " + pikItem.Adresse.ZipCode + " " + pikItem.Adresse.CityName + " " +
                                      pikItem.Adresse.StreetName + " " + pikItem.Adresse.HouseNumber);
        }
    }
}