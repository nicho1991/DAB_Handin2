
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
        private readonly EFRepositorycs<Email> _emailRepository;

        public DbSet<Person> Persons { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Telephone> Telephones { get; set; }
        public DbSet<AltAdresse> AltAdresses { get; set; }
        public DbSet<Email> Emails { get; set; }

        public EFUnitOfWork() : base("name=ToSrv")
        {
            _personRepository = new EFRepositorycs<Person>(Persons);
            _AdressRepository = new EFRepositorycs<Adress>(Adresses);
            _TelephoneRepository = new EFRepositorycs<Telephone>(Telephones);
            _AltAdressRepository = new EFRepositorycs<AltAdresse>(AltAdresses);
            _emailRepository = new EFRepositorycs<Email>(Emails);

        }

        #region unit of work implementation

        public void addPerson(Person thisOne)
        {
            if (!_personRepository.Find(x => x.Email.UniqueEmail == thisOne.Email.UniqueEmail).Any())
            {
                _personRepository.Add(thisOne);
            }
        }

        public Person GetPersonByEmail(string EmailParam)
        {

            Email NewEmail = _emailRepository.First(x => x.UniqueEmail.ToString() == EmailParam);
            if (NewEmail == null)
            {
                Person FalsePerson = null;
                return FalsePerson;
            }

            Person TempPerson = _personRepository.First(x => x.Email.UniqueEmail == EmailParam);
            int ID = TempPerson.PersonID;

            Telephone newtlf = _TelephoneRepository.First(x => x.PersonRefId == ID);
            Email newEmail = _emailRepository.First(x => x.UniqueEmail == EmailParam);
            Adress newPrimaryAdress = _AltAdressRepository.First(x => x.person.PersonID == TempPerson.PersonID).AlternativeAdress;

            Person PersonToReturn = new Person(newtlf, newPrimaryAdress, TempPerson.GivenName, TempPerson.FamilyName, TempPerson.MiddleName, TempPerson.Type, newEmail);
            AltAdresse tempAltAdress = new AltAdresse();

            foreach (var VARIABLE in _AltAdressRepository.Find(x => x.person.PersonID == ID))
            {
                VARIABLE.AlternativeAdress = _AdressRepository.First(x => x.adressID == VARIABLE.altAdrID);
                PersonToReturn.altAdresser.Add(VARIABLE); 
            }
            return PersonToReturn;
        }

        public void Commit()
        {
            this.SaveChanges();
        }

        #endregion

    }
}
