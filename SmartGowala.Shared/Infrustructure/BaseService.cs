using AutoMapper;
using SmartGowala.Shared.Infrustructure.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartGowala.Shared.Infrustructure
{
    public class BaseService<T, U> : IBaseService<T, U>
         where T : class
         where U : class
    {
        private IRepository<U> _repository;
        public IRepository<U> Repository => _repository;
        public BaseService(IRepository<U> repository)
        {
            _repository = repository;
        }

        public IEnumerable<T> GetAll()
        {
            return Mapper.Map<IEnumerable<T>>(_repository.GetAll());
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await Task.Run(()=> Mapper.Map<IEnumerable<T>>(this.GetAll()));
        }

        public T GetById(int id)
        {
            return Mapper.Map<T>(_repository.GetById(id));
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await Task.Run(() => Mapper.Map<T>(this.GetById(id)));
        }

        public T SingleOrDefault()
        {
            return Mapper.Map<T>(_repository.SingleOrDefault());
        }

        public async Task<T> SingleOrDefaultAsync()
        {
            return Mapper.Map<T>(await _repository.SingleOrDefaultAsync());
        }

        public void Insert(T entity)
        {
            _repository.Insert(Mapper.Map<U>(entity));
        }

        public void Insert(IEnumerable<T> entities)
        {
            _repository.Insert(Mapper.Map<IEnumerable<U>>(entities));
        }

        public async Task InsertAsync(T entity)
        {
            await _repository.InsertAsync(Mapper.Map<U>(entity));
        }

        public async Task InsertAsync(IEnumerable<T> entities)
        {
            await _repository.InsertAsync(Mapper.Map<U[]>(entities));
        }

        public int SaveChanges(bool ensureAutoHistory = false)
        {
            return _repository.SaveChanges(ensureAutoHistory);
        }

        public async Task<int> SaveChangesAsync(bool ensureAutoHistory = false)
        {
            return await _repository.SaveChangesAsync(ensureAutoHistory);
        }

        public void Detach(T entity)
        {
            _repository.Detach(Mapper.Map<U>(entity));
        }
    }
}
