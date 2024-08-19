using UserService.Application.Interfaces.IUsecases;

namespace UserService.API.Controllers.UserRegistrationController;

public partial class UserRegistrationController(
  IUserRegistrationUC userRegistrationUC
  ) : BaseController
{

}
