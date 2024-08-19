using Microsoft.AspNetCore.Mvc;
using UserService.Application.Aggregations.DTOs.Common;
using UserService.Application.Aggregations.DTOs.LoginDTO;
using UserService.Application.Aggregations.ValueObjects.Common;

namespace UserService.API.Controllers.UserAuthenticationController;

public partial class UserAuthenticationController
{
  [HttpPost("[action]")]
  public async Task<IActionResult> Login([FromBody] LoginModel input)
  {
    var response = new ApiResponse<LoginResult>();
    try
    {
      // Login with email and password
      var userVM = await userAuthenticationUC.Login(input);

      if (userVM == null)
      {
        response.Status = false;
        response.Message = ApiResponseVO.DefaultMessage_Failure;
        return BadRequest(response);
      }

      // If user is enable MFA, send code to they email
      if (userVM.TwoFactorEnabled)
      {
        response.Status = false;
        await userAuthenticationUC.MFA(userVM);
        response.Message = "MFA code sent. Please check your email.";
        return UnprocessableEntity(response);
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
