using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using UserService.Core.Entities;

namespace UserService.Infrastructure.InfrastructureServices.TokenServices;
public partial class TokenService
{
  public string GenerateRefreshToken(User user)
  {
    var tokenHandler = new JwtSecurityTokenHandler();
    var key = Encoding.ASCII.GetBytes(_jwtSettingsModel.Key);
    var tokenDescriptor = new SecurityTokenDescriptor
    {
      Subject = new ClaimsIdentity([new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())]),
      Expires = DateTime.UtcNow.AddDays(30),
      SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256),
      Issuer = _jwtSettingsModel.Issuer,
      Audience = _jwtSettingsModel.Audience
    };
    var token = tokenHandler.CreateToken(tokenDescriptor);
    return tokenHandler.WriteToken(token);
  }
}
