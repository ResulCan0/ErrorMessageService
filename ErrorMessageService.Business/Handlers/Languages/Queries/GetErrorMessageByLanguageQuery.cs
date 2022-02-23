using Core.Wrappers;
using ErrorMessageService.Core.Wrappers;
using ErrorMessageService.Data.Abstract;
using ErrorMessageService.Entities.Concrete;
using ErrorMessageService.Entities.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorMessageService.Business.Handlers.ErrorMessage.Queries
{
    public class GetErrorMessageByLanguageQuery : IRequest<IResponse>
    {
        public int LanguageId { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }

        public class GetErrorMessageByLanguageHandler : IRequestHandler<GetErrorMessageByLanguageQuery, IResponse>
        {
            private readonly IErrorMessageRepository _errorMessageRepository;

            public GetErrorMessageByLanguageHandler(IErrorMessageRepository errorMessageRepository)
            {
                _errorMessageRepository = errorMessageRepository;
            }

            public async Task<IResponse> Handle(GetErrorMessageByLanguageQuery request, CancellationToken cancellationToken)
            {
                var errorMessages = await _errorMessageRepository.GetErrorMessageByLanguage(request.LanguageId,request.PageSize, request.PageNumber);

                return new LanguageResponse<IEnumerable<ErrorMessageDto>>(errorMessages, request.LanguageId, request.PageSize, request.PageNumber, "");
            }
        }
    }
}
