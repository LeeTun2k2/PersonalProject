namespace UserService.Application.Usecases.UserNotificationsUC;
public partial class UserNotificationsUC
{
  public async Task<bool> SendSMSNotifications()
  {
    await Task.Delay(1000);
    throw new NotImplementedException();
  }
}
