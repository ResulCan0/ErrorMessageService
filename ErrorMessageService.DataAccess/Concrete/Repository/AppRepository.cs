using ErrorMessageService.Data.Abstract;
using ErrorMessageService.Data.Concrete.EntityFramework;
using ErrorMessageService.Data.Concrete.EntityFramework.Context;
using ErrorMessageService.Entities.Concrete;

namespace ErrorMessageService.Data.Concrete.Repository
{
    public class AppRepository : EfEntityRepositoryBase<App, ErrorMessageContext>, IAppRepository
    {
        public AppRepository(ErrorMessageContext context) : base(context)
        {
        }
    }
}
