using Microsoft.Extensions.DependencyInjection;
using UserService.Application.Interfaces.IUsecases;
using UserService.Application.Usecases.SessionManagementUC;
using UserService.Application.Usecases.UserAuthenticationUC;
using UserService.Application.Usecases.UserRegistrationUC;

namespace UserService.Application;
public static class ApplicationExtensions
{
  public static IServiceCollection AddApplicationServices(this IServiceCollection services)
  {
    services.AddScoped<IUserRegistrationUC, UserRegistrationUC>();
    services.AddScoped<IUserAuthenticationUC, UserAuthenticationUC>();
    services.AddScoped<ISessionManagementUC, SessionManagementUC>();
    return services;
  }
}
