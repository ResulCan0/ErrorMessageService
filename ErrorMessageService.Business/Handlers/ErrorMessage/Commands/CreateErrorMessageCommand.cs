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
    public class CreateErrorMessageCommand : IRequest<IResponse>
    {
        public int SubStatusCode { get; set; }
        public int StatusCode { get; set; }
        public string Name { get; set; }
        public string Decription { get; set; }
        public int LanguageId { get; set; }

        public class CreateCategoryCommandHandler : IRequestHandler<CreateErrorMessageCommand, IResponse>
        {
            private readonly IErrorMessageRepository _errorMessageRepository;

            public CreateCategoryCommandHandler(IErrorMessageRepository errorMessageRepository)
            {
                _errorMessageRepository = errorMessageRepository;
            }
            public async Task<IResponse> Handle(CreateErrorMessageCommand request, CancellationToken cancellationToken)
            {
                ErrorMessages addMessage = new ErrorMessages();
                addMessage.SubStatusCode = request.SubStatusCode;
                addMessage.Name = request.Name;
                addMessage.Decription = request.Decription;
                addMessage.StatusCode = request.StatusCode;
                addMessage.LanguageId = request.LanguageId;

                _errorMessageRepository.Add(addMessage);
                await _errorMessageRepository.SaveChangesAsync();

                return new Response<ErrorMessages>(addMessage);
            }
        }
    }
}
