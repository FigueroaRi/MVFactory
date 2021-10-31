using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using MVFactory.Aplicacion.Validador;


namespace MVFactory.Services.WebApi.Modules.Validator
{
    public static class ValidatorExtensions
    {

        public static IServiceCollection AddValidator(this IServiceCollection services)
        {
            services.AddTransient<UsersDtoValidador>();
            return services;
        }
    }
}
