using ErrorMessageService.Data.Abstract;
using ErrorMessageService.Data.Concrete.EntityFramework.Context;
using ErrorMessageService.Data.Concrete.Repository;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Business.Extensions
{
    public static class ServiceRegistration
    {
        public static IServiceCollection RegisterDatabase(this IServiceCollection services, IConfiguration configuration)
        {

            return services.AddDbContext<ErrorMessageContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SqlConStr"),
                    sqlOptions =>
                    {
                        sqlOptions
                            .EnableRetryOnFailure(
                                maxRetryCount: 1,
                                maxRetryDelay: TimeSpan.FromSeconds(10),
                                errorNumbersToAdd: null);
                    });
                // options.EnableSensitiveDataLogging();
                // options.EnableDetailedErrors();
            }, ServiceLifetime.Transient, ServiceLifetime.Singleton);
        }
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            return services.AddTransient<IAppRepository, AppRepository>()
                           .AddTransient<IErrorMessageRepository, ErrorMessageRepository>()
                           .AddTransient<IErrorDetailsRepository, ErrorDetailsRepository>()
                           .AddTransient<ILanguageRepository, LanguageRepository>()
                           .AddTransient<IUserRepository, UserRepository>();


        }
        public static void AddBusinessLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly())
                 .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
