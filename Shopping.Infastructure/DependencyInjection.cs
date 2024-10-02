using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Graph;
using Microsoft.Graph.Models;
using Shopping.Infrastructure.Presistance;
using Shopping.Infrastructure.Repository.Services;



namespace Shopping.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
       IConfiguration configuration)
        {

            //services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
           
           // services.AddScoped<IEmailService, EmailService>();

            return services;
        }

        public static WebApplication UseInfrastructureServices(this WebApplication app)
        {
           

            return app;
        }

    }
}
