using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using UserService.Application.Aggregations.DTOs.Common;
using UserService.Application.Aggregations.ValueObjects.Common;

namespace UserService.API.Controllers.AccountVerificationController;

public partial class AccountVerificationController
{
  [HttpGet("[action]")]
  public async Task<IActionResult> VerifyEmailAddress([EmailAddress][Required] string email, [Required] string token)
  {
    var response = new ApiResponse<bool>();
    try
    {
      // Verify email and token
      var verified = await userAuthenticationUC.VerifyEmailAddress(email, token);

      if (!verified)
      {
        response.Status = false;
        response.Data = false;
        response.Message = ApiResponseVO.DefaultMessage_Failure;
        return BadRequest(response);
      }

      // Returns
      response.Data = true;
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
