using Microsoft.Extensions.Options;
using UserService.Core.Interfaces;
using UserService.Core.Models.EmailModels;

namespace UserService.Core.Templates.EmailTemplates;
public partial class EmailTemplates(IOptions<MailSettingsModel> settings) : IEmailTemplates
{
  private readonly MailSettingsModel _settings = settings.Value;
}
