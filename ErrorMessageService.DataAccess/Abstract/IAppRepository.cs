using ErrorMessageService.Data.Concrete.EntityFramework;
using ErrorMessageService.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorMessageService.Data.Abstract
{
    public interface IAppRepository : IEntityRepository<App>
    {

    }
}
