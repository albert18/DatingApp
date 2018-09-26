using System.Threading.Tasks;
using DatingApp.API.Model;

namespace DatingApp.API.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);

        Task<User> Login(string username, string password);

        Task<bool> Userexists(string username);
    }
}