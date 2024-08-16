using UserService.Application.Interfaces.IUsecases;

namespace UserService.API.Controllers.UserAuthenticationController;

public partial class UserAuthenticationController(
  IUserAuthenticationUC userAuthenticationUC,
  ISessionManagementUC sessionManagementUC
  ) : BaseController
{

}
