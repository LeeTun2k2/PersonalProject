namespace UserService.Application.Interfaces.IUsecases;
public interface IAccountVerificationUC
{
  Task<bool> VerifyEmailAddress(string email, string token);
}
