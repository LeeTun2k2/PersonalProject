using MimeKit;
using UserService.Core.Models.EmailModels;

namespace UserService.Infrastructure.InfrastructureServices.MailServices;
public partial class MailService
{
  public async Task<bool> Send(DefaultEmailModel emailModel)
  {
    var message = new MimeMessage();
    message.From.Add(new MailboxAddress(_settings.DisplayName, _settings.From));
    message.To.Add(new MailboxAddress(emailModel.Name, emailModel.To));
    message.Subject = emailModel.Subject;
    message.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = emailModel.Body };

    try
    {
      await ConnectAsync();
      await _smtpClient.SendAsync(message);
      await DisconnectAsync();
      return true;
    }
    catch
    {
      await DisconnectAsync();
      return false;
    }
  }
}
