namespace UserService.Application.Usecases.AccessControlUC;
public partial class AccessControlUC
{
  /// <summary>
  /// Attribute-Based Access Control
  /// </summary>
  /// <returns></returns>
  /// <exception cref="NotImplementedException"></exception>
  public async Task<bool> ABAC()
  {
    await Task.Delay(1000);
    throw new NotImplementedException();
  }
}
