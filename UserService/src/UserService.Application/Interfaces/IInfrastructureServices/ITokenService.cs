using UserService.Core.Entities;

namespace UserService.Application.Interfaces.IInfrastructureServices;
public interface ITokenService
{
  string GenerateAccessToken(User user);
  string GenerateRefreshToken(User user);
  bool ValidateRefreshToken(User user, string refreshToken);
}
