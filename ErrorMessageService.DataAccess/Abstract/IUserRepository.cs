using ErrorMessageService.Data.Concrete.EntityFramework;
using ErrorMessageService.Entities.Concrete;
using ErrorMessageService.Entities.Dto;

namespace ErrorMessageService.Data.Abstract
{
    public interface IUserRepository : IEntityRepository<User>
    {
        Task<IEnumerable<UserWithUsernamePasswordDto>> GetByUsername(string username);
    }
}
