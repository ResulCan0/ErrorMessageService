﻿using Core.Wrappers;
using ErrorMessageService.Data.Abstract;
using ErrorMessageService.Entities.Concrete;
using ErrorMessageService.Entities.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorMessageService.Business.Handlers.Languages.Queries
{
    public class GetLanguageQuery : IRequest<IResponse>
    {
        public class GetLanguageHandler : IRequestHandler<GetLanguageQuery, IResponse>
        {
            private readonly ILanguageRepository _languageRepository;
            public GetLanguageHandler(ILanguageRepository languageRepository)
            {
                _languageRepository = languageRepository;
            }
            public async Task<IResponse> Handle(GetLanguageQuery request, CancellationToken cancellationToken)
            {
                var languages = await _languageRepository.GetLanguageList();

                return new Response<IEnumerable<LanguageDto>>(languages);
            }
        }

    }
}
