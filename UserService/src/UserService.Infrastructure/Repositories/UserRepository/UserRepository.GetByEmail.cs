using Microsoft.EntityFrameworkCore;
using UserService.Core.Entities;
using UserService.Core.Models.UserModels;

namespace UserService.Infrastructure.Repositories.UserRepository;

public partial class UserRepository
{
  public async Task<User?> GetByEmailAsync(string email)
  {
    // Validate input
    if (string.IsNullOrWhiteSpace(email))
      return null;

    var user = await userManager.FindByEmailAsync(email);

    // Return
    return user;
  }
}
