using UserService.Core.Models.EmailModels;

namespace UserService.Application.Usecases.UserRegistrationUC;
public partial class UserRegistrationUC
{
  public async Task<bool> SendConfirmationEmail(string email)
  {
    // Get user by email
    var user = await userRepository.GetByEmailAsync(email);

    if (user == null)
    {
      // Fail to send confirmation email
      return false;
    }

    // Build email information
    var emailInfo = new DefaultEmailModel
    {
      To = email,
      Name = user.Name,
      Subject = "Hello",
      Body = "Hello"
    };

    // Send email
    var result = await mailService.Send(emailInfo);

    return result;
  }
}
