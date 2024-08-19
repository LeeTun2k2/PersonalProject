using MailKit.Net.Smtp;
using Microsoft.Extensions.Options;
using UserService.Application.Interfaces.IInfrastructureServices;
using UserService.Core.Models.EmailModels;

namespace UserService.Infrastructure.InfrastructureServices.MailServices;
public partial class MailService(IOptions<MailSettingsModel> settings) : IMailService
{
  private readonly SmtpClient _smtpClient = new();
  private readonly MailSettingsModel _settings = settings.Value;

  private async Task ConnectAsync()
  {
    await _smtpClient.ConnectAsync(_settings.Host, _settings.Port, false);
    await _smtpClient.AuthenticateAsync(_settings.UserName, _settings.Password);
  }

  private async Task DisconnectAsync()
  {
    await _smtpClient.DisconnectAsync(true);
  }
}
