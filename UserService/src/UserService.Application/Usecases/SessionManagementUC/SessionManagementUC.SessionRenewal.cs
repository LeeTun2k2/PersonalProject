using UserService.Application.Aggregations.DTOs.LoginDTO;
using UserService.Application.Aggregations.DTOs.UserDTO;
using UserService.Application.Aggregations.Mappers.UserViewModelMapper;
using UserService.Application.Interfaces.IInfrastructureServices;
using UserService.Application.Interfaces.IUsecases;
using UserService.Core.Entities;

namespace UserService.Application.Usecases.SessionManagementUC;
public partial class SessionManagementUC(ITokenService tokenService) : ISessionManagementUC
{
  /// <summary>
  /// Force generate token. Returns access token, refresh token and expiry date
  /// </summary>
  public LoginResult SessionRenewal(UserViewModel userVM)
  {
    // Map user dto to entity
    var user = UserViewModelMapper.ToUser(userVM);

    var tokens = GenerateToken(user, userVM);

    // Returns
    return tokens;
  }

  /// <summary>
  /// Refresh by refresh token. Returns access token, refresh token and expiry date
  /// </summary>
  public LoginResult SessionRenewal(UserViewModel userVM, string refreshToken)
  {
    // Map user dto to entity
    var user = UserViewModelMapper.ToUser(userVM);

    // Validate refresh token
    var isValid = tokenService.ValidateRefreshToken(user, refreshToken);
    if (!isValid)
    {
      throw new UnauthorizedAccessException("Invalid refresh token.");
    }

    // Generate new tokens
    var tokens = GenerateToken(user, userVM);
    return tokens;
  }

  /// <summary>
  /// Generate token
  /// </summary>
  /// <returns></returns>
  private LoginResult GenerateToken(User user, UserViewModel userVM)
  {
    var accessToken = tokenService.GenerateAccessToken(user);
    var refreshToken = tokenService.GenerateRefreshToken(user);
    var expiryDate = DateTime.UtcNow.AddHours(24);

    var result = new LoginResult
    {
      AccessToken = accessToken,
      RefreshToken = refreshToken,
      ExpiryDate = expiryDate,
      User = userVM
    };

    return result;
  }
}
