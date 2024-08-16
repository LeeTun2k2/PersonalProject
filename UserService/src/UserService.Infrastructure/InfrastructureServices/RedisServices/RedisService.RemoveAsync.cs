namespace UserService.Infrastructure.InfrastructureServices.RedisServices;
public partial class RedisService
{
  public async Task RemoveAsync(string key)
  {
    await cache.RemoveAsync(key);
  }
}
