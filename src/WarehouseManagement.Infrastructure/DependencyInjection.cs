using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement.Infrastructure
{
    internal static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(
                options => options.UseNpgsql(
                    configuration.GetConnectionString("Host=postgres;Port=5432;Database=warehause_management;Username=postgres;Password=postgres")
                )
            );

            //services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
