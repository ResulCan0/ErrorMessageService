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
    public class LanguageRepository : EfEntityRepositoryBase<Language, ErrorMessageContext>, ILanguageRepository
    {
        public LanguageRepository(ErrorMessageContext context) : base(context)
        {

        }
        public async Task<IEnumerable<LanguageDto>> GetLanguageList()
        {
            var result = await (from languages in Context.Language
                                select new LanguageDto()
                                {
                                    LanguageId = languages.LanguageId,
                                    LanguageName = languages.LanguageName,
                                    LanguagePath = languages.LanguagePath
                                }).ToListAsync();
            return result;
        }
    }
}
