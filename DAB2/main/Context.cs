using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAB2_2
    public class personIndexContext : DbContext
    {
        public DbSet<Adress> Adresses { get; set; }

    }
}
