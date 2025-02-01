using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ApiWebApplication.DataAccess;
using ApiWebApplication.DTO;
using ApiWebApplication.Models;

namespace ApiWebApplication.Controllers
{
    public class StudentsController : ApiController
    {
        private SchoolDbContext db = new SchoolDbContext();

        [Route ("api/Students/IdentificationTypes")]
        public IQueryable<IdentificationType > GetIdentificationType()
        {
            return db .IdentificationTypes;
        }
        [Route("api/Students/Sexes")]
        public IQueryable<Sex > GetSex()
        {
            return db.Sexes;
        }
        // GET: api/Students
        public IQueryable<StudentDTO> GetStudents()
        {
            return db.Students
                .Include("Sexes")
                .Include("Status")
                .Include("Pictures")
                .Include("PicturePersons")
                .Include ("Attendants")
                .Include("IdentificationTypes")
                .Select( x=>new StudentDTO
                { 
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Address = x.Address,
                    PhoneNumber = x.PhoneNumber,
                    Email = x.Email,
                    BirthDate = x.BirthDate,
                    Identification = x.Identification,
                    IdentificationType = x.IdentificationType,
                    Sex = x.Sex,
                    SexId = x.SexId,                    
                    IdentificationTypeId = x.IdentificationTypeId,
                    Attendant=x.Attendant,
                    AttendantId = x.AttendantId,
                    PicturePeople =x. picturePeople.Where (p=>p.StudentId==x.Id).Select (p=>new PicturePersonDTO
                    { 
                       Id=p.Id,
                       Picture=p.Picture,
                       PictureId=p.PictureId,
                       Student=x.FirstName+" "+x.LastName,
                       StudentId=p.StudentId,
                    }).ToList ()
                }) ;
        }

        // GET: api/Students/5
        [ResponseType(typeof(Student))]
        public IHttpActionResult GetStudent(int id)
        {
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        // PUT: api/Students/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutStudent(int id, Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != student.Id)
            {
                return BadRequest();
            }

            db.Entry(student).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(id))
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

        // POST: api/Students
        [ResponseType(typeof(Student))]
        public IHttpActionResult PostStudent(Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Students.Add(student);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = student.Id }, student);
        }

        // DELETE: api/Students/5
        [ResponseType(typeof(Student))]
        public IHttpActionResult DeleteStudent(int id)
        {
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }

            db.Students.Remove(student);
            db.SaveChanges();

            return Ok(student);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StudentExists(int id)
        {
            return db.Students.Count(e => e.Id == id) > 0;
        }
    }
}