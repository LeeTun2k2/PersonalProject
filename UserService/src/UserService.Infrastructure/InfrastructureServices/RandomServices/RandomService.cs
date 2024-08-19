using System.Text;
using UserService.Application.Interfaces.IInfrastructureServices;

namespace UserService.Infrastructure.InfrastructureServices.RandomServices;
public class RandomService : IRandomService
{
  private readonly Random _random = new();
  public int Random(int min, int max)
  {
    return _random.Next(min, max);
  }

  public string Random(int length)
  {
    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    var stringBuilder = new StringBuilder(length);

    for (int i = 0; i < length; i++)
    {
      var randomChar = chars[_random.Next(chars.Length)];
      stringBuilder.Append(randomChar);
    }

    return stringBuilder.ToString();
  }
}
