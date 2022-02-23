using Core.Wrappers;
using ErrorMessageService.Data.Abstract;
using ErrorMessageService.Entities.Concrete;
using MediatR;

namespace ErrorMessageService.API.Handlers.ErrorMessage.Queries
{
    public class GetErrorMessageQuery : IRequest<IResponse>
    {
        public class GetErrorMessageQueryHandler : IRequestHandler<GetErrorMessageQuery, IResponse>
        {
            private readonly IErrorMessageRepository _errorMessageRepository;

            public GetErrorMessageQueryHandler(IErrorMessageRepository errorMessageRepository)
            {
                _errorMessageRepository = errorMessageRepository;
            }
            public async Task<IResponse> Handle(GetErrorMessageQuery request, CancellationToken cancellationToken)
            {
                var errorMessage = await _errorMessageRepository.GetListAsync();
                return new Response<IEnumerable<ErrorMessages>>(errorMessage);
            }
        }
    }
}
