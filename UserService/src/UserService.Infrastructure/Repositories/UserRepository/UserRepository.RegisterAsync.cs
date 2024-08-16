using UserService.Core.Entities;

namespace UserService.Infrastructure.Repositories.UserRepository;

public partial class UserRepository
{
  public async Task<bool> RegisterAsync(User model, string password)
  {
    var result = await userManager.CreateAsync(model, password);

    return result.Succeeded;
  }
}
