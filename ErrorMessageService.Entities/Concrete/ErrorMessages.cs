﻿using ErrorMessageService.Entities.Base;

namespace ErrorMessageService.Entities.Concrete
{
    public class ErrorMessages : IEntity
    {
        #region Primary Key
        public int ErrorMessageId { get; set; }
        #endregion

        #region Columns

        public int SubStatusCode { get; set; }
        public int StatusCode { get; set; }
        public string Name { get; set; }

        public string Decription { get; set; }

        public int LanguageId { get; set; }

        #endregion

        #region Foreign Key
        public ICollection<ErrorsDetails> ErrorDetails { get; set; }

        #endregion
    }
}
