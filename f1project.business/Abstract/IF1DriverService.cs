using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using f1project.entity.Concrete;

namespace f1project.business.Abstract
{
    public interface IF1DriverService
    {
        Task Create(F1Driver entity); 
        Task Update(F1Driver entity); 
        Task Delete(F1Driver entity);
        Task<F1Driver> GetById(int id);
        Task<List<F1Driver>> GetAll(Expression<Func<F1Driver,bool>> filter=null);
        Task<List<F1Driver>> GetAllWithCountries(Expression<Func<F1Driver,bool>> filter=null);
    }
}