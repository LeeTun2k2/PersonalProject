using UserService.Application.Aggregations.DTOs.UserDTO;

namespace UserService.Application.Aggregations.DTOs.LoginDTO;
public class LoginResult
{
  public string AccessToken { get; set; } = string.Empty;
  public string RefreshToken { get; set; } = string.Empty;
  public DateTime ExpiryDate { get; set; }
  public UserViewModel? User { get; set; }
}
