namespace UserService.Application.Usecases.DataExportUC;
public partial class DataExportUC
{
  public async Task<bool> ExportUserData()
  {
    await Task.Delay(1000);
    throw new NotImplementedException();
  }
}
