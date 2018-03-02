using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAB2._1
{
    public class PersonIndex
    {
        public void printPerson(Person printHIM)
        {
                Console.WriteLine("navn " + printHIM._givenName + " " + printHIM._middleName + " " +
                                  printHIM._familyName);
                Console.WriteLine("email " + printHIM._email.uniqueEmail);
                foreach (var VARIABLE in printHIM.telephones)
                {
                    Console.WriteLine(VARIABLE._telephoneNumber + " " + VARIABLE._usageOfTlf + " " +
                                      VARIABLE._phoneCompany);
                }
            

            foreach (var pikItem in TypeOfAdress.items) //print adresser
            {
                if (pikItem.personer == printHIM)
                {
                    Console.WriteLine("Adresser " + pikItem.adresse._zipCode + " "+pikItem.adresse._cityName + " " + pikItem.adresse._streetName + " " + pikItem.adresse._houseNumber) ;
                }
            }

        }
    }
}
