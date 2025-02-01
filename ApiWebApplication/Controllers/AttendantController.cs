using ApiWebApplication.DataAccess;
using ApiWebApplication.DTO;
using ApiWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ApiWebApplication.Controllers
{
    public class AttendantController : ApiController
    {
        SchoolDbContext SchoolDbContext { get; set; }
        IQueryable<AttendantDTO> Attendants 
        {
            get
            {
                return SchoolDbContext.Attenants.Include("Relationships").Select(x => new AttendantDTO
                {
                    Id = x.Id,
                    Identification = x.Identification,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    BirthDate = x.BirthDate,
                    Address = x.Address,
                    PhoneNumber = x.PhoneNumber,
                    Email = x.Email,
                    Relationship = x.Relationship,
                    RelationshipId = x.RelationshipId,
                });

            }
        }

        public AttendantController() 
        {
            SchoolDbContext = new SchoolDbContext();
        }
        [Route("api/Attendant/Relationships")]
        public async Task<HttpResponseMessage> GetRelationships()
        {
            return Request.CreateResponse(HttpStatusCode.OK,await  SchoolDbContext.Relationships.ToListAsync());
        }
        // GET: api/Attendant
        public async Task<HttpResponseMessage> Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, await Attendants.ToListAsync ());
        }

        // GET: api/Attendant/5
        public async Task<HttpResponseMessage> Get(int id)
        {
            Attendant attendant = await SchoolDbContext.Attenants.FirstOrDefaultAsync(x => x.Id == id);
            if (attendant == null)
                return Request.CreateResponse(HttpStatusCode.NotFound);
            return Request.CreateResponse(HttpStatusCode.OK, await SchoolDbContext.Attenants.FirstOrDefaultAsync(x=>x.Id ==id));
        }

        // POST: api/Attendant
        public async Task<HttpResponseMessage> Post([FromBody]Attendant value)
        {
            if (!ModelState.IsValid )
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
            }
            SchoolDbContext .Attenants .Add(value);
            await SchoolDbContext.SaveChangesAsync();
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // PUT: api/Attendant/5
        public async Task<HttpResponseMessage> Put(int id, [FromBody]Attendant value)
        {
            if(!ModelState .IsValid )
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
            }

            Attendant attendant = await SchoolDbContext.Attenants.FirstOrDefaultAsync(x => x.Id == id);
            if (attendant == null)
                return Request.CreateResponse(HttpStatusCode.NotFound);
            attendant .Identification = value.Identification;
            attendant.FirstName = value.FirstName;
            attendant.LastName = value.LastName;
            attendant.BirthDate = value.BirthDate;
            attendant .Email = value.Email;
            attendant .PhoneNumber = value.PhoneNumber;
            attendant.Address = value.Address;
            attendant.RelationshipId = value.RelationshipId;
            SchoolDbContext .Attenants.AddOrUpdate(attendant);
            await SchoolDbContext .SaveChangesAsync();
           return  Request.CreateResponse(HttpStatusCode.OK);
        }

        // DELETE: api/Attendant/5
        public async Task<HttpResponseMessage> Delete(int id)
        {
            Attendant attendant = await SchoolDbContext.Attenants.FirstOrDefaultAsync(x => x.Id == id);
            if (attendant == null)
                return Request.CreateResponse(HttpStatusCode.NotFound);
            SchoolDbContext.Attenants.Remove(attendant);
            await SchoolDbContext.SaveChangesAsync();
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
