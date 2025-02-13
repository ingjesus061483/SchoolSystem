using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices.ComTypes;
using System.Web.Helpers;
using System.Web.Http;
using ApiWebApplication.DataAccess;
using ApiWebApplication.DTO;
using ApiWebApplication.Models;

namespace ApiWebApplication.Controllers
{
    public class TeacherController : ApiController
    {
        private SchoolDbContext db = new SchoolDbContext();
        IQueryable<TeacherDTO> teacherDTOs 
        {
            get
            {
                return db.Teachers.Include("IdentificationTypes").Include("sexes").Include("CourseSubjects").
                    Include("courses").Include("SchoolSubjects").Include ("PicturePersons").
                    Select(t => new TeacherDTO
                    {
                    Id = t.Id,
                    Identification=t.Identification,
                    FirstName=t.FirstName,
                    LastName=t.LastName,
                    BirthDate=t.BirthDate,
                    Address=t.Address,
                    PhoneNumber=t.PhoneNumber,
                    Email=t.Email,
                    IdentificationTypeId=t.IdentificationTypeId,
                    IdentificationType=t.IdentificationType,
                    Sex=t.Sex,
                    SexId=t.SexId,
                    CourseSubjects=t.CourseSubjects.Where(cs => cs.TeacherId  == t.Id).Select(cs=>new CourseSubjectDTO
                    {
                        CourseId=cs.CourseId,
                        Id=cs.Id,                      
                        TeacherId=cs.TeacherId,
                        SchoolSubjectId=cs.SchoolSubjectId,
                        Course=cs.Course,
                        SchoolSubject=cs.SchoolSubject 

                    }).ToList(),
                        PicturePeople = t.picturePeople.Where(p => p.TeacherId  == t.Id).Select(p => new PicturePersonDTO
                        {
                            Id = p.Id,
                            Picture = p.Picture,
                            PictureId = p.PictureId,
                            Teacher  = t.FirstName + " " + t.LastName,
                            TeacherId = p.TeacherId ,
                        }).ToList()




                    });
            }
        }
     
        // GET: api/Teacher
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, teacherDTOs.ToList());

        }

        // GET: api/Teacher/5
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, teacherDTOs.Where(t=>t.Id==id).FirstOrDefault());
        }

        // POST: api/Teacher
        public HttpResponseMessage Post([FromBody]Teacher  value)
        {
            if(!ModelState .IsValid)
            {
                string msg = Utilities.GetErrors(ModelState);
                return Request.CreateResponse(HttpStatusCode.BadRequest,msg);
            }
            db.Teachers.Add(value);
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // PUT: api/Teacher/5
        public HttpResponseMessage Put(int id, [FromBody]Teacher value)
        {
           var teacher= db.Teachers.Where(x => x.Id == id).FirstOrDefault();
            if (teacher == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            if(!ModelState.IsValid)
            {
                string msg = Utilities.GetErrors(ModelState);
                return Request.CreateResponse(HttpStatusCode.BadRequest, msg);
            }            
            teacher.Identification = value.Identification;
            teacher.FirstName = value.FirstName;
            teacher.LastName = value.LastName;
            teacher.BirthDate = value.BirthDate;
            teacher.Address = value.Address;
            teacher.PhoneNumber = value.PhoneNumber;
            teacher.Email = value.Email;
            teacher.IdentificationTypeId = value.IdentificationTypeId;
            teacher.SexId = value.SexId;
            db.Teachers.AddOrUpdate(teacher);
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK);
            


        }

        // DELETE: api/Teacher/5
        public HttpResponseMessage Delete(int id)
        {
            var teacher = db.Teachers.Where(x => x.Id == id).FirstOrDefault();
            if (teacher == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            db.Teachers.Remove(teacher);
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK );
        }
    }
}
