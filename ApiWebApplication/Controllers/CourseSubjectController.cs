using ApiWebApplication.DataAccess;
using ApiWebApplication.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiWebApplication.Controllers
{
    public class CourseSubjectController : ApiController
    {
        SchoolDbContext SchoolDbContext { get; set; }
        public CourseSubjectController()
        {
            SchoolDbContext = new SchoolDbContext();
        }
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public HttpResponseMessage Post([FromBody] CourseSubject value)
        {
            if (!ModelState.IsValid)
            {
                string msg = Utilities.GetErrors(ModelState);
                return Request.CreateResponse(HttpStatusCode.BadRequest, msg);
            }
            SchoolDbContext.CourseSubjects.Add(value);
            SchoolDbContext.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, "Registro guardado");
        }

        // PUT api/values/5
        public HttpResponseMessage Put(int id, [FromBody] CourseSubject  value)
        {
              var old = SchoolDbContext.CourseSubjects.FirstOrDefault(x => x.Id == id);
            if (old == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Registro no encontrado");

            }
            if (!ModelState.IsValid  )
            {
                string msg = Utilities.GetErrors(ModelState);
                return Request.CreateResponse(HttpStatusCode.BadRequest, msg);

            }
            old.CourseId=value .CourseId;
            old.SchoolSubjectId =value .SchoolSubjectId;
            SchoolDbContext.CourseSubjects .AddOrUpdate(old);
            SchoolDbContext.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, "Registro actualizado");

        }

        // DELETE api/values/5
        public HttpResponseMessage Delete(int id)
        {

            var value = SchoolDbContext.CourseSubjects.FirstOrDefault(x => x.Id == id);
            if (value == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Registro no encontrado");

            }
            SchoolDbContext.CourseSubjects.Remove(value);
            SchoolDbContext.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, "Registro Eliminado");
        }
    }
}
