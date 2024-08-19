using Microsoft.EntityFrameworkCore;

namespace UserService.Application.Interfaces.Common;
public interface IBaseRepository<T> where T : class
{
  Task<T?> CreateAsync(T entity);
  Task<bool> DeleteAsync(Guid id);
  Task<IEnumerable<T>> GetAllAsync();
  Task<T?> GetByIdAsync(Guid id);
  Task<T?> UpdateAsync(Guid id, T entity);
}
