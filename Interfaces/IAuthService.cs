using JwtProject.Models;
using JwtProject.Request_Models;

namespace JwtProject.Interfaces
{
    public interface IAuthService
    {
        User AddUser(User user);
        string Login(LoginRequest loginRequest);
    }
}
