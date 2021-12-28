using System.Threading.Tasks;
using f1project.entity.Concrete;

namespace f1project.data.Abstract
{
    public interface IF1TeamDal:IRepositoryDal<F1Team>
    {
        Task<F1Team> GetTeamWithPilots(int id);
    }
}