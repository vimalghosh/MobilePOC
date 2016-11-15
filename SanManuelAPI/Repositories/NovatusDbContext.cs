using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SanManuelMobileAPI.Models;
using SanManuelMobile.Core.Models;

namespace SanManuelAPI.Repositories
{
   
    
        public class NovatusDataContext : DbContext

        {

            public NovatusDataContext() : base("name=local")

            {



            }

            public IDbSet<NovatusData> Novatus { get; set; }



        }

    

}