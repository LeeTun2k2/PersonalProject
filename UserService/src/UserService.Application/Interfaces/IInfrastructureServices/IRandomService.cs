namespace UserService.Application.Interfaces.IInfrastructureServices;
public interface IRandomService
{
  int Random(int min, int max);
  string Random(int length);
}
