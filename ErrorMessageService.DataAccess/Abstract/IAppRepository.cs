using ErrorMessageService.Data.Concrete.EntityFramework;
using ErrorMessageService.Entities.Concrete;

namespace ErrorMessageService.Data.Abstract
{
    public interface IAppRepository : IEntityRepository<App>
    {

    }
}
