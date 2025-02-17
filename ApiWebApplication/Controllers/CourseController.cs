using ApiWebApplication.DataAccess;
using ApiWebApplication.DTO;
using ApiWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ApiWebApplication.Controllers
{
    public class CourseController : ApiController
    {
        SchoolDbContext SchoolDbContext { get; set; }
        IQueryable<CourseDTO> CourseList
        {
            get
            {
                return SchoolDbContext.Courses.Include("SchoolSubjects").Include ("Achievements"). Include("CourseSubjects").Include("Teachers").Select(c => new CourseDTO
                {
                    Id = c.Id,
                    Name = c.Name,
                    Code = c.Code,
                    Description = c.Description,
                    Amount = c.Amount,
                   // Achievements = c.Achievements,
                    CourseSubjects =c.CourseSubjects .Where (sc=>sc.CourseId == c.Id).Select (sc=>new CourseSubjectDTO
                    {
                        Id=sc.Id,
                        CourseId=sc.CourseId ,
                        SchoolSubject =sc.SchoolSubject, 
                        Course=c,
                        Teacher=sc.Teacher,
                        TeacherId=sc.TeacherId,
                        SchoolSubjectId=sc.SchoolSubjectId
                    }).ToList (),
                });
            }
        }
        
        public CourseController()
        {
            SchoolDbContext = new SchoolDbContext();
        }
        
        public  HttpResponseMessage Get() =>
            CourseList.Count() == 0 ?
            Request.CreateResponse(HttpStatusCode.BadRequest, "No se encontraron registros en la lista") :
            Request.CreateResponse(HttpStatusCode.OK, CourseList.ToList());
        
        // GET: api/Course/5
        public HttpResponseMessage Get(int id)=> 
            CourseList .FirstOrDefault(x => x.Id == id)==null?
            Request.CreateResponse(HttpStatusCode.NotFound, "Registro no encontrado"):
            Request.CreateResponse(HttpStatusCode.OK, CourseList .FirstOrDefault(x => x.Id == id));
        
        // POST: api/Course
        public HttpResponseMessage Post([FromBody]Course course )
        {
            if (!ModelState.IsValid)
            {
                string msg = Utilities.GetErrors(ModelState);
                return Request.CreateResponse(HttpStatusCode.BadRequest,msg );
            }
            SchoolDbContext.Courses .Add(course);
            SchoolDbContext .SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK , "Registro guardado");
        }

        // PUT: api/Course/5        
        public HttpResponseMessage Put(int id, [FromBody]Course course)
        {
            if (!ModelState.IsValid) 
            {
                string msg = Utilities.GetErrors(ModelState);
                return Request.CreateResponse(HttpStatusCode.BadRequest, msg);
            }
            var cour= SchoolDbContext.Courses. FirstOrDefault(x => x.Id == id);
            if (cour==null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Registro no encontrado");
            }
            cour.Name = course .Name ;
            cour.Description = course .Description ;
            cour.Code = course.Code;
            cour.Amount =course .Amount ;
            SchoolDbContext.Courses .AddOrUpdate (cour);
            SchoolDbContext .SaveChanges ();
            return Request.CreateResponse(HttpStatusCode.OK,"Registro actualizado" );            
        }

        // DELETE: api/Course/5
        public HttpResponseMessage Delete(int id)
        {
            var cour = SchoolDbContext.Courses.FirstOrDefault(x => x.Id == id);
            if (cour==null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Registro no encontrado");
            }
            SchoolDbContext.Courses .Remove(cour);
            SchoolDbContext.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK,"Registro eliminado" );
        }
    }
}
