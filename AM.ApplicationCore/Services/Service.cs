using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class Service<TEntity> : IService<TEntity> where TEntity : class
    {

        private readonly IGenericRepository<TEntity> _repository;
        private readonly IUnitOfWork _unitOfWork;
        public Service(IUnitOfWork unitOfWork)
        {
            this._repository = unitOfWork.Repository<TEntity>();
            this._unitOfWork = unitOfWork;
        }
        public virtual void Add(TEntity entity)
        {
            _repository.Add(entity);
        }
        public virtual void Update(TEntity entity)
        {
            _repository.Update(entity);
        }
        public virtual void Delete(TEntity entity)
        {
            _repository.Delete(entity);
        }
        public virtual void Delete(Expression<Func<TEntity, bool>> where)
        {
            _repository.Delete(where);
        }
        public virtual TEntity GetById(params object[] id)
        {
            return _repository.GetById(id);
        }
        
        public virtual IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }
        public virtual IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> filter )
        {
            return _repository.GetMany(filter);
        }
        
        public virtual TEntity Get(Expression<Func<TEntity, bool>> where)
        {
             return _repository.Get(where);          
        }

        public void Commit()
        {
            try
            {
                _unitOfWork.Save();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

