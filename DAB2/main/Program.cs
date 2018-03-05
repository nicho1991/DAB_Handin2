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
            var adr2 = new Adress("Landmands vej" , "1" , "2900" , "Hellerup");
            var person1 = new Person(tlf1, adr1, "Jesper", "Jespersen", "Jes", "Mand", mail1);
            personItem.Type = "primær";
            personItem.Adresse = adr1;
            personItem.Personer = person1;

            var altItem = new Item();
            altItem.Adresse = adr2;
            altItem.Personer = person1;
            altItem.Type = "sekundær";
            TypeOfAdress.Items.Add(altItem);
            TypeOfAdress.Items.Add(personItem);

            var person = new PersonIndex();

            person.PrintPerson(person1);
        }
    }
}