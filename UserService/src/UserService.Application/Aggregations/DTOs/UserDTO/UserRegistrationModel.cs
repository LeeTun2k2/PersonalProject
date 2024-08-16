using System.ComponentModel.DataAnnotations;

namespace UserService.Application.Aggregations.DTOs.UserDTO;
public class UserRegistrationModel
{
  [Required(ErrorMessage = "Email is required")]
  [EmailAddress(ErrorMessage = "Invalid email address")]
  [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
  public string Email { get; set; } = string.Empty;

  [Required(ErrorMessage = "Username is required")]
  [StringLength(32, ErrorMessage = "Must be between 8 and 32 characters", MinimumLength = 8)]
  public string UserName { get; set; } = string.Empty;

  [Required(ErrorMessage = "Password is required")]
  [StringLength(32, ErrorMessage = "Must be between 8 and 32 characters", MinimumLength = 8)]
  [DataType(DataType.Password)]
  public string Password { get; set; } = string.Empty;

  [Required(ErrorMessage = "Confirm Password is required")]
  [StringLength(32, ErrorMessage = "Must be between 8 and 32 characters", MinimumLength = 8)]
  [DataType(DataType.Password)]
  [Compare("Password", ErrorMessage = "Passwords do not match")]
  public string ConfirmPassword { get; set; } = string.Empty;

  [Required(ErrorMessage = "Name is required")]
  [StringLength(32, ErrorMessage = "Must be between 8 and 32 characters", MinimumLength = 8)]
  public string Name { get; set; } = string.Empty;

  [Required(ErrorMessage = "Phone Number is required")]
  [Phone(ErrorMessage = "Invalid phone number")]
  public string PhoneNumber { get; set; } = string.Empty;
}
