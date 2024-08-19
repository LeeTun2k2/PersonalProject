using UserService.Application.Aggregations.DTOs.UserDTO;
using UserService.Core.Entities;
using UserService.Core.Models.UserModels;

namespace UserService.Application.Aggregations.Mappers.UserMapper;
public class UserRegistrationModelMapper
{
  public static UserQueryModel ToUserQueryModel(UserRegistrationModel model)
  {
    var result = new UserQueryModel
    {
      Name = model.Name,
      Email = model.Email,
      PhoneNumber = model.PhoneNumber,
    };
    return result; 
  }

  public static User ToUser(UserRegistrationModel model)
  {
    var result = new User
    {
      Name = model.Name,
      Email = model.Email,
      PhoneNumber = model.PhoneNumber
    };
    return result;
  }
}
