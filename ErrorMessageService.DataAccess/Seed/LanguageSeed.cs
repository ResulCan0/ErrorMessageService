using ErrorMessageService.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ErrorMessageService.Data.Seed
{
    public class LanguageSeed : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.HasData(
                new Language
                {
                    LanguageId = 1,
                    LanguagePath = 1,
                    LanguageName = "İngilizce"
                }, new Language
                {
                    LanguageId = 2,
                    LanguagePath = 2,
                    LanguageName = "Türkçe"
                });
        }
    }
}
