using BankPaymentService.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Text;

namespace BankPaymentService.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public readonly DbContext _context;
        public readonly DbSet<T> _dbSet;
        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.AnyAsync(expression);
        }

        public IQueryable<T> GetAll() => _dbSet;
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id) ?? Activator.CreateInstance<T>();
        }

        public void Remove(T entity)
        {
             _dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public T Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;    
            return entity;
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression);
        }
        public async Task<T> GetAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.FirstOrDefaultAsync(expression) ?? Activator.CreateInstance<T>();
        }
    }
}
