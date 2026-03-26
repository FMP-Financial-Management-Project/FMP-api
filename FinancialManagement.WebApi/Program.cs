
using FinancialManagement.Application;
using FinancialManagement.Infrastructure;
using FinancialManagement.Persistence;
using FinancialManagement.Presentation;

namespace FinancialManagement.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddApplication()
                            .AddInfrastructure()
                            .AddPersistence()
                            .AddPresentation();

            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
