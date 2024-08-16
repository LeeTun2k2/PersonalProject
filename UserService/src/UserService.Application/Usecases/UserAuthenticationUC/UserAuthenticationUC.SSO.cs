using UserService.Application.Aggregations.DTOs.LoginDTO;

namespace UserService.Application.Usecases.UserAuthenticationUC;
public partial class UserAuthenticationUC
{
  public async Task<bool> SSO()
  {
    return await Task.FromResult(true);
  }
}
