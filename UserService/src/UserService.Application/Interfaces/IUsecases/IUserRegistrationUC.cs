using UserService.Application.Aggregations.DTOs.UserDTO;

namespace UserService.Application.Interfaces.IUsecases;
public interface IUserRegistrationUC
{
  Task<bool> Register(UserRegistrationModel input);
  Task<bool> ValidateInput(UserRegistrationModel input);
  Task<bool> SendConfirmationEmail(string email);
}
