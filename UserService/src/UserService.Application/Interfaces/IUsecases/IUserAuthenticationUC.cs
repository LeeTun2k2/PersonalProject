using UserService.Application.Aggregations.DTOs.LoginDTO;
using UserService.Application.Aggregations.DTOs.UserDTO;

namespace UserService.Application.Interfaces.IUsecases;
public interface IUserAuthenticationUC
{
  Task<UserViewModel?> Login(LoginModel model);
  Task MFA(UserViewModel userVM);
  Task<UserViewModel?> MFA(string email, string code);
}
