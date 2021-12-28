using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using f1project.business.Abstract;
using f1project.data.Abstract;
using f1project.entity.Concrete;

namespace f1project.business.Concrete
{
    public class F1TeamManager : IF1TeamService
    {
        IF1TeamDal _f1TeamDal;
        public F1TeamManager(IF1TeamDal f1TeamDal)
        {
            this._f1TeamDal = f1TeamDal;
        }
        public async Task Create(F1Team entity)
        {
            await _f1TeamDal.Create(entity);
        }

        public async Task Delete(F1Team entity)
        {
            await _f1TeamDal.Delete(entity);
        }

        public async Task<List<F1Team>> GetAll(Expression<Func<F1Team, bool>> filter = null)
        {
            return filter == null ?
                await _f1TeamDal.GetAll():
                await _f1TeamDal.GetAll(filter);
        }

        public async Task<F1Team> GetById(int id)
        {
            return await _f1TeamDal.GetById(id);
        }

        public async Task<F1Team> GetTeamWithPilots(int id)
        {
            return await _f1TeamDal.GetTeamWithPilots(id);
        }

        public async Task Update(F1Team entity)
        {
            await _f1TeamDal.Update(entity);
        }
    }
}