using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using DAB2._2.UnitOfWork;

namespace DAB2._2.DAL
{
    public class PersonRepository: Repository<Person>
    {
        private DBContext _context;

        public PersonRepository(DBContext context) : base(context)
        {

            _context = context;
        }

        public async Task AddUser(Person thisUser)
        {
            try
            {
                GetUserByEmail(thisUser.Email.UniqueEmail);
                Console.WriteLine("user already exsist!");
            }
            catch (Exception e)
            {
                Document created = await _Context.client.CreateDocumentAsync(_Context.PersonCollection.DocumentsLink, thisUser);
                Console.WriteLine(created);

            }

        }

        public Person GetUserByEmail(string id)
        {

            Person TheUser = _Context.client.CreateDocumentQuery<Person>(_Context.PersonCollection.DocumentsLink)
                .Where(x => x.Email.UniqueEmail == id)
                .AsEnumerable()
                .FirstOrDefault();
            if (TheUser == null)
            {
                throw new ArgumentException("User dosent exsist");
            }

            return TheUser;
        }

        public void DeleteUserByEmail(string Email)
        {
            Document doc = GetDoc(Email);
            if (doc != null)
            {
                _Context.client.DeleteDocumentAsync(doc.SelfLink).Wait();
            }
        }

        private Document GetDoc(string id)
        {
            return _Context.client.CreateDocumentQuery(_Context.PersonCollection.DocumentsLink).Where(x => x.Id == id)
                .AsEnumerable().FirstOrDefault();
        }

    }
}
