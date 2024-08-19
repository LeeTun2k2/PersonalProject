using UserService.Core.Entities;

namespace UserService.Infrastructure.Repositories.UserRepository;

public partial class UserRepository
{
  public async Task<User?> LoginAsync(string email, string password)
  {
    // Validate input
    if (string.IsNullOrWhiteSpace(email) || string.IsNullOrEmpty(password))
      return null;

    // Find user
    var user = await userManager.FindByEmailAsync(email);

    if (user == null)
    {
      return null;
    }

    // Login
    var result = await signInManager.CheckPasswordSignInAsync(user, password, true);

    if (result == null || !result.Succeeded)
    {
      return null;
    }

    // Return
    return user;
  }
}
