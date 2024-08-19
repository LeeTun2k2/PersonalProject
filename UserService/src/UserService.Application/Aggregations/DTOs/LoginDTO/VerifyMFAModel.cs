using System.ComponentModel.DataAnnotations;

namespace UserService.Application.Aggregations.DTOs.LoginDTO;
public class VerifyMFAModel
{
  [Required]
  [EmailAddress]
  [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
  public string email {  get; set; } = string.Empty;

  [Required]
  [StringLength(6, ErrorMessage = "Must be 6 characters", MinimumLength = 6)]
  public string code { get; set; } = string.Empty;
}
