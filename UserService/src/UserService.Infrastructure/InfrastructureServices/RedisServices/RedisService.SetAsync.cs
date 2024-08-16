using System.Text.Json;
using Microsoft.Extensions.Caching.Distributed;

namespace UserService.Infrastructure.InfrastructureServices.RedisServices;
public partial class RedisService
{
  public async Task SetAsync<T>(string key, T value, TimeSpan? expiry = null)
  {
    var options = new DistributedCacheEntryOptions();
    if (expiry.HasValue)
    {
      options.SetAbsoluteExpiration(expiry.Value);
    }

    var jsonData = JsonSerializer.Serialize(value);
    await cache.SetStringAsync(key, jsonData, options);
  }
}
