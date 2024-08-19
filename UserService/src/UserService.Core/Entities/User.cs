using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace UserService.Core.Entities;

public class User : IdentityUser<Guid>
{
  [Required]
  [MinLength(8)]
  public string Name { get; set; } = string.Empty;
}
