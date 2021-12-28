using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using f1project.entity.Concrete;

namespace f1project.business.Abstract
{
    public interface ICountryService
    {
        Task Create(Country entity); 
        Task Update(Country entity); 
        Task Delete(Country entity);
        Task<Country> GetById(int id);
        Task<List<Country>> GetAll(Expression<Func<Country,bool>> filter=null);
    }
}