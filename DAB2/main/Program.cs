using DAB2._1;

namespace main
{
    internal class Program
    {
        private static void Main()
        {
            var personItem = new Item();

            var tlf1 = new Telephone("88888888", "TeleDanmark", "Erhverv");
            var mail1 = new Email("one@two-three.dk");
            var adr1 = new Adress("Ringvej", "7a", "8000", "Aarhus C");
            var person1 = new Person(tlf1, adr1, "Jesper", "Jespersen", "Jes", "Mand", mail1);
            personItem.Type = "primary";
            personItem.Adresse = adr1;
            personItem.Personer = person1;

            TypeOfAdress.Items.Add(personItem);

            var person = new PersonIndex();

            person.PrintPerson(person1);
        }
    }
}