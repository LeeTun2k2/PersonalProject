using Microsoft.EntityFrameworkCore;
using UserService.Application.Interfaces.Common;
using UserService.Infrastructure.Data;

namespace UserService.Infrastructure.Repositories;
public class BaseRepository<T> : IBaseRepository<T> where T : class
{
  protected readonly ApplicationDbContext _context;
  protected readonly DbSet<T> _dbSet;

  public BaseRepository(ApplicationDbContext context)
  {
    _context = context ?? throw new ArgumentNullException(nameof(context));
    _dbSet = _context.Set<T>();
  }

  public async Task<T?> CreateAsync(T entity)
  {
    if (entity == null)
      return null;

    var result = await _dbSet.AddAsync(entity);
    return result.Entity;
  }

  public async Task<bool> DeleteAsync(Guid id)
  {
    var entity = await _dbSet.FindAsync(id);
    if (entity == null)
      return false;

    _dbSet.Remove(entity);
    await _context.SaveChangesAsync();
    return true;
  }

  public async Task<IEnumerable<T>> GetAllAsync()
  {
    return await _dbSet
      .AsNoTracking()
      .ToListAsync();
  }

  public async Task<T?> GetByIdAsync(Guid id)
  {
    return await _dbSet.FindAsync(id);
  }

  public async Task<T?> UpdateAsync(Guid id, T entity)
  {
    if (entity == null)
      return null;

    var existingEntity = await _dbSet.FindAsync(id);
    if (existingEntity == null)
      return null;

    _context.Entry(existingEntity).CurrentValues.SetValues(entity);
    await _context.SaveChangesAsync();
    return existingEntity;
  }
}
