using ErrorMessageService.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
