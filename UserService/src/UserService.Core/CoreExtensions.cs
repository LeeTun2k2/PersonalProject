using Microsoft.Extensions.DependencyInjection;
using UserService.Core.Interfaces;
using UserService.Core.Templates.EmailTemplates;

namespace UserService.Core;
public static class CoreExtensions
{
  public static IServiceCollection AddCoreServices(this IServiceCollection services)
  {
    services.AddSingleton<IEmailTemplates, EmailTemplates>();
    return services;
  }
}
