using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using StackExchange.Redis;
using UserService.Application.Interfaces.Common;
using UserService.Application.Interfaces.IInfrastructureServices;
using UserService.Application.Interfaces.IRepositories;
using UserService.Infrastructure.Data;
using UserService.Infrastructure.InfrastructureServices.MailServices;
using UserService.Infrastructure.InfrastructureServices.RandomServices;
using UserService.Infrastructure.InfrastructureServices.RedisServices;
using UserService.Infrastructure.InfrastructureServices.TokenServices;
using UserService.Infrastructure.Repositories;
using UserService.Infrastructure.Repositories.UserRepository;

namespace UserService.Infrastructure;
public static class InfrastructureExtensions
{
  public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfigurationManager config)
  {
    string? psqlConnection = config.GetConnectionString("DefaultConnection");
    string? redisConnection = config.GetConnectionString("RedisConnection");

    if (
      string.IsNullOrWhiteSpace(psqlConnection) ||
      string.IsNullOrWhiteSpace(redisConnection)) 
    {
      throw new Exception("Fail to initial connection string."); 
    }

    services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(psqlConnection));
    services.AddStackExchangeRedisCache(options => { options.Configuration = redisConnection; });
    services.AddScoped<IMailService, MailService>();
    services.AddTransient<ITokenService, TokenService>();
    services.AddScoped<ICacheService, RedisService>();
    services.AddSingleton<IRandomService, RandomService>();
    services.AddSingleton<IDictionary<Guid, string>>(new Dictionary<Guid, string>());
    services.AddSingleton(TimeProvider.System);
    services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
    services.AddScoped<IUserRepository, UserRepository>();

    return services;
  }
}
