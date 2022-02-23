using ErrorMessageService.Entities.Base;

namespace ErrorMessageService.Entities.Concrete
{
    public class User : IEntity
    {

        #region Primary Key
        public int UserId { get; set; }
        #endregion

        #region Columns

        public string Title { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        #endregion


    }
}
