using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SanManuelMobile.Core.Models;

namespace SanManuelMobile.Core.Contracts.Services
{
    public interface ILoginService
    {
       Task<LoginToken> Login(string userName, string password);
      
    }
}
