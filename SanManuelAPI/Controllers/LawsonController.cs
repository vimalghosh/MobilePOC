using SanManuelAPI.Contracts;
using SanManuelMobileAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SanManuelAPI.Controllers
{
    public class LawsonController : ApiController
    {
        ILawsonRepository repository;
        public LawsonController(ILawsonRepository repo)
        {
            repository = repo;
        }
        
        // GET: api/Lawson
        public IEnumerable<LawsonData> GetLawsonDataByUserId( string userEmail)
        {
            return repository.GetLawsonDataByUser(userEmail);
        }

        // GET: api/Lawson/5
        public LawsonData Get(int id)
        {
            return new LawsonData
            {
                LawsonId = 1234,
                Approver = "Marty Backover",
                ApproverEmail = "mbackover@sanmanuel.com",
                Requester = "Jody Fox",
                RequesterEmail = "jfox@sanmanuel.com",
                RequestedDate = DateTime.Now,
                RequestNo = 4567,
                RequestDescription = "Office Supplies",
                OrderNo = 2345,
                EstimatedAmount = 3000,
                LastUpdatedDate = DateTime.Now,
                VendorId = 1234,
                Status = 0,
                VendorName = "Staples"
            };
        }

        // POST: api/Lawson
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Lawson/5
        public HttpResponseMessage Put(int id,int updatedStatus)
        {
            var status=repository.UpdateStatus(id, updatedStatus);
            if (status==true)
            {
                return(Request.CreateResponse(HttpStatusCode.OK));
            }
            else
            {
                return Request.CreateResponse<string>(HttpStatusCode.NotFound, "id not Found");
               
            }
        }

        // DELETE: api/Lawson/5
        public void Delete(int id)
        {
        }
    }
}
