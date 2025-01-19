using ApiWebApplication.DataAccess;
using ApiWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiWebApplication.Controllers
{
    public class PictureController : ApiController
    {
       SchoolDbContext db;
        public PictureController() 
        {
            db = new SchoolDbContext();
        }

        // GET: api/Picture
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK,db.Pictures.ToList());
        }

        // GET: api/Picture/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Picture
        public HttpResponseMessage Post([FromBody]Picture value)
        {
            if (!ModelState.IsValid)
            {
                string msg = Utilities.GetErrors(ModelState);
                return Request.CreateResponse(HttpStatusCode.BadRequest, msg);
            }
            db.Pictures .Add(value);
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // PUT: api/Picture/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Picture/5
        public HttpResponseMessage Delete(int id)
        {
            var picture = db.Pictures.FirstOrDefault(x => x.Id == id);
            if (picture == null)
            { 
                return Request.CreateResponse(HttpStatusCode.NotFound );
            }
            db.Pictures .Remove(picture);
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK);
        
        }
    }
}
