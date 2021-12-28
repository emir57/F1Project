using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using f1project.business.Abstract;
using f1project.data.Abstract;
using f1project.entity.Concrete;

namespace f1project.business.Concrete
{
    public class CountryManager : ICountryService
    {
        ICountryDal _countryDal;
        public CountryManager(ICountryDal countryDal)
        {
            this._countryDal = countryDal;
        }
        public async Task Create(Country entity)
        {
            await _countryDal.Create(entity);
        }

        public async Task Delete(Country entity)
        {
            await _countryDal.Delete(entity);
        }

        public async Task<List<Country>> GetAll(Expression<Func<Country, bool>> filter = null)
        {
            return filter == null ?
                await _countryDal.GetAll():
                await _countryDal.GetAll(filter);
        }

        public async Task<Country> GetById(int id)
        {
            return await _countryDal.GetById(id);
        }

        public async Task Update(Country entity)
        {
            await _countryDal.Update(entity);
        }
    }
}