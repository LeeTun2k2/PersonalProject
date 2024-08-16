namespace UserService.Application.Aggregations.DTOs.UserDTO;
public class UserViewModel
{
  public Guid Id { get; set; }
  public string Email { get; set; } = string.Empty;
  public string Name { get; set; } = string.Empty;
  public string PhoneNumber { get; set; } = string.Empty;
  public bool EmailConfirmed { get; set; }
  public bool PhoneNumberConfirmed { get; set; }
  public bool TwoFactorEnabled { get; set; }
  public bool LockoutEnable { get; set; }
  public DateTimeOffset? LockoutEnd {  get; set; }
  public int AccessFailedCount { get; set; }
}
