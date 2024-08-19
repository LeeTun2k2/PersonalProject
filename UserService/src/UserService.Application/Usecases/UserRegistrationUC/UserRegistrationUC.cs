using Microsoft.Extensions.Options;
using UserService.Application.Interfaces.IInfrastructureServices;
using UserService.Application.Interfaces.IRepositories;
using UserService.Application.Interfaces.IUsecases;
using UserService.Core.Interfaces;
using UserService.Core.Models.DomainModels;

namespace UserService.Application.Usecases.UserRegistrationUC;
public partial class UserRegistrationUC(
  IUserRepository userRepository,
  IMailService mailService,
  IEmailTemplates emailTemplates,
  IRandomService randomService,
  ICacheService cacheService,
  IOptions<DomainSettingsModel> settings
  ) : IUserRegistrationUC
{
  private readonly DomainSettingsModel _settings = settings.Value;
}
