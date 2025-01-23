using ApiWebApplication.DataAccess;
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
    public class ConceptController : ApiController
    {
        SchoolDbContext dbContext;
        public ConceptController()
        {
            dbContext = new SchoolDbContext();
        }
        // GET: api/Concept
        public async Task< HttpResponseMessage> Get()
        {
            return Request.CreateResponse (HttpStatusCode.OK,await dbContext .Concepts.ToListAsync());
        }

        // GET: api/Concept/5
        public async Task<HttpResponseMessage> Get(int id)
        {
            var concept=await  dbContext.Concepts.FirstOrDefaultAsync(x => x.Id == id);
            if(concept == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            return Request.CreateResponse(HttpStatusCode.OK ,concept)  ;
        }

        // POST: api/Concept
        public async Task<HttpResponseMessage> Post([FromBody]Concept  value)
        {
            if(!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest,ModelState );
            }
            dbContext.Concepts.Add(value);
           await  dbContext.SaveChangesAsync();
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // PUT: api/Concept/5
        public async Task<HttpResponseMessage> Put(int id, [FromBody]Concept  value)

        {
            var concept=await  dbContext.Concepts.FirstOrDefaultAsync (x => x.Id == id);
            if(concept == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);

            }
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
            }
            concept .Code = value.Code;
            concept.Title = value.Title;
            concept.Description = value.Description;
            dbContext.Concepts.AddOrUpdate(concept);
            await dbContext.SaveChangesAsync();
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // DELETE: api/Concept/5
        public async Task<HttpResponseMessage> Delete(int id)
        {
            var concept = await dbContext.Concepts.FirstOrDefaultAsync(x => x.Id == id);
            if (concept == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);

            }
            dbContext.Concepts.Remove(concept);
            await dbContext.SaveChangesAsync();
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
