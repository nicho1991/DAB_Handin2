using System;

namespace DAB2._1
{
    public class PersonIndex
    {
        public void PrintPerson(Person printHim)
        {
            Adress FRa = null;
            foreach (var VARIABLE in printHim.altAdresser)
            {
                if (VARIABLE.TypeOfAdress == "Primary")
                {
                    FRa = VARIABLE.AlternativeAdress;
                }
            }

            //navn
            Console.WriteLine("Navn:\t\t\t" + printHim.GivenName + " " + printHim.MiddleName + " " +
                              printHim.FamilyName);
            //køn
            Console.WriteLine("Køn\t\t\t" + printHim.PersonType);
            //mail
            if (printHim.Email != null)
            {
                Console.WriteLine("Email:\t\t\t" + printHim.Email.UniqueEmail);
            }
            //telefoner
            Console.WriteLine("telefon(er): ");
            int telefoner = 1;
            foreach (var variable in printHim.Telephones)
                Console.WriteLine((telefoner++)+"." + "\t\t\t" + variable.TelephoneNumber + " Type: " + variable.UsageOfTlf + " Teleselskab: " + variable.PhoneCompany); 

            // print primær adresse
            Console.WriteLine("Primær adresse:\t\t" + FRa.ZipCode + " " + FRa.CityName + " " + FRa.StreetName + " " + FRa.HouseNumber);

            //alternative adresser
            if (printHim.altAdresser.Count > 0)
            {
                Console.WriteLine("Andre adresser: ");
            }
           
            int adresser = 1;
            foreach (var Adresse in printHim.altAdresser) //print alternative adresser
                    Console.WriteLine(adresser++ +"."+ "\t\t\t" + Adresse.TypeOfAdress + " " + Adresse.AlternativeAdress.ZipCode + " " + Adresse.AlternativeAdress.CityName + " " +
                                      Adresse.AlternativeAdress.StreetName + " " + Adresse.AlternativeAdress.HouseNumber);
        }
    }
}