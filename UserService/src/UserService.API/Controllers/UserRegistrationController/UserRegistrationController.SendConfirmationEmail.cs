using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using UserService.Application.Aggregations.DTOs.Common;
using UserService.Application.Aggregations.ValueObjects.Common;

namespace UserService.API.Controllers.UserRegistrationController;

public partial class UserRegistrationController
{
  [HttpGet("[action]")]
  public async Task<IActionResult> SendConfirmationEmail([Required][EmailAddress] string email)
  {
    var response = new ApiResponse<bool>();
    try
    {
      var result = await userRegistrationUC.SendConfirmationEmail(email);

      if (!result)
      {
        response.Status = false;
        response.Message = ApiResponseVO.DefaultMessage_Failure;
        return BadRequest(response);
      }

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
