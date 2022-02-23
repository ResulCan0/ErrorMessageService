using ErrorMessageService.Data.Concrete.EntityFramework;
using ErrorMessageService.Entities.Concrete;
using ErrorMessageService.Entities.Dto;

namespace ErrorMessageService.Data.Abstract
{
    public interface IErrorMessageRepository : IEntityRepository<ErrorMessages>
    {
        Task<IEnumerable<ErrorMessageDto>> GetErrorMessageByLanguage(int languageId, int pageSize, int pageNumber);

        Task<IEnumerable<ErrorMessageByStatusCodeDto>> GetErrorMessageBySubStatusCode(int languageId, int statusCode);
    }
}
