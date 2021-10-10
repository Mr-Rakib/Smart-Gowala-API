using Microsoft.EntityFrameworkCore;
using SmartGowala.Shared.Infrustructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGowala.Shared.Infrustructure
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbSet<TEntity> _dbSet;

        private DbContext _dbContext;

        public DbContext DbContext => _dbContext;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }

        [Obsolete("This method is not recommended, please use GetPagedList or GetPagedListAsync methods")]
        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.AsEnumerable();
        }


        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await Task.Run(() => _dbSet.AsEnumerable());
        }

        public TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await Task.Run(() => _dbSet.Find(id));    
        }

        public TEntity SingleOrDefault()
        {
            return _dbSet.SingleOrDefault();
        }

        public async Task<TEntity> SingleOrDefaultAsync()
        {
            return await _dbSet.SingleOrDefaultAsync();
        }

        public void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Insert(IEnumerable<TEntity> entities)
        {
            _dbSet.AddRange(entities);
        }

        public async Task InsertAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task InsertAsync(IEnumerable<TEntity> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        public int SaveChanges(bool ensureAutoHistory = false)
        {
            return this.DbContext.SaveChanges();
        }

        public async Task<int> SaveChangesAsync(bool ensureAutoHistory = false)
        {
            return await this.DbContext.SaveChangesAsync();
        }
        public void Detach(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Detached;
        }
    }
}
