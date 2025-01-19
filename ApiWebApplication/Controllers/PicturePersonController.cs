using ApiWebApplication.DataAccess;
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
    public class PicturePersonController : ApiController
    {
        SchoolDbContext context;
        public PicturePersonController() { 
            context = new SchoolDbContext();
        }
        // GET: api/PicturePerson
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/PicturePerson/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PicturePerson
        public HttpResponseMessage Post([FromBody]List <PicturePerson> picturePeople )
        {
            picturePeople .ForEach(s => context.PicturePeople.AddOrUpdate(p => p.PictureId, s)); 
            context .SaveChanges();
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        // PUT: api/PicturePerson/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PicturePerson/5
        public void Delete(int id)
        {
        }
    }
}
