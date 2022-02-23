using ErrorMessageService.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorMessageService.Entities.Concrete
{
    public class Language:IEntity
    {
        #region Primary Key
        public int LanguageId { get; set; }
        #endregion

        #region Columns

        public int LanguagePath { get; set; }

        public string LanguageName { get; set; }

        #endregion

        #region Foreign Key
        public ICollection<ErrorMessages> ErrorMessages { get; set; }

        #endregion
    }
}
