using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using f1project.business.Abstract;
using f1project.data.Abstract;
using f1project.entity.Concrete;

namespace f1project.business.Concrete
{
    public class F1DriverManager : IF1DriverService
    {
        IF1DriverDal _f1DriverDal;
        public F1DriverManager(IF1DriverDal f1DriverDal)
        {
            this._f1DriverDal = f1DriverDal;
        }
        public async Task Create(F1Driver entity)
        {
            await _f1DriverDal.Create(entity);
        }

        public async Task Delete(F1Driver entity)
        {
            await _f1DriverDal.Delete(entity);
        }

        public async Task<List<F1Driver>> GetAll(Expression<Func<F1Driver, bool>> filter = null)
        {
            return filter == null ?
                await _f1DriverDal.GetAll():
                await _f1DriverDal.GetAll(filter);
        }

        public async Task<List<F1Driver>> GetAllWithCountries(Expression<Func<F1Driver, bool>> filter = null)
        {
            return await _f1DriverDal.GetAllWithCountries(filter);
        }

        public async Task<F1Driver> GetById(int id)
        {
            return await _f1DriverDal.GetById(id);
        }

        public async Task Update(F1Driver entity)
        {
            await _f1DriverDal.Update(entity);
        }
    }
}