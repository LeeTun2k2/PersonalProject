using System.Text.Json;
using Microsoft.Extensions.Caching.Distributed;

namespace UserService.Infrastructure.InfrastructureServices.RedisServices;
public partial class RedisService
{
  public async Task<T?> GetAsync<T>(string key)
  {
    var jsonData = await cache.GetStringAsync(key);
    if (jsonData == null)
    {
      return default;
    }

    return JsonSerializer.Deserialize<T>(jsonData);
  }
}
