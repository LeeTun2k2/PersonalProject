using UserService.Core.Models.EmailModels;

namespace UserService.Core.Interfaces;
public interface IEmailTemplates
{
  EmailContent BuildMFAContent(string code);
}
