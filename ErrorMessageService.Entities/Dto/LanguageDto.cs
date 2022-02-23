using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorMessageService.Entities.Dto
{
    public class LanguageDto
    {
        public int LanguageId { get; set; }
        public int LanguagePath { get; set; }

        public string LanguageName { get; set; }
    }
}
