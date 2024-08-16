using UserService.Application.Aggregations.DTOs.UserDTO;
using UserService.Application.Aggregations.Mappers.UserMapper;
using UserService.Core.Models.EmailModels;

namespace UserService.Application.Usecases.UserAuthenticationUC;
public partial class UserAuthenticationUC
{
  private readonly string _prefixMFA = "MFA"; 

  /// <summary>
  /// Generate code, store in cache and send to user email
  /// </summary>
  /// <param name="userVM"></param>
  /// <returns></returns>
  public async Task MFA(UserViewModel userVM)
  {
    // Generate MFA Code
    var code = randomService.Random(100000, 999999).ToString();

    // Save to cache
    string key = BuildMFAKey(userVM.Id);
    await cacheService.SetAsync(key, code, TimeSpan.FromHours(4));

    // Send code to useremail
    var mailContent = emailTemplates.BuildMFAContent(code);
    var mailModel = new DefaultEmailModel
    {
      To = userVM.Email,
      Name = userVM.Name,
      Subject = mailContent.Subject,
      Body = mailContent.Body,
    };
    await mailService.Send(mailModel);
  }

  /// <summary>
  /// Verify Login MFA with email and code.
  /// </summary>
  /// <param name="email"></param>
  /// <param name="code"></param>
  /// <returns></returns>
  /// <exception cref="Exception"></exception>
  public async Task<UserViewModel?> MFA(string email, string code)
  {
    // Get user by email
    var user = await userRepository.GetByEmailAsync(email);
    if (user == null) {
      return null;
    }

    // Verify MFA Code
    string key = BuildMFAKey(user.Id);
    var storedCode = await cacheService.GetAsync<string>(key);

    if (string.IsNullOrWhiteSpace(code) || code.Length != 6)
    {
      throw new Exception("Incorrect MFA code format.");
    }

    // Compare code
    var result = storedCode == code;

    if (!result)
    {
      return null;
    }

    // Remove code if success
    await cacheService.RemoveAsync(key);
    
    // Map to user view model
    var userVM = UserMapper.ToUserViewModel(user);

    // Returns
    return userVM;
  }

  private string BuildMFAKey(Guid userId)
  {
    string key = $"{_prefixMFA}_{userId}";
    return key;
  }
}
