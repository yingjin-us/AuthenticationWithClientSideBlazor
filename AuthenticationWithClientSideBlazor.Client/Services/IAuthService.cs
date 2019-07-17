using AuthenticationWithClientSideBlazor.Shared;
using System.Threading.Tasks;

namespace AuthenticationWithClientSideBlazor.Client.Services
{
    public interface IAuthService
    {
        Task<RegisterResult> Register(RegisterModel registerModel);
        Task<LoginResult> Login(LoginModel loginModel);
        Task Logout();
    }
}