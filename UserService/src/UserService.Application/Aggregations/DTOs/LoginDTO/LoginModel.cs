using System.ComponentModel.DataAnnotations;

namespace UserService.Application.Aggregations.DTOs.LoginDTO;
public class LoginModel
{
  [Required]
  [EmailAddress]
  [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
  public string Email { get; set; } = string.Empty;

  [Required]
  [DataType(DataType.Password)]
  [StringLength(32, ErrorMessage = "Must be between 8 and 32 characters", MinimumLength = 8)]
  public string Password { get; set; } = string.Empty;
}
