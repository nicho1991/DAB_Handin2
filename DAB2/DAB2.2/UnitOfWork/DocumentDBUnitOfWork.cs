using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using System.Threading.Tasks;
using DAB2._2.DAL;
using DAB2._2.UnitOfWork;

namespace DAB2._2.UnitOfWork
{

        public class DocumentDBUnitOfWork
        {
            public PersonRepository _PersonRepository;
            private readonly DBContext _context;

            public DocumentDBUnitOfWork(DBContext context)
            {
                _context = context;
                _PersonRepository = new PersonRepository(_context);

            }
        }
    }

