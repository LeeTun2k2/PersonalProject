using System.ComponentModel.DataAnnotations;

namespace UserService.Core.Models.EmailModels;
public class DefaultEmailModel
{
  [Required]
  public string To { get; set; } = string.Empty;
  
  [Required]
  public string Name { get; set; } = string.Empty;

  [Required]
  public string Subject { get; set; } = string.Empty;

  [Required]
  public string Body { get; set; } = string.Empty;
}
