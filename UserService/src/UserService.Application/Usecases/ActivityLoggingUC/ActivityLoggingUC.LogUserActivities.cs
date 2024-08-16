namespace UserService.Application.Usecases.ActivityLoggingUC;
public partial class ActivityLoggingUC
{
  public async Task<bool> LogUserActivities()
  {
    await Task.Delay(1000);
    throw new NotImplementedException();
  }
}
