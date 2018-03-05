using DAB2._1;

namespace main
{
    internal class Program
    {
        private static void Main()
        {
            var personItem = new Item();

            var tlf1 = new Telephone("12345678", "penisCompany", "bootyCalls");
            var mail1 = new Email("penis@penis.penis");
            var adr1 = new Adress("penis", "1337a", "penis", "penisBy");
            var person1 = new Person(tlf1, adr1, "pik", "tissekone", "pek", "multiGender", mail1);
            personItem.Type = "primary";
            personItem.Adresse = adr1;
            personItem.Personer = person1;

            TypeOfAdress.Items.Add(personItem);

            var person = new PersonIndex();

            person.PrintPerson(person1);
        }
    }
}