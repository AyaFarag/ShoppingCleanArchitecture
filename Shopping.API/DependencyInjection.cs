using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Shopping.Application.Automapper;
using Shopping.Infrastructure.Presistance;




namespace Shopping.API
{

    public static class DependencyInjection 
    {
        public static IServiceCollection AddApiServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<DBContextApplication>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

         

            // Application Dependancy Injections
            //   services.AddSingleton<IAuthorizationHandler, PermissionHandler>();
            ////   services.AddScoped<IPermissionService, PermissionService>();
            //   services.AddScoped<IRoleService, RoleService>();
            //   services.AddScoped<IUserService, UserService>();
            //   services.AddScoped<ICategoryService, CategoryService>();

            services.AddAutoMapper(typeof(AutoMapperClassesProfile).Assembly);

            // Infrastructure Dependancy Injection
            //    services.AddScoped<IAuthRepository, AuthRepository>();
            ////    services.AddScoped<IPermissionRepository, PermissionRepository>();
            //    services.AddScoped<IRoleRepository, RoleRepository>();
            //    services.AddScoped<IUserRepository, UserRepository>();


            services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            return services;
        }

        public static WebApplication UseApiServices(this WebApplication app)
        {
           

            return app;
        }
    }
}
