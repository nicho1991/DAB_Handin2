using System;

namespace DAB2._2.DAL
{
    public class Repository<T> where T : class
    {
        protected readonly DBContext _Context;

        public Repository(DBContext context)
        {
            Console.WriteLine("called");
            _Context = context;
        }

    }
}