using ErrorMessageService.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorMessageService.Data.Seed
{
    public class AppSeed : IEntityTypeConfiguration<App>
    {
        public void Configure(EntityTypeBuilder<App> builder)
        {
            builder.HasData(
                new App
                {
                    AppId =1,
                    AppName ="App1",
                },new App
                {
                    AppId = 2,
                    AppName = "App2",
                }, new App
                {
                    AppId = 3,
                    AppName = "App3",
                });
        }
    }
}
