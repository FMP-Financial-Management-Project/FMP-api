using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinancialManagement.Infrastructure
{
    public static class DependencyInjection
    {
        // Config DI Infrastructure Layer
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            var currentAssembly = typeof(DependencyInjection).Assembly;

            return services;
        }
    }
}
