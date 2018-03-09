using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

//hjælp https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application
//https://codefizzle.wordpress.com/2012/07/26/correct-use-of-repository-and-unit-of-work-patterns-in-asp-net-mvc/   
namespace DAB2._2.DAL
{
    public interface IGenericRepository<T> where T : class
    {
    IQueryable<T> AsQueryable();

    IEnumerable<T> GetAll();
    IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
    T Single(Expression<Func<T, bool>> predicate);
    T SingleOrDefault(Expression<Func<T, bool>> predicate);
    T First(Expression<Func<T, bool>> predicate);
    T GetById(int id);

    void Add(T entity);
    void Delete(T entity);
    void Attach(T entity);
    }
}
