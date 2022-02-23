﻿using Core.Wrappers;
using ErrorMessageService.Data.Abstract;
using ErrorMessageService.Entities.Concrete;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorMessageService.Business.Handlers.Users.Queries
{
    public class GetUserQuery : IRequest<IResponse>
    {
        public class GetUserHandler : IRequestHandler<GetUserQuery, IResponse>
        {
            private readonly IUserRepository _userRepository;

            public GetUserHandler(IUserRepository userRepository)
            {
                _userRepository = userRepository;
            }

            public async Task<IResponse> Handle(GetUserQuery request, CancellationToken cancellationToken)
            {
                var getUser = await _userRepository.GetListAsync();

                return new Response<IEnumerable<User>>(getUser);
            }
        }
    }
}
