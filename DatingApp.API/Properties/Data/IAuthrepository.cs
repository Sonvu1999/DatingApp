using System.Threading.Tasks;
using DatingApp.API.Properties.models;

namespace DatingApp.API.Properties.Data
{
    public interface IAuthrepository
    {
         Task<User> Register(User user, string password);
         Task<User> Login(string username, string password);
         Task<bool> UserExists(string username);

    }
}