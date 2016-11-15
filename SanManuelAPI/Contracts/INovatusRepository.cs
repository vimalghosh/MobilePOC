using SanManuelMobile.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanManuelAPI.Contracts
{
    public interface INovatusRepository
    {
        IEnumerable<NovatusData> GetNovatusDataByUser(string userEmail);

        bool UpdateStatus(int NovatusId, int status);
    }
}
