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
    public class PeriodController : ApiController
    {
        SchoolDbContext dbContext = new SchoolDbContext();
        IQueryable<PeriodDTO> periodDTOs
        {
            get 
            {
                return dbContext.Periods.Select(x => new PeriodDTO
                {
                    Id = x.Id,
                    Title= x.Title,
                    Since= x.Since,
                    Untill= x.Untill,
                    Description= x.Description,
                    Achievements= x.Achievements,
                });
            }
        }
        // GET: api/Period
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, periodDTOs.ToList());
        }

        // GET: api/Period/5
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, periodDTOs.FirstOrDefault(x=>x.Id==id)) ;
        }

        // POST: api/Period
        public HttpResponseMessage Post([FromBody]Period value)
        {
            if (!ModelState .IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
            }
            dbContext.Periods.Add(value);
            dbContext.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, "registro insertado");

        }

        // PUT: api/Period/5
        public HttpResponseMessage Put(int id, [FromBody]Period  value)
        {
            var period = dbContext.Periods.FirstOrDefault(x => x.Id == id);
            if(period==null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            if(!ModelState.IsValid)
            {
                Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
            }
            period .Title = value.Title;
            period .Description = value.Description;
            period .Since=value.Since;
            period .Untill =value.Untill;
            dbContext.Periods.AddOrUpdate(period);
            dbContext.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, "registro actualizado");
        }

        // DELETE: api/Period/5
        public HttpResponseMessage Delete(int id)
        {
            var period = dbContext.Periods.FirstOrDefault(x => x.Id == id);
            if (period == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            dbContext.Periods.Remove(period);
            dbContext.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, "registro eliminado");
        }
    }
}
