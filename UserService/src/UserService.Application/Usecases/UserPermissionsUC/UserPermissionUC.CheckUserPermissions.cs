namespace UserService.Application.Usecases.UserPermissionUC;
public partial class UserPermissionUC
{
  public async Task<bool> CheckUserPermission()
  {
    await Task.Delay(1000);
    throw new NotImplementedException();
  }
}
