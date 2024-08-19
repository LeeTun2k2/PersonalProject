using UserService.Core.Models.EmailModels;

namespace UserService.Application.Interfaces.IInfrastructureServices;
public interface IMailService
{
  Task<bool> Send(DefaultEmailModel emailModel);
}
