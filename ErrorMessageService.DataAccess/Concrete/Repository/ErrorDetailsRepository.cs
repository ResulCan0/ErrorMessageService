using ErrorMessageService.Data.Abstract;
using ErrorMessageService.Data.Concrete.EntityFramework;
using ErrorMessageService.Data.Concrete.EntityFramework.Context;
using ErrorMessageService.Entities.Concrete;
using ErrorMessageService.Entities.Dto;
using Microsoft.EntityFrameworkCore;

namespace ErrorMessageService.Data.Concrete.Repository
{
    public class ErrorDetailsRepository : EfEntityRepositoryBase<ErrorsDetails, ErrorMessageContext>, IErrorDetailsRepository
    {
        public ErrorDetailsRepository(ErrorMessageContext context) : base(context)
        {
        }

        public async Task<IEnumerable<ErrorDetailsDto>> GetErrorDetailsList()
        {
            var result = await (from errordetails in Context.ErrorsDetails
                                join errormessage in Context.ErrorMessage
                                    on errordetails.ErrorsDetailsId equals errormessage.ErrorMessageId
                                join abc in Context.App
                                on errordetails.App.AppId equals abc.AppId
                                select new ErrorDetailsDto()
                                {
                                    AppName = abc.AppName,
                                    Description = errormessage.Decription,
                                    ErrorMessageStatusCode = errormessage.StatusCode,
                                    RequestTime = DateTime.Now,

                                }).ToListAsync();
            return result;
        }
    }
}
