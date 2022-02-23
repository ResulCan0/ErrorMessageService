using ErrorMessageService.Data.Abstract;
using ErrorMessageService.Data.Concrete.EntityFramework.Context;
using ErrorMessageService.Data.Concrete.Repository;
using ErrorMessageService.Entities.Concrete;
using ErrorMessageService.Entities.Dto;
using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
