
using System.Data.Entity;
using System.Linq;
using DAB2._2.DAL;

namespace DAB2._2.UnitOfWork
{
    public class EFUnitOfWork : DbContext , IUnitOfWork
    {
        private readonly EFRepositorycs<Person> _personRepository;
        private readonly EFRepositorycs<Adress> _AdressRepository;
        private readonly EFRepositorycs<Telephone> _TelephoneRepository;
        private readonly EFRepositorycs<AltAdresse> _AltAdressRepository;

        public DbSet<Person> Persons { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Telephone> Telephones { get; set; }
        public DbSet<AltAdresse> AltAdresses { get; set; }

        public EFUnitOfWork()
        {
            _personRepository = new EFRepositorycs<Person>(Persons);
            _AdressRepository = new EFRepositorycs<Adress>(Adresses);
            _TelephoneRepository = new EFRepositorycs<Telephone>(Telephones);
            _AltAdressRepository = new EFRepositorycs<AltAdresse>(AltAdresses);

        }

        #region unit of work implementation

        public void addPerson(Person thisOne)
        {
            if (!_personRepository.Find(x => x.Email.UniqueEmail == thisOne.Email.UniqueEmail).Any())
            {
                _personRepository.Add(thisOne);
            }
        }

        public Person GetPersonByEmail(string Email)
        {
            int ID;
            
            Person ThePerson = _personRepository.First(x => x.Email.UniqueEmail == Email);
            if (ThePerson != null)
            {
                ID = ThePerson.PersonID;
            }
            else
            {
                ThePerson.GivenName = "does not exsist";
                return ThePerson; // did not exsist
            }

            Telephone newtlf = _TelephoneRepository.First(x => x.PersonRefId == ID);

            return ThePerson;
        }

        public void Commit()
        {
            this.SaveChanges();
        }

        #endregion

    }
}
