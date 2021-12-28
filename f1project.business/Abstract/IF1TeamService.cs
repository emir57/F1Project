using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using f1project.entity.Concrete;

namespace f1project.business.Abstract
{
    public interface IF1TeamService
    {
        Task Create(F1Team entity); 
        Task Update(F1Team entity); 
        Task Delete(F1Team entity);
        Task<F1Team> GetById(int id);
        Task<List<F1Team>> GetAll(Expression<Func<F1Team,bool>> filter=null);
        Task<F1Team> GetTeamWithPilots(int id);
    }
}