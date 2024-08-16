using UserService.Application.Aggregations.DTOs.LoginDTO;
using UserService.Application.Aggregations.DTOs.UserDTO;

namespace UserService.Application.Interfaces.IUsecases;
public interface ISessionManagementUC
{
  LoginResult SessionRenewal(UserViewModel userVM);
  LoginResult SessionRenewal(UserViewModel userVM, string refreshToken);
}
