using ErrorMessageService.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ErrorMessageService.Data.Concrete.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            #region Primary Key
            builder.HasKey(_ => _.UserId);
            #endregion

            #region Columns
            builder.Property(_ => _.Title);
            builder.Property(_ => _.Username);
            builder.Property(_ => _.Password);
            #endregion
        }
    }
}
