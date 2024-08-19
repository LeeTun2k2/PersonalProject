using Microsoft.AspNetCore.Mvc;
using UserService.Application.Aggregations.DTOs.Common;
using UserService.Application.Aggregations.DTOs.UserDTO;
using UserService.Application.Aggregations.ValueObjects.Common;

namespace UserService.API.Controllers.UserRegistrationController;

public partial class UserRegistrationController
{
  [HttpPost("[action]")]
  public async Task<IActionResult> Register([FromBody] UserRegistrationModel input)
  {
    var response = new ApiResponse<bool>();
    try
    {
      var validations = await userRegistrationUC.ValidateInput(input);

      if (!validations)
      {
        response.Status = false;
        response.Message = ApiResponseVO.DefaultMessage_Failure;
        return BadRequest(response);
      }

      var result = await userRegistrationUC.Register(input);
      if (!result)
      {
        response.Status = false;
        response.Message = ApiResponseVO.DefaultMessage_Failure;
        return BadRequest(response);
      }
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
