using DesktopUI.Models;
using System.Threading.Tasks;

namespace DesktopUI.Helps
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}