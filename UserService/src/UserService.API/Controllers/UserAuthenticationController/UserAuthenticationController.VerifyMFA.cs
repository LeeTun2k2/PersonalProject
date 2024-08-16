using Microsoft.AspNetCore.Mvc;
using UserService.Application.Aggregations.DTOs.Common;
using UserService.Application.Aggregations.DTOs.LoginDTO;
using UserService.Application.Aggregations.ValueObjects.Common;

namespace UserService.API.Controllers.UserAuthenticationController;

public partial class UserAuthenticationController
{
  [HttpPost("[action]")]
  public async Task<IActionResult> VerifyMFA([FromBody] VerifyMFAModel input)
  {
    var response = new ApiResponse<LoginResult>();
    try
    {
      // Login with email and password
      var userVM = await userAuthenticationUC.MFA(input.email, input.code);

      if (userVM == null)
      {
        return Forbid();
      }

      // Generate token
      var result = sessionManagementUC.SessionRenewal(userVM);
      if (result == null)
      {
        response.Status = false;
      }

      // Returns
      response.Data = result;
      return Ok(response);
    }
    catch (Exception ex)
    {
      response.Status = false;
      response.Message = ex.Message;
      return BadRequest(response);
    }
  }
}
