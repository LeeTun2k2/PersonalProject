using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace UserService.Infrastructure.Data;
public static class ApplicationDbContextFactory
{
  public static void AddApplicationDbContext(this IServiceCollection services, string connectionString)
  {
    services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(connectionString));
  }
}
