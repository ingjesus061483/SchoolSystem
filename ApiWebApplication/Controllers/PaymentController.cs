using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiWebApplication.DataAccess;
using ApiWebApplication.Models;

namespace ApiWebApplication.Controllers
{
    public class PaymentController : ApiController
    {
        SchoolDbContext db=new SchoolDbContext();
        [Route("api/Payment/MethodOfPayment")]
        public IQueryable<MethodOfPayment> GetMethodOfPayment()
        {
            return db.MethodOfPayments;
        }

        // GET: api/Payment
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Payment/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Payment
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Payment/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Payment/5
        public void Delete(int id)
        {
        }
    }
}
