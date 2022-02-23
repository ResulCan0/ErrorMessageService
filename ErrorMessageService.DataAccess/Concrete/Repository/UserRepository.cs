using ErrorMessageService.Data.Abstract;
using ErrorMessageService.Data.Concrete.EntityFramework;
using ErrorMessageService.Data.Concrete.EntityFramework.Context;
using ErrorMessageService.Entities.Concrete;
using ErrorMessageService.Entities.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorMessageService.Data.Concrete.Repository
{
    public class UserRepository : EfEntityRepositoryBase<User, ErrorMessageContext>, IUserRepository
    {
        public UserRepository(ErrorMessageContext context) : base(context)
        {
        }

        public async Task<IEnumerable<UserWithUsernamePasswordDto>> GetByUsername(string username)
        {
            var result = await(from user in Context.User
                          where user.Username == username
                          select new UserWithUsernamePasswordDto()
                          {
                              Username = user.Username,
                              Password = user.Password
                          }).ToListAsync();

            return result;
        }
    }
}
