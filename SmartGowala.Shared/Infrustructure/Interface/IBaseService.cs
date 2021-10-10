using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartGowala.Shared.Infrustructure.Interface
{
    public interface IBaseService<T, U>
        where T : class
        where U : class
    {
        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync();
        T SingleOrDefault();
        Task<T> SingleOrDefaultAsync();
        T GetById(int id);
        Task<T> GetByIdAsync(int id);
        void Insert(T entity);
        void Insert(IEnumerable<T> entities);
        Task InsertAsync(T entity);
        Task InsertAsync(IEnumerable<T> entities);
        int SaveChanges(bool ensureAutoHistory = false);
        Task<int> SaveChangesAsync(bool ensureAutoHistory = false);
        void Detach(T entity);
    }
}
