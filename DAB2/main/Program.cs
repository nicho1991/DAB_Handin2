using System;
using System.Collections.Generic;

using System.Text;
using DAB2._1;


namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            Telephone tlf1 = new Telephone("12345678", "penisCompany", "bootyCalls");
            Email mail1 = new Email("penis@penis.penis");
            Adress adr1 = new Adress("penis", "1337a", "penis", "penisBy");
            Person person1 = new Person(tlf1, adr1, "pik", "tissekone", "pek", "multiGender", mail1);

            item personItem = new item();
            personItem.type = "primary";
            personItem.adresse = adr1;
            personItem.personer = person1;

            TypeOfAdress.items.Add(personItem);

            PersonIndex person = new PersonIndex();

            person.printPerson(person1);
        }
    }
}
