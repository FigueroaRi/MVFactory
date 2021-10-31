using Microsoft.Extensions.DependencyInjection;
using MVFactory.Transversal.Common;
using MVFactory.Infraestructura.Data;
using MVFactory.Infraestructura.Repository;
using MVFactory.Aplicacion.Interface;
using MVFactory.Aplicacion.Main;
using MVFactory.Domain.Interface;
using MVFactory.Domain.Core;
using MVFactory.Infraestructura.Interfaces;
using MVFactory.Transversal.Logging;
using Microsoft.Extensions.Configuration;

namespace MVFactory.Services.WebApi.Modules.Injection
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IConfiguration>(configuration);
            services.AddSingleton<IConnectionFactory, ConnectionFactory>();


            services.AddScoped<ICiudadesAplicacion, CiudadesAplicacion>();
            services.AddScoped<ICiudadesDomain, CiudadesDomain>();
            services.AddScoped<ICiudadesRepository, CiudadesRepositiry>();

            services.AddScoped<IClimasHistoricoAplicacion, ClimasHistoricoAplicacion>();
            services.AddScoped<IClimasHistoricoDomain, ClimasHistoricoDomain>();
            services.AddScoped<IClimasHistoricoRepository, ClimasHistoricoRepository>();

            services.AddScoped<IClimasAplicacion, ClimasAplicacion>();



            services.AddScoped<IUsersApplicacion, UsersAplicacion>();
            services.AddScoped<IUsersDomain, UsersDomain>();
            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));

            return services;
        }
    }
}
