using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiWebApplication.DataAccess;
using ApiWebApplication.DTO;
using ApiWebApplication.Models;

namespace ApiWebApplication.Controllers
{
    public class AchievementController : ApiController
    {
        SchoolDbContext dbContext = new SchoolDbContext();
        IQueryable<AchievementDTO> achievementDTOs { get
            {
                return dbContext.Achievements.Include("SchoolSubjects").Include("Periods"). Select(x => new AchievementDTO
                {
                    Id = x.Id,
                    Code = x.Code,
                    Title = x.Title,
                    Description = x.Description,
                    SchoolSubject = x.SchoolSubject,
                    SchoolSubjectId = x.SchoolSubjectId,
                    CourseId = x.CourseId,
                   Course=x.Course ,
                   PeriodId=x.PeriodId,
                   Period=x.Period ,

                });
            } 
        }
        // GET: api/Achievement
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, achievementDTOs.ToList());
        }

        // GET: api/Achievement/5
        public HttpResponseMessage  Get(int id)
        {
            var achievement = achievementDTOs .Where(x=> x.Id == id).FirstOrDefault();
            if(achievement == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound,"");
            }
            return Request .CreateResponse (HttpStatusCode.OK,achievement);
        }

        // POST: api/Achievement
        
        public HttpResponseMessage Post([FromBody]Achievement value)
        {
            if(!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
            }
            dbContext.Achievements.Add(value);
            dbContext.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK , "Se ha registrado");

        }

        // PUT: api/Achievement/5
        public HttpResponseMessage Put(int id, [FromBody] Achievement value)
        {
            var achievement = dbContext.Achievements.Where(x => x.Id == id).FirstOrDefault();
            if (achievement == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest,ModelState);
            }
            achievement.Code = value.Code;
            achievement.Title = value.Title;
            achievement.Description = value.Description;
            achievement.SchoolSubjectId = value.SchoolSubjectId;
            achievement.CourseId = value.CourseId;
            achievement.PeriodId = value.PeriodId;
            dbContext.Achievements.AddOrUpdate(achievement);
            dbContext.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, "Registro Actualizado");
        }
        // DELETE: api/Achievement/5
        public HttpResponseMessage Delete(int id) 
        {
            var achievement = dbContext.Achievements.Where(x => x.Id == id).FirstOrDefault();
            if (achievement == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            dbContext.Achievements .Remove(achievement);
            dbContext.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK ,"registro eliminado");
        }
    }
}
