using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace FinancialManagement.Application
{
    public static class DependencyInjection
    {
        // Config DI Application Layer
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var currentAssembly = typeof(DependencyInjection).Assembly;

            services.AddMediatR(config => config.RegisterServicesFromAssembly(currentAssembly));

            services.AddValidatorsFromAssembly(currentAssembly);

            return services;
        }
    }
}
