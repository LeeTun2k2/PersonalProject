using Microsoft.AspNetCore.Identity;
using UserService.Application.Interfaces.IRepositories;
using UserService.Core.Entities;
using UserService.Infrastructure.Data;

namespace UserService.Infrastructure.Repositories.UserRepository;

public partial class UserRepository(
  ApplicationDbContext context,
  UserManager<User> userManager,
  SignInManager<User> signInManager
  ) : BaseRepository<User>(context), IUserRepository
{ 

}
