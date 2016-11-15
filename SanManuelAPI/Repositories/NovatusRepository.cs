using SanManuelAPI.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SanManuelMobileAPI.Models;
using SanManuelMobile.Core.Models;

namespace SanManuelAPI.Repositories
{
    public class NovatusRepository : INovatusRepository
    {
        NovatusDataContext context = new NovatusDataContext();


        IEnumerable<NovatusData> INovatusRepository.GetNovatusDataByUser(string userEmail)
        {
            var c = (from r in context.Novatus where r.StepOwnerEmail == userEmail && r.Status==0 select r).ToList();

            return c;

        }

        bool INovatusRepository.UpdateStatus(int novatusId, int status)
        {
            bool execStatus = false;
            try
            {
                
                NovatusData novatus = context.Novatus.Find(novatusId);
                novatus.Status = status;
                novatus.LastUpdated = DateTime.Now;
                context.Entry(novatus).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                execStatus = true;
            }
            catch (Exception ex)
            {

                //
                Console.WriteLine(ex);
            }

            return execStatus;

        }
    }
}