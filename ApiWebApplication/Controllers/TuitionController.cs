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

namespace ApiWebApplication.Controllers
{
    public class TuitionController : ApiController
    {
       SchoolDbContext SchoolDb { get; set; }
        IQueryable<TuitionDTO> Tuitions 
        {
            get 
            {
                return SchoolDb.Tuitions
                    .Include("Students")
                    .Include("WorkingDays")
                    .Include("Course")
                    .Include("Status")
                    .Select(x => new TuitionDTO
                    {
                        Id = x.Id,
                        Code = x.Code,
                        Student=x.Student,
                        StudentId=x.StudentId,
                        WorkingDay=x.WorkingDay,
                        WorkingDayId=x.WorkingDayId,
                        Course=x.Course,
                        CourseId=x.CourseId,
                        FirstDate=x.FirstDate,
                        LastDate=x.LastDate,
                        MonthValue=x.MonthValue,
                        TutionValue=x.TutionValue,
                        Status =x.Status,
                        StatusId=x.StatusId,
                    });    
            } 
        }
        public TuitionController()
        { 
            SchoolDb = new SchoolDbContext();
        }
        [Route ("api/Tuition/WorkingDay")]
        public HttpResponseMessage GetWorkingDay()
        {
            return Request .CreateResponse(HttpStatusCode.OK ,   SchoolDb .WorkingDays);
        }
        // GET: api/Tuition
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, Tuitions.ToList());
        }

        // GET: api/Tuition/5
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, Tuitions.FirstOrDefault(x => x.Id == id));
        }

        // POST: api/Tuition
        public HttpResponseMessage Post([FromBody]Tuition tuition )
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, Utilities.GetErrors(ModelState));
            }
            SchoolDb.Tuitions.Add(tuition);
            SchoolDb .SaveChanges ();
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // PUT: api/Tuition/5
        public HttpResponseMessage Put(int id, [FromBody]Tuition  value)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, Utilities.GetErrors(ModelState));
            }
            var tuition=SchoolDb .Tuitions.FirstOrDefault(x=>x.Id == id);
            if (tuition == null)
                return Request.CreateResponse(HttpStatusCode.NotFound );
            tuition.Code = value .Code ;
            tuition.StudentId = value .StudentId ;
            tuition.WorkingDayId = value .WorkingDayId;
            tuition.FirstDate =value .FirstDate ;
            tuition.LastDate = value.LastDate ;
            tuition.CourseId = value . CourseId;
            tuition.MonthValue = value.MonthValue;
            tuition.TutionValue = value .TutionValue ;
            SchoolDb .Tuitions .AddOrUpdate(tuition);
            SchoolDb.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // DELETE: api/Tuition/5
        public HttpResponseMessage Delete(int id)
        {
           var value= SchoolDb.Tuitions.First(x => x.Id == id);
            if (value == null)
            { 
                return Request .CreateResponse (HttpStatusCode.NotFound );
            }
            SchoolDb.Tuitions.Remove(value);
            SchoolDb .SaveChanges ();
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
