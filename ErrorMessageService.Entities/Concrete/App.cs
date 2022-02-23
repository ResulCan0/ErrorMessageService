using ErrorMessageService.Entities.Base;

namespace ErrorMessageService.Entities.Concrete
{
    public class App : IEntity
    {
        #region Primary Key
        public int AppId { get; set; }
        #endregion

        #region Columns
        public string AppName { get; set; }

        #endregion

        #region Foreign Key
        public ICollection<ErrorsDetails> ErrorsDetails { get; set; }
        #endregion
    }
}
