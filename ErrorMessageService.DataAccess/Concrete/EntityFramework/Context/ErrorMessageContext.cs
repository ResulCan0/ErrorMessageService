using ErrorMessageService.Data.Seed;
using ErrorMessageService.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ErrorMessageService.Data.Concrete.EntityFramework.Context
{
    public class ErrorMessageContext : DbContext
    {
        protected readonly IConfiguration _configuration;

        public ErrorMessageContext(IConfiguration configuration) { _configuration = configuration; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("SqlConStr"));
        }

        public virtual DbSet<App> App { get; set; }
        public virtual DbSet<ErrorMessages> ErrorMessage { get; set; }
        public virtual DbSet<ErrorsDetails> ErrorsDetails { get; set; }
        public virtual DbSet<Language> Language { get; set; }

        public virtual DbSet<User> User { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ErrorMessages>().HasKey("ErrorMessageId");
            modelBuilder.Entity<ErrorsDetails>().HasKey("ErrorsDetailsId");
            modelBuilder.Entity<User>().HasKey("UserId");

            modelBuilder.ApplyConfiguration(new LanguageSeed());
            modelBuilder.ApplyConfiguration(new AppSeed());
            modelBuilder.ApplyConfiguration(new ErrorMessageSeed(new int[] { 1, 2 }));
        }

    }
}
