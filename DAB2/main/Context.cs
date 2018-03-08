
using System.Data.Entity;

namespace DAB2_2
{
    public class personIndexContext : DbContext
    {
        public DbSet<Adress> AdressesSet { get; set; }
        public DbSet<Email> EmailSet { get; set; }
        public DbSet<Person> PersonSet { get; set; }
        public DbSet<Telephone> TelephoneSet { get; set; }
    }

}

