using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinancialManagement.Presentation
{
    public static class DependencyInjection
    {
        // Config DI Presentation Layer
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            var currentAssembly = typeof(DependencyInjection).Assembly;

            return services;
        }
    }
}
