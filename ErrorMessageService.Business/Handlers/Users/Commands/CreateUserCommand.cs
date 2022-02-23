using Core.Wrappers;
using ErrorMessageService.Business.Helper;
using ErrorMessageService.Data.Abstract;
using ErrorMessageService.Entities.Concrete;
using MediatR;

namespace ErrorMessageService.Business.Handlers.Users.Commands
{
    public class CreateUserCommand : IRequest<IResponse>
    {
        public string Title { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }

        public class CreateCategoryCommandHandler : IRequestHandler<CreateUserCommand, IResponse>
        {
            private readonly IUserRepository _userRepository;

            public CreateCategoryCommandHandler(IUserRepository userRepository)
            {
                _userRepository = userRepository;
            }
            public async Task<IResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
            {
                User addUser = new User();
                HashingPassword hash = new HashingPassword();
                addUser.Title = request.Title;
                addUser.Username = request.UserName;
                addUser.Password = hash.PassWordHash(request.Password);


                _userRepository.Add(addUser);
                var result = await _userRepository.GetByUsername(addUser.Username);

                if (result.Count() == 0)
                {
                    _userRepository.Add(addUser);
                    await _userRepository.SaveChangesAsync();
                    return new Response<User>(addUser);
                }
                else
                {
                    return null;
                }
            }
        }
    }
}

