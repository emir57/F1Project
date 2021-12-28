using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using f1project.entity.Abstract;

namespace f1project.data.Abstract
{
    public interface IRepositoryDal<TEntity> 
    where TEntity: class,IEntity
    {
        Task Create(TEntity entity); 
        Task Update(TEntity entity); 
        Task Delete(TEntity entity);
        Task<TEntity> GetById(int id);
        Task<List<TEntity>> GetAll(Expression<Func<TEntity,bool>> filter=null);
    }
}