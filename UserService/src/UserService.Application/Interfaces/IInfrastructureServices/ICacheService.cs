﻿namespace UserService.Application.Interfaces.IInfrastructureServices;
public interface ICacheService
{
  Task SetAsync<T>(string key, T value, TimeSpan? expiry = null);
  Task<T?> GetAsync<T>(string key);
  Task RemoveAsync(string key);
}
