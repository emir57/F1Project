using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using f1project.data.Abstract;
using f1project.entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace f1project.data.Concrete.EfCore
{
    public class EfCoreF1DriverDal : EfCoreGenericDal<F1Driver, F1ProjectContext>, IF1DriverDal
    {
        public async Task<List<F1Driver>> GetAllWithCountries(Expression<Func<F1Driver, bool>> filter = null)
        {
            using(var context = new F1ProjectContext())
            {
                return filter==null?
                    await context.Drivers
                        .Include(a=>a.Country)
                        .Include(a=>a.Team)
                        .ToListAsync():
                    await context.Drivers
                        .Include(a=>a.Country)
                        .Include(a=>a.Team)
                        .Where(filter).ToListAsync();
            }
        }
        
    }
}