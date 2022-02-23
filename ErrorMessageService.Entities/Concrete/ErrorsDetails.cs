using ErrorMessageService.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorMessageService.Entities.Concrete
{
    public class ErrorsDetails:IEntity
    {
        #region Primary Key
        public int ErrorsDetailsId { get; set; }
        #endregion

        #region Columns
        public DateTime RequestTime { get; set; }
        #endregion

        #region Foreign Key
        public App App { get; set; }

        public ErrorMessages ErrorMessage { get; set; }
        #endregion
    }
}
