using UserService.Application.Interfaces.IInfrastructureServices;
using UserService.Application.Interfaces.IUsecases;

namespace UserService.Application.Usecases.AccountVerificationUC;
public partial class AccountVerificationUC(
  ICacheService cacheService
  ) : IAccountVerificationUC
{

}
