namespace UserService.Application.Usecases.AuditTrailsUC;
public partial class AuditTrailsUC
{
  public async Task<bool> TrackChangesToUserData()
  {
    await Task.Delay(1000);
    throw new NotImplementedException();
  }
}
