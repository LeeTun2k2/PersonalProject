using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UserService.API.Controllers.UserAuthenticationController;

public partial class UserAuthenticationController
{
  [HttpPost("[action]")]
  [Authorize]
  public IActionResult VerifySSO()
  {
    return NoContent();
  }
}
