using SanManuelAPI.Contracts;
using SanManuelMobile.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SanManuelAPI.Controllers
{
    public class NovatusController : ApiController
    {
        // GET: api/Novatus

        INovatusRepository repository;

        public NovatusController(INovatusRepository repo)
        {
            repository = repo;
        }
        public IEnumerable<NovatusData> GetNovatusDataByUserEmail(string userEmail)
        {
            return repository.GetNovatusDataByUser(userEmail);
        }

        // GET: api/Novatus/5
        public NovatusData Get(int id)
        {
            return new NovatusData
            {
                NovatusId = 123,
                StepName = "Director Approval",
                LastUpdated = DateTime.Now,
                StepOwnerEmail = "mbackover@sanmanuel.com",
                StepOwnerName ="Marty Backover",
                Status=0,
                CompletedOn= DateTime.Now,
                WorkFlowName ="HighDollar Approval",
                WorkFlowOwner= "Jennifer Lopez",
                Remarks= "Just for testing"
            };
        }

        // POST: api/Novatus
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Novatus/5
        public void Put(int id, int status)
        {
            repository.UpdateStatus(id, status);
        }

        // DELETE: api/Novatus/5
        public void Delete(int id)
        {
        }
    }
}
