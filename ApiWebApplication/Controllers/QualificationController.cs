using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiWebApplication.DataAccess;
using ApiWebApplication.DTO;
using ApiWebApplication.Models;

namespace ApiWebApplication.Controllers
{
    public class QualificationController : ApiController
    {
        SchoolDbContext dbContext=new SchoolDbContext();
        IQueryable<QualificationDTO> QualificationDTOs
        {
            get
            {
                return dbContext.Qualifications.Include ("Achievements").Include("Students").Select(x => new QualificationDTO
                {
                    Id=x.Id,
                    Code=x.Code,
                    Title=x.Title,
                    DateTime=x.DateTime,
                    Note=x.Note,
                    Detail=x.Detail,
                    StudentId=x.StudentId,
                    Student=x.Student,
                    AchievementID=x.AchievementID,
                    Achievement=x.Achievement,
                });                    
            }
        }
        // GET: api/Qualification
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, QualificationDTOs);
        }

        // GET: api/Qualification/5
        public HttpResponseMessage Get(int id)
        {
            var q = QualificationDTOs.FirstOrDefault(x => x.Id == id);
            if (q == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            return Request.CreateResponse(HttpStatusCode.OK, q);




        }

        // POST: api/Qualification
        public HttpResponseMessage Post([FromBody]Qualification value)
        {
            if(!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest ,ModelState ) ;
            }
            dbContext.Qualifications.Add(value);
            dbContext.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK,"Registro insertado");

        }

        // PUT: api/Qualification/5
        public HttpResponseMessage Put(int id, [FromBody] Qualification value)
        {
            var q = dbContext.Qualifications.FirstOrDefault(x => x.Id == id);
            if (q == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
            }
            q.Code = value.Code;
            q.DateTime = value.DateTime; q.Title = value.Title;
            q.Note = value.Note;
            q.StudentId = value.StudentId;
            q.AchievementID = value.AchievementID;
            q.Detail = value.Detail;
            return Request.CreateResponse(HttpStatusCode.OK, "Registro actualizado");
        }
        // DELETE: api/Qualification/5
        public HttpResponseMessage Delete(int id)
        {
            var q = dbContext.Qualifications.FirstOrDefault(x => x.Id == id);
            if (q == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            dbContext.Qualifications.Remove(q);
            dbContext.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK,"Registro eliminado");
        }
    }
}
