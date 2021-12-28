using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using f1project.entity.Concrete;

namespace f1project.data.Abstract
{
    public interface IF1DriverDal:IRepositoryDal<F1Driver>
    {
        Task<List<F1Driver>> GetAllWithCountries(Expression<Func<F1Driver,bool>> filter=null);
    }
}