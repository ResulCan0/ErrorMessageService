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
    public class ErrorMessageRepository : EfEntityRepositoryBase<ErrorMessages, ErrorMessageContext>,
        IErrorMessageRepository
    {
        public ErrorMessageRepository(ErrorMessageContext context) : base(context)
        {
        }

        public async Task<IEnumerable<ErrorMessageDto>> GetErrorMessageByLanguage(int languageId, int pageSize,
            int pageNumber)
        {
            var result = await (from errorMessage in Context.ErrorMessage
                where errorMessage.LanguageId == languageId
                select new ErrorMessageDto()
                {
                    ErrorMessageId = errorMessage.ErrorMessageId,
                    SubStatusCode = errorMessage.SubStatusCode,
                    StatusCode = errorMessage.StatusCode,
                    Name = errorMessage.Name,
                    Decription = errorMessage.Decription
                }).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToListAsync();
            return result;
        }

        public async Task<IEnumerable<ErrorMessageByStatusCodeDto>> GetErrorMessageBySubStatusCode(int languageId,
            int statusCode)
        {
            var result = await (from errorMessage in Context.ErrorMessage
                where errorMessage.StatusCode == statusCode
                where errorMessage.LanguageId==languageId
                select new ErrorMessageByStatusCodeDto()
                {
                    SubStatusCode = errorMessage.SubStatusCode,
                    StatusCode = errorMessage.StatusCode,
                    Name = errorMessage.Name,
                    Decription = errorMessage.Decription,
                    LanguageId = errorMessage.LanguageId
                }).ToListAsync();
            return result;
        }
    }
}