using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;

namespace DAB2._2.DAL
{
    class DocumentDBRepository<T> : IGenericRepository<T> where T : class
    {
        private DocumentClient client;
        private DocumentCollection collection;
        public DocumentDBRepository(DocumentCollection p, DocumentClient x)
        {
            client = x;
            collection = p;
        }
        public void Add(T entity)
        {
            
            throw new NotImplementedException();
        }

        public IQueryable<T> AsQueryable()
        {
            throw new NotImplementedException();
        }

        public void Attach(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T First(Func<T, bool> predicate)
        {
            return client.CreateDocumentQuery<T>("personCollection").AsEnumerable().First(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public T Single(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T SingleOrDefault(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
