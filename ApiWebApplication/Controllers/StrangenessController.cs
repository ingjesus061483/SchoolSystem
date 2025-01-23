using ApiWebApplication.DataAccess;
using ApiWebApplication.DTO;
using ApiWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ApiWebApplication.Controllers
{
    public class StrangenessController : ApiController
    {
        SchoolDbContext dbContext;  
        public StrangenessController()
        { 
            dbContext = new SchoolDbContext();

        }
            // GET: api/Strangeness
        public async Task<HttpResponseMessage>  Get()
        {
            return Request .CreateResponse(HttpStatusCode.OK,await  dbContext .Strangenesses .ToListAsync());
        }

        // GET: api/Strangeness/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Strangeness
        public async Task<HttpResponseMessage> Post([FromBody]Strangeness value)
        {
            if(!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);

            }
            dbContext.Strangenesses .Add(value);
           await dbContext.SaveChangesAsync();
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // PUT: api/Strangeness/5
        public async Task<HttpResponseMessage> Put(int id, [FromBody]Strangeness  value)
        {   
            var str =await dbContext .Strangenesses.FirstOrDefaultAsync(x => x.Id == id);
            if (str == null)
                return Request.CreateResponse(HttpStatusCode.NotFound );
            if(!ModelState.IsValid  )
            {
              return Request .CreateResponse(HttpStatusCode .BadRequest, ModelState);

            }
            str.Code = value.Code;
            str.ConceptId = value.ConceptId;
            str .TuitionId = value.TuitionId;
            str.Date = value.Date;
            str .Detail = value.Detail;
            dbContext .Strangenesses.AddOrUpdate(str);
            await dbContext.SaveChangesAsync();
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // DELETE: api/Strangeness/5
        public async Task<HttpResponseMessage> Delete(int id)
        {
            var str = await dbContext.Strangenesses.FirstOrDefaultAsync(x => x.Id == id);
            if (str == null)
                return Request.CreateResponse(HttpStatusCode.NotFound);
            dbContext.Strangenesses.Remove(str);
            await dbContext.SaveChangesAsync();
            return Request.CreateResponse(HttpStatusCode.OK);
            
        }
    }
}
