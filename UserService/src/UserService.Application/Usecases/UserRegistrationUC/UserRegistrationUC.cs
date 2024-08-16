using UserService.Application.Interfaces.IInfrastructureServices;
using UserService.Application.Interfaces.IRepositories;
using UserService.Application.Interfaces.IUsecases;

namespace UserService.Application.Usecases.UserRegistrationUC;
public partial class UserRegistrationUC(
  IUserRepository userRepository,
  IMailService mailService
  ) : IUserRegistrationUC
{

}
