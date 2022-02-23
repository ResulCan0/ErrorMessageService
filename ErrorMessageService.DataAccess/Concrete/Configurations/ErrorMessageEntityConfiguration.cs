using ErrorMessageService.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ErrorMessageService.Data.Concrete.Configurations
{
    public class ErrorMessageEntityConfiguration : IEntityTypeConfiguration<ErrorMessages>
    {
        public void Configure(EntityTypeBuilder<ErrorMessages> builder)
        {
            #region PrimaryKey
            builder.HasKey(_ => _.ErrorMessageId);
            #endregion

            #region Columns
            builder.Property(_ => _.SubStatusCode);
            builder.Property(_ => _.StatusCode);
            builder.Property(_ => _.Name);
            builder.Property(_ => _.LanguageId);

            #endregion
        }
    }
}
