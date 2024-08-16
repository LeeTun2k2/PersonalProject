using UserService.Application.Aggregations.DTOs.UserDTO;
using UserService.Core.Entities;

namespace UserService.Application.Aggregations.Mappers.UserViewModelMapper;
public class UserViewModelMapper 
{
  public static User ToUser (UserViewModel model)
  {
    var result = new User
    {
      Id = model.Id,
      Email = model.Email ?? string.Empty,
      EmailConfirmed = model.EmailConfirmed,
      Name = model.Name,
      PhoneNumber = model.PhoneNumber ?? string.Empty,
      PhoneNumberConfirmed = model.PhoneNumberConfirmed,
      TwoFactorEnabled = model.TwoFactorEnabled,
    };
    return result; 
  }
}
