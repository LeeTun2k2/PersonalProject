namespace UserService.Application.Usecases.ApiRateLimitingUC;
public partial class ApiRateLimitingUC
{
  public async Task<bool> LimitApiRequestsPerUser()
  {
    await Task.Delay(1000);
    throw new NotImplementedException();
  }
}
