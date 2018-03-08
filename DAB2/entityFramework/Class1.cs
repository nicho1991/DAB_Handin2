
using System.Data.Entity;

namespace context
{
    public class personIndexContext : DbContext
    {
        public DbSet<Adress> Adresses { get; set; }

    }
}
