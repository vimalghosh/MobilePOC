using SanManuelMobileAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanManuelAPI.Contracts
{
    public interface ILawsonRepository
    {

        IEnumerable<LawsonData> GetLawsonDataByUser (string userEmail);

        bool UpdateStatus(int LawsonId, int status);

    }
}
