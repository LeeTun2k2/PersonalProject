using UserService.Application.Aggregations.DTOs.UserDTO;
using UserService.Application.Aggregations.Mappers.UserMapper;

namespace UserService.Application.Usecases.UserRegistrationUC;
public partial class UserRegistrationUC
{
  public async Task<bool> Register(UserRegistrationModel input)
  {
    // Map to entity
    var user = UserRegistrationModelMapper.ToUser(input);
    string password = input.Password;

    var result = await userRepository.RegisterAsync(user, password);

    return result;
  }
}
