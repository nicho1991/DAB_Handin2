﻿using System;

namespace DAB2._1
{
    public class PersonIndex
    {
        public void PrintPerson(Person printHim)
        {
            Console.WriteLine("navn " + printHim.GivenName + " " + printHim.MiddleName + " " +
                              printHim.FamilyName + " " + printHim.PersonType);
            Console.WriteLine("email " + printHim.Email.UniqueEmail);
            foreach (var variable in printHim.Telephones)
                Console.WriteLine(variable.TelephoneNumber + " " + variable.UsageOfTlf + " " +
                                  variable.PhoneCompany);

            foreach (var pikItem in TypeOfAdress.Items) //print adresser
                if (pikItem.Personer == printHim)
                    Console.WriteLine("Adresser " + pikItem.Adresse.ZipCode + " " + pikItem.Adresse.CityName + " " +
                                      pikItem.Adresse.StreetName + " " + pikItem.Adresse.HouseNumber);
        }
    }
}