using ErrorMessageService.Data.Concrete.EntityFramework;
using ErrorMessageService.Entities.Concrete;
using ErrorMessageService.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorMessageService.Data.Abstract
{
    public interface IErrorDetailsRepository : IEntityRepository<ErrorsDetails>
    {
        Task<IEnumerable<ErrorDetailsDto>> GetErrorDetailsList();

    }
}
