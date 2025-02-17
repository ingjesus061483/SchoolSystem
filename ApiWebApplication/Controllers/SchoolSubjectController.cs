using ApiWebApplication.DataAccess;
using ApiWebApplication.DTO;
using ApiWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Xml;

namespace ApiWebApplication.Controllers
{
  
    public class SchoolSubjectController : ApiController
    {
     
        SchoolDbContext SchoolDbContext { get; set; }
        IQueryable<SchoolSubjectDTO> SchoolSubjectDTOs
        {
            get
            {
                return  SchoolDbContext.SchoolSubjects.Include ("Courses").Include ("CourseSubjects").Include("Teachers").Include("Achievements"). Select (ss=>new SchoolSubjectDTO  // .CourseSubjects.Include("Courses").Include ("SchoolSubjects").Select(x => new CourseSubjectDTO 
                {                       
                    Id = ss.Id,
                    Code = ss.Code,
                    Name = ss.Name,
                    Description = ss.Description,
                    HourAmount = ss.HourAmount,
                   // Achievements =ss.Achievements,
                    CourseSubjects = ss.CourseSubjects. Where(cs=>cs.SchoolSubjectId==ss.Id ). Select (cs=>new CourseSubjectDTO
                    {
                        Id = cs.Id,
                        CourseId = cs.CourseId,
                        Course =cs.Course,
                        SchoolSubjectId = cs.SchoolSubjectId,
                        SchoolSubject=ss,
                        Teacher=cs.Teacher ,
                        TeacherId=cs.TeacherId
                    }).ToList (),              
                });
            }
        }

        public SchoolSubjectController()
        {
            SchoolDbContext = new SchoolDbContext();

        }
        
        // GET: api/SchoolSubject
        public HttpResponseMessage Get()=>  Request.CreateResponse(HttpStatusCode.OK, SchoolSubjectDTOs.ToList());
        

        // GET: api/SchoolSubject/5
        public HttpResponseMessage Get(int id)=> 
            SchoolSubjectDTOs.Where(x => x.Id == id).FirstOrDefault()==null?
            Request.CreateResponse(HttpStatusCode.NotFound, "Registro no encontrado") :
            Request.CreateResponse(HttpStatusCode.OK, SchoolSubjectDTOs.Where(x => x.Id == id).FirstOrDefault());        

        // POST: api/SchoolSubject
        public HttpResponseMessage Post([FromBody]SchoolSubject  value)
        {
            if (!ModelState.IsValid)
            {
                string msg =Utilities . GetErrors (ModelState);
              
                return Request.CreateResponse(HttpStatusCode.BadRequest, msg );
            }
            SchoolDbContext .SchoolSubjects .Add(value);
            SchoolDbContext.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, "Registro guardado");
        }

        // PUT: api/SchoolSubject/5
        public HttpResponseMessage Put(int id, [FromBody]SchoolSubject  value)
        {      
            var response=SchoolDbContext .SchoolSubjects .Where(x=>x.Id==id ).FirstOrDefault() ;
            if (response == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Registro no encontrado");
            }
            if (!ModelState.IsValid)
            {
                string msg = Utilities.GetErrors(ModelState);
                return Request.CreateResponse(HttpStatusCode.BadRequest,msg);
            }
            response .Code = value.Code;
            response .Name = value.Name;
            response .Description = value.Description;
            response .HourAmount = value.HourAmount;        
            SchoolDbContext.SchoolSubjects .AddOrUpdate(value );
            SchoolDbContext .SaveChanges ();
            return Request.CreateResponse(HttpStatusCode.OK, "Registro actualizado");
        }

        // DELETE: api/SchoolSubject/5
        public HttpResponseMessage Delete(int id)
        {
            var response =SchoolDbContext .SchoolSubjects  .Where(x => x.Id == id).FirstOrDefault();
            if (response == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Registro no encontrado");
            }
            SchoolDbContext .SchoolSubjects.Remove(response);
            SchoolDbContext.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, "Registro eliminado");
        }
    }
}
