
using System.Data.Entity;

using DAB2._2.DAL;

namespace DAB2._2.UnitOfWork
{
    public class EFUnitOfWork : DbContext , IUnitOfWork
    {
        private readonly EFRepositorycs<Person> _personRepository;

        public DbSet<Person> Persons { get; set; }

        public EFUnitOfWork()
        {
            _personRepository = new EFRepositorycs<Person>(Persons);
        }

        #region unit of work implementation

        public IGenericRepository<Person> PersonRepository
        {
            get { return _personRepository; }
        }

        public void Commit()
        {
            this.SaveChanges();
        }

        #endregion

    }
}
