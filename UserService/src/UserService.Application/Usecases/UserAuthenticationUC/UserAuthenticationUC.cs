using UserService.Application.Interfaces.IInfrastructureServices;
using UserService.Application.Interfaces.IRepositories;
using UserService.Application.Interfaces.IUsecases;
using UserService.Core.Interfaces;

namespace UserService.Application.Usecases.UserAuthenticationUC;
public partial class UserAuthenticationUC(
  IUserRepository userRepository,
  ICacheService cacheService,
  IRandomService randomService,
  IMailService mailService,
  IEmailTemplates emailTemplates
  ) : IUserAuthenticationUC
{

}
