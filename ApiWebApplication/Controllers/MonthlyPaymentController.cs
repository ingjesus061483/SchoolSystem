using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;
using ApiWebApplication.DataAccess;
using ApiWebApplication.DTO;

namespace ApiWebApplication.Controllers
{
    public class MonthlyPaymentController : ApiController
    {
        SchoolDbContext DbContext=new SchoolDbContext();
     /*   IQueryable<MonthlyPaymentDTO> MonthlyPaymentDTOs
        {
            get 
            {
                return DbContext.MonthlyPayments.Include("Tuitions").Select(x => new MonthlyPaymentDTO
                {
                   Id=x.Id,
                   Code=x.Code,
                   Detail   = x.Detail,
                   Since = x.Since,
                   Untill   =x.Untill,
                   IsConfirmed=x.IsConfirmed,
                   Value=x.Value,
                   TuitionId=x.TuitionId,
                   Tuition=x.Tuition
                });
            }
        }*/

        // GET: api/Default
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK);//,MonthlyPaymentDTOs);
        }

        // GET: api/Default/5
        public HttpResponseMessage Get(int id)
        {
            /*  var monthy =  MonthlyPaymentDTOs.Where(x => x.Id == id).FirstOrDefault();
              if (monthy == null)
              {
                  return Request.CreateResponse(HttpStatusCode.NotFound );
              }*/
            return Request.CreateResponse(HttpStatusCode.OK);//, monthy);
        }

        // POST: api/Default
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Default/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Default/5
        public void Delete(int id)
        {
        }
    }
}
