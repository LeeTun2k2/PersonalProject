using Microsoft.EntityFrameworkCore;
using UserService.Core.Entities;
using UserService.Core.Models.UserModels;

namespace UserService.Infrastructure.Repositories.UserRepository;

public partial class UserRepository
{
  public async Task<IEnumerable<User>> FindAsync(UserQueryModel model)
  {
    // Validate input
    if (model == null)
      return [];

    // Build query
    var query = _dbSet.AsQueryable();

    //// Build validating email query
    if (!string.IsNullOrWhiteSpace(model.Email))
    {
      query = query
        .Where(x => !string.IsNullOrEmpty(x.Email) && x.Email.Contains(model.Email));
    }

    //// Build validating phone number query
    if (!string.IsNullOrWhiteSpace(model.PhoneNumber))
    {
      query = query
        .Where(x => !string.IsNullOrEmpty(x.PhoneNumber) && x.PhoneNumber.Contains(model.PhoneNumber));
    }

    //// Build validating name query
    if (!string.IsNullOrWhiteSpace(model.Name))
    {
      query = query
        .Where(x => !string.IsNullOrEmpty(x.Name) && x.Name.Contains(model.Name));
    }

    // Execute query
    var result = await query
      .AsNoTracking()
      .ToListAsync() ?? [];

    // Return
    return result;
  }
}
