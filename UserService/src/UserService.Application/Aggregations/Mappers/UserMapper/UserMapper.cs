using UserService.Application.Aggregations.DTOs.UserDTO;
using UserService.Core.Entities;

namespace UserService.Application.Aggregations.Mappers.UserMapper;
public class UserMapper
{
  public static UserViewModel ToUserViewModel(User model)
  {
    var result = new UserViewModel
    {
      Id = model.Id,
      Email = model.Email ?? string.Empty,
      EmailConfirmed = model.EmailConfirmed,
      Name = model.Name,
      PhoneNumber = model.PhoneNumber ?? string.Empty,
      PhoneNumberConfirmed = model.PhoneNumberConfirmed,
      TwoFactorEnabled = model.TwoFactorEnabled,
      LockoutEnable = model.LockoutEnabled,
      LockoutEnd = model.LockoutEnd,
      AccessFailedCount = model.AccessFailedCount,
    };
    return result; 
  }
}
