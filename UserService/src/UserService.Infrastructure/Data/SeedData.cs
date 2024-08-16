using UserService.Infrastructure.Data;

namespace Clean.Architecture.Infrastructure.Data;

public static class SeedData
{

  public static async Task InitializeAsync(ApplicationDbContext dbContext)
  {
    dbContext.Database.EnsureCreated();
    await Task.Delay(0);
  }
}
