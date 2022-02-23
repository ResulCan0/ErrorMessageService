using Core.Wrappers;
using ErrorMessageService.Data.Abstract;
using ErrorMessageService.Entities.Concrete;
using MediatR;

namespace ErrorMessageService.Business.Handlers.ErrorMessage.Queries
{
    public class GetErrorMessageByIdQuery : IRequest<IResponse>
    {
        public int ErrorMessageId { get; set; }
        public class GetErrorMessageByIdLanguageHandler : IRequestHandler<GetErrorMessageByIdQuery, IResponse>
        {
            private readonly IErrorMessageRepository _errorMessageRepository;

            public GetErrorMessageByIdLanguageHandler(IErrorMessageRepository errorMessageRepository)
            {
                _errorMessageRepository = errorMessageRepository;
            }

            public async Task<IResponse> Handle(GetErrorMessageByIdQuery request, CancellationToken cancellationToken)
            {
                var errorMessage = await _errorMessageRepository.GetAsync(_ => _.ErrorMessageId == request.ErrorMessageId);

                return new Response<ErrorMessages>(errorMessage);

            }
        }
    }
}
