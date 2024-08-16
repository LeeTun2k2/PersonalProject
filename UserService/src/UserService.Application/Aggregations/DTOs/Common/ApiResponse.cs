using System.ComponentModel.DataAnnotations;
using UserService.Application.Aggregations.ValueObjects.Common;

namespace UserService.Application.Aggregations.DTOs.Common;
public class ApiResponse<T>
{
  [Required]
  public bool Status { get; set; } = true;

  [Required]
  public string Message { get; set; } = ApiResponseVO.DefaultMessage_Success;

  public T? Data { get; set; }

  public List<string>? Error { get; set; }
}
