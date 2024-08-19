using UserService.Application.Interfaces.IUsecases;

namespace UserService.API.Controllers.AccountVerificationController;

public partial class AccountVerificationController(
  IAccountVerificationUC userAuthenticationUC
  ) : BaseController
{

}
