namespace UserService.Application.Usecases.AccountVerificationUC;
public partial class AccountVerificationUC
{
  private readonly string _verifiedEmailPrefix = "VERIFIED_EMAIL_";
  public async Task<bool> VerifyEmailAddress(string email, string token)
  {
    // Verify email & token
    if (
      string.IsNullOrWhiteSpace(email) || 
      string.IsNullOrWhiteSpace(token) ||
      token.Length != 32) 
    {
      throw new ArgumentException("Invalid email or token.");
    }

    // Find in cache
    string key = BuildVerifiedEmailKey(email);
    var cached = await cacheService.GetAsync<string>(key) ?? throw new KeyNotFoundException($"{email} not found");

    // Compare cached value and token
    if (token != cached)
    {
      return false;
    }

    // Correct token, clear cached
    await cacheService.RemoveAsync(key);

    // Returns
    return true;
  }

  private string BuildVerifiedEmailKey(string email)
  {
    string key = _verifiedEmailPrefix + email;
    return key;
  }
}
