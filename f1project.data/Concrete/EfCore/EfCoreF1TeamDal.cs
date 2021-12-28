using System.Linq;
using System.Threading.Tasks;
using f1project.data.Abstract;
using f1project.entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace f1project.data.Concrete.EfCore
{
    public class EfCoreF1TeamDal : EfCoreGenericDal<F1Team, F1ProjectContext>, IF1TeamDal
    {
        public async Task<F1Team> GetTeamWithPilots(int id)
        {
            using(var context = new F1ProjectContext())
            {
                return await context.Teams
                    .Include(a=>a.Drivers)
                    .FirstOrDefaultAsync(a=>a.TeamId==id);
            }
        }
    }
}