using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAB2._2.DAL;

//hjælp: https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application
//https://codefizzle.wordpress.com/2012/07/26/correct-use-of-repository-and-unit-of-work-patterns-in-asp-net-mvc/
namespace DAB2._2.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Person> PersonRepository { get; }

        void Commit();
    }
}
