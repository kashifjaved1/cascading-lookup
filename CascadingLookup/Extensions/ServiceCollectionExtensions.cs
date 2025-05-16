using CascadingLookup.Data;
using Microsoft.EntityFrameworkCore;

namespace CascadingLookup.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection Configuration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddControllersWithViews();

            return services;
        }
    }
}