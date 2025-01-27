
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using FluentValidation.AspNetCore;
using FluentValidation;
using SIPConnector.Application.Buy.Commands;

namespace SIPConnector.Application
{
    public static  class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // Registrar MediatR
            services.AddMediatR(typeof(DependencyInjection).Assembly);

            // Agregar FluentValidation
            services.AddFluentValidationAutoValidation()
                            .AddFluentValidationClientsideAdapters();

            // Registrar validadores automáticamente desde el ensamblado
            services.AddValidatorsFromAssemblyContaining<CreateBuyCommandValidator>();

            return services;
        }
    }
}
