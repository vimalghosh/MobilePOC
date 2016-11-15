using SanManuelMobile.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SanManuelMobile.Core.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using SanManuelMobile.Core.Contracts.Services;

namespace SanManuelMobile.Core.Services
{
    public class NovatusService : INovatusService
    {

        private HttpClient client;

        public async Task<List<NovatusData>> GetNovatusList(string userName)
        {
            return await NevatusFakeData();
        }

        private  Task<List<NovatusData>> NevatusFakeData()
        {
            var novList = new List<NovatusData>{
                new NovatusData
            {
                StepName = "OwnerReview",
                WorkFlowOwner = "Hanley William",
                StepOwnerName = "Hanley William",
                StepOwnerEmail = "hanley@sanmanuel.com",
                WorkFlowName = "Simple Review CEO or CFO"
            },
             new NovatusData{
                StepName = "DirectorApproval",
                WorkFlowOwner = "Smith Michael",
                StepOwnerName = "Hanley William",
                StepOwnerEmail = "hanley@sanmanuel.com",
                WorkFlowName = "Some Big Dollar Review"
            },
             new NovatusData
             {
                StepName = "FinalReview",
                WorkFlowOwner = "Hanley William",
                StepOwnerName = "Hanley William",
                StepOwnerEmail = "hanley@sanmanuel.com",
                WorkFlowName = "Big Workflow Project"
             }
            };
            return Task.FromResult(novList);
        }
    }
}
