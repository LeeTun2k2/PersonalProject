using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using UserService.Core.Models.EmailModels;

namespace UserService.Application.Usecases.UserRegistrationUC;
public partial class UserRegistrationUC
{
  private readonly string _verifiedEmailPrefix = "VERIFIED_EMAIL_";
  public async Task<bool> SendConfirmationEmail(string email)
  {
    // Get user by email
    var user = await userRepository.GetByEmailAsync(email);

    if (user == null)
    {
      // Fail to send confirmation email
      return false;
    }

    // Generate confirmation link
    string token = randomService.Random(32);

    // Save to cached
    string key = BuildVerifiedEmailKey(email);
    await cacheService.SetAsync(key, token, TimeSpan.FromHours(12));

    // Build confirmation link
    string link = $"{_settings.Api}/AccountVerification/VerifyEmailAddress?email={email}&token={token}";

    // Build email information
    var mailContent = emailTemplates.BuildRegistrationContent(link);
    var mailModel = new DefaultEmailModel
    {
      To = user.Email ?? string.Empty,
      Name = user.Name,
      Subject = mailContent.Subject,
      Body = mailContent.Body,
    };

    // Send email
    var result = await mailService.Send(mailModel);

    return result;
  }
  private string BuildVerifiedEmailKey(string email)
  {
    string key = _verifiedEmailPrefix + email;
    return key;
  }
}
