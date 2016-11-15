using System.Threading.Tasks;
using SanManuelMobile.Core.Models;

namespace SanManuelMobile.Core.Contracts.Services
{
    public interface IUserDataService
    {
        Task<User> SearchUser(string userName);

        Task<User> Login(string userName, string password);

        User GetActiveUser();
    }
}