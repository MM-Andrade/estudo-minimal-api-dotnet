using Microsoft.EntityFrameworkCore;
using TodoAPI.Data;

namespace TodoAPI.Extensions
{
    public static class DbExtensions
    {
        public static void AddDbServices(this IServiceCollection services, IConfiguration configuration)
        {
            var sectionName = "TodoDatabase";
            var connectionStringDb = configuration.GetConnectionString(sectionName);

            services.AddDbContext<TodoDb>(options => {
                options.UseSqlite(connectionStringDb);
            });

        }
    }
}
