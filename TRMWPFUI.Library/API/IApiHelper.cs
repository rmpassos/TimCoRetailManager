using System.Threading.Tasks;
using TRMWPFUI.Library.Models;

namespace TRMWPFUI.Library.Helpers.API
{
    public interface IApiHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);

        Task GetLoggedInUserInfo(string token);
    }
}