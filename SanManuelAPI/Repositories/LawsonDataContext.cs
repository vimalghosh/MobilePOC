using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SanManuelMobileAPI.Models;
using SanManuelMobile.Core.Models;

namespace SanManuelAPI.Repositories
{
   
    
        public class LawsonDataContext : DbContext

        {

            public LawsonDataContext() : base("name=local")

            {



            }

            public IDbSet<LawsonData> Lawson { get; set; }



        }

   
}