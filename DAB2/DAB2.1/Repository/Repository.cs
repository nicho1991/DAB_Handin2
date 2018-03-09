using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAB2._1.Repository
{
    public interface IPersonIndexRepository
    {
        IEnumerable<Person> GetPersons();
        Person GetPersonByID(int PersonID);

    }
}
