using ErrorMessageService.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ErrorMessageService.Data.Concrete.Configurations
{
    public class ErrorDetailsEntityConfigruation : IEntityTypeConfiguration<ErrorsDetails>
    {
        public void Configure(EntityTypeBuilder<ErrorsDetails> builder)
        {
            #region Primary Key
            builder.HasKey(_ => _.ErrorsDetailsId);
            #endregion

            #region Columns
            builder.Property(_ => _.RequestTime);

            #region App AppId -> AppId
            builder.Property(_ => _.App.AppId);
            builder
                .HasOne(_ => _.App)
                .WithMany(c => c.ErrorsDetails)
                .HasForeignKey(fk => fk.App.AppId)
                .OnDelete(DeleteBehavior.Restrict);

            #endregion

            #region ErrorMessage ErrorMessageId -> ErrorMessageId
            builder.Property(_ => _.ErrorMessage.ErrorMessageId);
            builder
                .HasOne(_ => _.ErrorMessage)
                .WithMany(c => c.ErrorDetails)
                .HasForeignKey(fk => fk.ErrorMessage.ErrorMessageId)
                .OnDelete(DeleteBehavior.Restrict);

            #endregion
            #endregion


        }
    }
}
