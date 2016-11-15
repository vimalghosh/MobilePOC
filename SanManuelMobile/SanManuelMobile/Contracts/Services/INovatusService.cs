using SanManuelMobile.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanManuelMobile.Core.Contracts.Services
{
    public interface INovatusService
    {
        Task<List<NovatusData>> GetNovatusList(string userName);
    }
}
