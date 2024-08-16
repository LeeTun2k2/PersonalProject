using UserService.Application.Aggregations.DTOs.LoginDTO;
using UserService.Application.Aggregations.DTOs.UserDTO;
using UserService.Application.Aggregations.Mappers.UserMapper;

namespace UserService.Application.Usecases.UserAuthenticationUC;
public partial class UserAuthenticationUC
{
  public async Task<UserViewModel?> Login(LoginModel model)
  {
    // Login to validate email and password
    var user = await userRepository.LoginAsync(model.Email, model.Password);

    if (user == null)
    {
      return null;
    }

    // Map user to DTO
    var userDto = UserMapper.ToUserViewModel(user);

    // Return
    return userDto;
  }
}
