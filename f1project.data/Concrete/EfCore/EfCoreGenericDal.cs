using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using f1project.data.Abstract;
using f1project.entity.Abstract;
using Microsoft.EntityFrameworkCore;

namespace f1project.data.Concrete.EfCore
{
    public class EfCoreGenericDal<TEntity, TContext> : IRepositoryDal<TEntity>
    where TEntity:class,IEntity
    where TContext:DbContext,new()
    {
        public async Task Create(TEntity entity)
        {
            using(var context = new TContext())
            {
                context.Entry(entity).State = EntityState.Added;
                await context.SaveChangesAsync();
            }
        }

        public async Task Delete(TEntity entity)
        {
            using(var context = new TContext())
            {
                context.Entry(entity).State = EntityState.Deleted;
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using(var context = new TContext())
            {
                return filter == null ?
                    await context.Set<TEntity>().ToListAsync():
                    await context.Set<TEntity>().Where(filter).ToListAsync();
            }
        }

        public async Task<TEntity> GetById(int id)
        {
            using(var context = new TContext())
            {
                return await context.Set<TEntity>().FindAsync(id);
            }
        }

        public async Task Update(TEntity entity)
        {
            using(var context = new TContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
        }
    }
}