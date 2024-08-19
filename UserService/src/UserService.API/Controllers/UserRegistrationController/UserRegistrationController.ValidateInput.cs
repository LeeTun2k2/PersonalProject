using Microsoft.AspNetCore.Mvc;
using UserService.Application.Aggregations.DTOs.Common;
using UserService.Application.Aggregations.DTOs.UserDTO;

namespace UserService.API.Controllers.UserRegistrationController;

public partial class UserRegistrationController
{
  [HttpPost(nameof(ValidateInput))]
  public async Task<IActionResult> ValidateInput([FromBody] UserRegistrationModel input)
  {
    var result = await userRegistrationUC.ValidateInput(input);
    try
    {
      var response = new ApiResponse<bool>();
      return Ok(response);
    }
    catch (Exception ex)
    {
      var response = new ApiResponse<bool>
      {
        Status = false,
        Message = ex.Message
      };
      return BadRequest(response);
    }
  }
}
