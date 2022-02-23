using Core.Wrappers;
using ErrorMessageService.Data.Abstract;
using ErrorMessageService.Entities.Dto;
using MediatR;

namespace ErrorMessageService.Business.Handlers.ErrorMessage.Queries;

public class GetErrorMessageByStatusCode : IRequest<IResponse>
{
    public int StatusCode { get; set; } 
    public int LanguageId { get; set; } 
    public class GetErrorMessageBySubStatusCodeHandler : IRequestHandler<GetErrorMessageByStatusCode, IResponse>
    {
        private readonly IErrorMessageRepository _errorMessageRepository;

        public GetErrorMessageBySubStatusCodeHandler(IErrorMessageRepository errorMessageRepository)
        {
            _errorMessageRepository = errorMessageRepository;
        }
        public async Task<IResponse> Handle(GetErrorMessageByStatusCode request, CancellationToken cancellationToken)
        {
            var errorMessage =
                await _errorMessageRepository.GetErrorMessageBySubStatusCode(request.LanguageId, request.StatusCode);
            return new Response<IEnumerable<ErrorMessageByStatusCodeDto>>(errorMessage);
        }
    }
}