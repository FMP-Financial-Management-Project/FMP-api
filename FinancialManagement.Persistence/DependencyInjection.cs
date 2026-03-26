using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinancialManagement.Persistence
{
    public static class DependencyInjection
    {
        // Config DI Persistence Layer
        public static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            var currentAssembly = typeof(DependencyInjection).Assembly;

            return services;
        }
    }
}
