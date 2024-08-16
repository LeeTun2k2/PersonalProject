using UserService.Application.Interfaces.Common;
using UserService.Core.Entities;
using UserService.Core.Models.UserModels;

namespace UserService.Application.Interfaces.IRepositories;
public interface IUserRepository : IBaseRepository<User>
{
  Task<IEnumerable<User>> FindAsync(UserQueryModel model);
  Task<bool> RegisterAsync(User model, string password);
  Task<User?> GetByEmailAsync(string email);
  Task<User?> LoginAsync(string email, string password);
}
