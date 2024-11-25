using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Uygulaması
{
    public class GenericRepository<Tentity> where Tentity : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Tentity> _dbSet;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<Tentity>();
        }


        public async Task AddAsync(Tentity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task<IEnumerable<Tentity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<IEnumerable<Tentity>> GetAllAsync(string Include)
        {
            return await _dbSet.Include(Include).ToListAsync();
        }

        public IEnumerable<Tentity> GetAll()
        {
            return _dbSet.ToList();
        }

        public async Task<Tentity> GetByIdAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                _context.Entry(entity).State = EntityState.Detached;
            }

            return entity;
        }

        public void Remove(Tentity entity)
        {
            _dbSet.Remove(entity);
        }

        public void RageRemove(List<Tentity> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public Tentity Update(Tentity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;

            return entity;
        }

        public Tentity NotUpdate(Tentity entity)
        {
            _context.Entry(entity).State = EntityState.Detached;

            return entity;
        }

        public IQueryable<Tentity> Where(Expression<Func<Tentity, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public bool Any(Expression<Func<Tentity, bool>> predicate)
        {
            return _dbSet.Any(predicate);
        }

        public Task<bool> AnyAsync(Expression<Func<Tentity, bool>> predicate)
        {
            return _dbSet.AnyAsync(predicate);
        }

        public async Task<IEnumerable<Tentity>> GetAllAsync(string Include, string Include2)
        {
            return await _dbSet.Include(Include).Include(Include2).ToListAsync();
        }
    }
}
