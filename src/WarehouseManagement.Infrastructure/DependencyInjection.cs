using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.Application.Interfaces.Repositories;
using WarehouseManagement.Infrastructure.Repositories;

namespace WarehouseManagement.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(
                options => options.UseNpgsql(
                    configuration.GetConnectionString("DefaultConnection")
                )
            );

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            //services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
