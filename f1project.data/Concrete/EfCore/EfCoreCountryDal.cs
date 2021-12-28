using f1project.data.Abstract;
using f1project.entity.Concrete;

namespace f1project.data.Concrete.EfCore
{
    public class EfCoreCountryDal : EfCoreGenericDal<Country,F1ProjectContext>,ICountryDal
    {
        
    }
}