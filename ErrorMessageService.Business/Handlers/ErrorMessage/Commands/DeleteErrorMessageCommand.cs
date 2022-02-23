using Core.Wrappers;
using ErrorMessageService.Data.Abstract;
using ErrorMessageService.Entities.Concrete;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorMessageService.Business.Handlers.ErrorMessage.Commands
{
    public class DeleteErrorMessageCommand : IRequest<IResponse>
    {

        public int ErrorMessageId { get; set; }

        public class DeleteErrorMessageCommandHandler : IRequestHandler<DeleteErrorMessageCommand, IResponse>
        {
            private readonly IErrorMessageRepository _errorMessageRepository;

            public DeleteErrorMessageCommandHandler(IErrorMessageRepository errorMessageRepository)
            {
                _errorMessageRepository = errorMessageRepository;
            }
            public async Task<IResponse> Handle(DeleteErrorMessageCommand request, CancellationToken cancellationToken)
            {
                ErrorMessages deleteMessage = await _errorMessageRepository.GetAsync(_ => _.ErrorMessageId == request.ErrorMessageId);

                _errorMessageRepository.Delete(deleteMessage);
                await _errorMessageRepository.SaveChangesAsync();

                return new Response<ErrorMessages>(deleteMessage);
            }
        }
    }
}
