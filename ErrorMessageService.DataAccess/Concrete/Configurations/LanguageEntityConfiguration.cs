using ErrorMessageService.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ErrorMessageService.Data.Concrete.Configurations
{
    public class LanguageEntityConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            #region Primary Key
            builder.HasKey(_ => _.LanguageId);
            #endregion

            #region Columns
            builder.Property(_ => _.LanguageName).HasMaxLength(40);
            builder.Property(_ => _.LanguagePath);
            #endregion
        }
    }
}
