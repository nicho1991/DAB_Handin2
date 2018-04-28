using System;
using System.Collections.Generic;
using System.Data;

using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using DAB2._2;
using DAB2._2.UnitOfWork;
using HandIn3._2.Models;
using REST_API_EF.Models;

namespace HandIn3._2.Controllers
{
    public class PeopleController : ApiController
    {

        private DocumentDBUnitOfWork db = new DocumentDBUnitOfWork(new DBContext());

        //// GET: api/People
        //public IEnumerable<PersonDTO> GetPeople()
        //{
        //    List<PersonDTO> people = new List<PersonDTO>();

        //    foreach (Person p in db.Persons)
        //    {
        //        people.Add(new PersonDTO(p));
        //    }
        //    return people;
        //    //return people.AsQueryable();
        //}

        //// GET: api/People/5
        //[ResponseType(typeof(PersonDTO))]
        //public async Task<IHttpActionResult> GetPerson(int id)
        //{
        //    Person person = await db.Persons.FindAsync(id);

        //    if (person == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(new PersonDTO(person));
        //}

        //// PUT: api/People/5
        //[ResponseType(typeof(void))]
        //public async Task<IHttpActionResult> PutPerson(int id, Person person)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != person.PersonID)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(person).State = EntityState.Modified;

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!PersonExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/People
        //[ResponseType(typeof(Person))]
        //public async Task<IHttpActionResult> PostPerson(Person person)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Persons.Add(person);
        //    await db.SaveChangesAsync();

        //    return CreatedAtRoute("DefaultApi", new { id = person.PersonID }, person);
        //}

        //// DELETE: api/People/5
        //[ResponseType(typeof(Person))]
        //public async Task<IHttpActionResult> DeletePerson(int id)
        //{
        //    Person person = await db.Persons.FindAsync(id);
        //    if (person == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Persons.Remove(person);
        //    await db.SaveChangesAsync();

        //    return Ok(person);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool PersonExists(int id)
        //{
        //    return db.Persons.Count(e => e.PersonID == id) > 0;
        //}
    }
}