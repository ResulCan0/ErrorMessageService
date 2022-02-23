using ErrorMessageService.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorMessageService.Data.Concrete.Configurations;

    public class AppEntityConfiguration : IEntityTypeConfiguration<App>
    {
        public void Configure(EntityTypeBuilder<App> builder)
        {
            #region Primary Key
            builder.HasKey(_ => _.AppId);
            #endregion

            #region Columns
            builder.Property(_ => _.AppName).HasMaxLength(40);
            #endregion
    }
}

