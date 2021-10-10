using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartGowala.Shared.Infrustructure.Interface
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        Task<IEnumerable<TEntity>> GetAllAsync();
        TEntity SingleOrDefault();
        Task<TEntity> SingleOrDefaultAsync();
        TEntity GetById(int id);
        Task<TEntity> GetByIdAsync(int id);
        void Insert(TEntity entity);
        void Insert(IEnumerable<TEntity> entities);
        Task InsertAsync(TEntity entity);
        Task InsertAsync(IEnumerable<TEntity> entities);
        int SaveChanges(bool ensureAutoHistory = false);
        Task<int> SaveChangesAsync(bool ensureAutoHistory = false);
        void Detach(TEntity entity);
    }
}
