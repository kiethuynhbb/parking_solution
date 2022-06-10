using App.DataProvider;
using Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace App.Business
{
    public static class Setup
    {
        //public static IServiceCollection AddTrainingBusiness(this IServiceCollection services, IMapperConfigurationExpression mapperConfig)
        //{
        //    var assembly = Assembly.GetExecutingAssembly();

        //    services.Assembly(assembly)
        //        .Service<IBusinessAction>(ServiceLifetime.Transient)
        //        .Service<IInterceptor>(ServiceLifetime.Transient);

        //    //mapperConfig.AddProfile(new BusinessMapperProfile());

        //    return services;
        //}

        //public static IServiceCollection AddPersistence(this IServiceCollection services,
        //    IConfiguration configuration)
        //{
        //    services.AddDbContext<ParkingBoundedContext>(options =>
        //        options.UseSqlServer(configuration.GetConnectionString("ConnectionStrings"),
        //        b => b.MigrationsAssembly(typeof(ParkingBoundedContext).Assembly.FullName)), ServiceLifetime.Transient);

        //    services.AddScoped<IApplicationDBContext>(provider => provider.GetService<ParkingBoundedContext>());
        //    return services;
        //}
    }
}
