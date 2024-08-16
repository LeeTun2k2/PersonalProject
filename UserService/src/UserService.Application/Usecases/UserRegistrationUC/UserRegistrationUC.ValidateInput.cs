using UserService.Application.Aggregations.DTOs.UserDTO;
using UserService.Application.Aggregations.Mappers.UserMapper;

namespace UserService.Application.Usecases.UserRegistrationUC;
public partial class UserRegistrationUC
{
  public async Task<bool> ValidateInput(UserRegistrationModel input)
  {
    // Map to query model
    var queryModel = UserRegistrationModelMapper.ToUserQueryModel(input);
    queryModel.Name = null; // Ensure not query user name

    // Validate conflict database
    var users = await userRepository.FindAsync(queryModel);
    if (users.Any())
    {
      return false;
    }

    // Return
    return true;
  }
}
