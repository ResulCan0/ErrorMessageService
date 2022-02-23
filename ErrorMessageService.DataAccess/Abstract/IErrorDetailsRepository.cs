using ErrorMessageService.Data.Concrete.EntityFramework;
using ErrorMessageService.Entities.Concrete;
using ErrorMessageService.Entities.Dto;

namespace ErrorMessageService.Data.Abstract
{
    public interface IErrorDetailsRepository : IEntityRepository<ErrorsDetails>
    {
        Task<IEnumerable<ErrorDetailsDto>> GetErrorDetailsList();

    }
}
