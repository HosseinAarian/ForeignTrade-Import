using Microsoft.EntityFrameworkCore;
using System.Xml.Serialization;

namespace Import.API.Configurations
{
    public static class DataBaseSetup
    {
        public static void AddDataBaseSetup(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null)
            {
                throw new ArgumentException(nameof(services));
            }

            string? connectionString = configuration.GetConnectionString("ImportConnection");

            services.AddDbContext<Import.Infrastructure.DataBase.Context.ImportContext>(options =>
            {
                options.UseSqlServer(connectionString,
                    sqlServerOptionsAction: sqlOptions =>
                    {
                        sqlOptions.EnableRetryOnFailure();
                    });
            });
        }
    }
}

