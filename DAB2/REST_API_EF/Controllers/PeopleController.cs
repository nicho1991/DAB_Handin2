using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using DAB2._2.UnitOfWork;
using REST_API_EF.Models;

namespace REST_API_EF.Controllers
{
    public class PeopleController : ApiController
    {
        private REST_API_EFContext db = new REST_API_EFContext();
        private EFUnitOfWork dbUnit = new EFUnitOfWork();

        // GET: api/People
        public IQueryable<Person> GetPeople()
        {
            return dbUnit.Persons.AsQueryable();

        }

        // GET: api/People/5
        [ResponseType(typeof(Person))]
        public async Task<IHttpActionResult> GetPerson(string id)
        {
            Person person;
            person = dbUnit.GetPersonByEmail(id);
            if (person == null)
            {
                return NotFound();
            }

            return Ok(person);
        }

        // PUT: api/People/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPerson(int id, Person person)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != person.PersonID)
            {
                return BadRequest();
            }

            db.Entry(person).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/People
        [ResponseType(typeof(Person))]
        public async Task<IHttpActionResult> PostPerson(Person person)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.People.Contains(person);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = person.PersonID }, person);
        }

        //// DELETE: api/People/5
        //[ResponseType(typeof(Person))]
        //public async Task<IHttpActionResult> DeletePerson(int id)
        //{
        //    Person person = await db.People.ElementAt(id);
        //    if (person == null)
        //    {
        //        return NotFound();
        //    }

        //    db.People.Remove(person);
        //    await db.SaveChangesAsync();

        //    return Ok(person);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PersonExists(int id)
        {
            return db.People.Count(e => e.PersonID == id) > 0;
        }
    }
}