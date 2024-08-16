using Microsoft.Extensions.Options;
using UserService.Application.Interfaces.IInfrastructureServices;
using UserService.Core.Models.TokenModels;

namespace UserService.Infrastructure.InfrastructureServices.TokenServices;
public partial class TokenService(IOptions<JwtSettingsModel> jwtSettingsModel) : ITokenService
{
  private readonly JwtSettingsModel _jwtSettingsModel = jwtSettingsModel.Value;
}
