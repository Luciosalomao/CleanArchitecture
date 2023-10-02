using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjetoCleanArchiteture.Application.Interfaces;
using ProjetoCleanArchiteture.Application.Services;
using ProjetoCleanArchiteture.Domain.Interfaces;
using ProjetoCleanArchiteture.Infra.Data.Context;
using ProjetoCleanArchiteture.Infra.Data.Repositories;

namespace ProjetoCleanArchiteture.Infra.Ioc
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration) 
        {

            var connectionString = configuration.GetConnectionString("DefaultConnection"); 
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();

            return services;
        }

    }
}
