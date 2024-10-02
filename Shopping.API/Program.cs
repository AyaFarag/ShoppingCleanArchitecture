using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Shopping.API;
using Shopping.Application;
using Shopping.Application.Authorization;
using Shopping.Application.Behaviors.Validation;
using Shopping.Application.Contracts.Infrastructure.Interfaces;
using Shopping.Application.Contracts.Infrastructure.Interfaces.Repository;
using Shopping.Application.Contracts.Infrastructure.Services;
using Shopping.Application.Extensions;
using Shopping.Infrastructure;
using Shopping.Infrastructure.Repository.Services;



var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services
    .AddApplicationServices(builder.Configuration)
    .AddInfrastructureServices(builder.Configuration)
    .AddApiServices(builder.Configuration);


//builder.Services.AddAutoMapper(cfg => {
//    cfg.AddProfile<AutoMapperClassesProfile>();
//});
//var assemblies = AppDomain.CurrentDomain.GetAssemblies()
//    .Where(a => !a.FullName.Contains("AutoMapperClassesProfile")).ToArray();

//builder.Services.AddAutoMapper(assemblies);

// Application Dependancy Injections
builder.Services.AddSingleton<IAuthorizationHandler, PermissionHandler>();
builder.Services.AddScoped<IPermissionService, PermissionService>();
builder.Services.AddScoped<IRoleService, RoleService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IProductService, ProductService>();



// Infrastructure Dependancy Injection
builder.Services.AddScoped<IAuthRepository, AuthRepository>();
builder.Services.AddScoped<IPermissionRepository, PermissionRepository>();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();

//var assembly = typeof(Program).Assembly;
//builder.Services.AddValidatorsFromAssembly(assembly);

// Register FluentValidation
builder.Services.AddValidatorsFromAssemblyContaining<CategoryValidator>();

// Add FluentValidation to MVC
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddFluentValidationClientsideAdapters();

// Define a policy that requires a specific permission
builder.Services.AddCustomAuthorization();



var jwtSettings = builder.Configuration.GetSection("JwtSettings");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//var scope = app.Services.CreateScope();
//var services = scope.ServiceProvider;
//DataSeed.SeedRolesAndPermissions(services);

app.UseApiServices();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
