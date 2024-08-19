using Microsoft.Extensions.Caching.Distributed;
using UserService.Application.Interfaces.IInfrastructureServices;

namespace UserService.Infrastructure.InfrastructureServices.RedisServices;
public partial class RedisService(IDistributedCache cache) : ICacheService
{

}
