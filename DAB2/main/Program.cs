using System;
using DAB2._1;

namespace main
{
    internal class Program
    {
        private static void Main()
        {
            //opret jesper
            var tlfJesper = new Telephone("88888888", "TeleDanmark", "Erhverv");
            var mailJesper = new Email("one@two-three.dk");
            var adr1 = new Adress("Ringvej", "7a", "8000", "Aarhus C");
            var adr2 = new Adress("Landmands vej" , "1" , "2900" , "Hellerup");
            var personJesper = new Person(tlfJesper, adr1, "Jesper", "Jespersen", "Jes", "Mand", mailJesper);

            //opret jesper item
            var personItem = new Item();
            personItem.Type = "primær";
            personItem.Adresse = adr1;
            personItem.Personer = personJesper;

            //giv jesper en alternativ adresse
            var altItem = new Item();
            altItem.Adresse = adr2;
            altItem.Personer = personJesper;
            altItem.Type = "sekundær";

           

            //opret Peter
            var tlf2 = new Telephone("77777777", "TeleDanmark", "Erhverv");
            var mailPeter = new Email("two@two-three.dk");
            var person2 = new Person(tlf2, adr1, "Peter", "Jensen", "", "Mand",mailPeter);
            //giv peter en adresse
            var person3Item = new Item();
            person3Item.Adresse = adr1;
            person3Item.Personer = person2;
            person3Item.Type = "primær";

            //tilføj dem til adresserne
            TypeOfAdress.Items.Add(altItem);
            TypeOfAdress.Items.Add(personItem);
            TypeOfAdress.Items.Add(person3Item);

            //opret et index (til udprintning)
            var person = new PersonIndex();

            person.PrintPerson(personJesper);
            Console.WriteLine("\n");
            person.PrintPerson(person2);

           
        }
    }
}