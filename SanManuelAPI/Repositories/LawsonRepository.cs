using SanManuelAPI.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SanManuelMobileAPI.Models;

namespace SanManuelAPI.Repositories
{
    public class LawsonRepository : ILawsonRepository
    {
        LawsonDataContext context = new LawsonDataContext();


        IEnumerable<LawsonData> ILawsonRepository.GetLawsonDataByUser(string userEmail)
        {
            var c = (from r in context.Lawson where r.ApproverEmail == userEmail && r.Status==0 select r).ToList();

            return c;

        }

        bool ILawsonRepository.UpdateStatus(int LawsonId, int status)
        {
            bool execStatus = false;
            try
            {
                
                LawsonData lawson = context.Lawson.Find(LawsonId);
                lawson.Status = status;
                lawson.LastUpdatedDate = DateTime.Now;
                context.Entry(lawson).State = System.Data.Entity.EntityState.Modified;
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