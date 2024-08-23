using Import.Domain.Core.ImportFiles;
using Import.Infrastructure.Patterns;
using Import.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Import.Infrastructure
{
    public static class InfrastructureSetup
    {
        public static void AddInfrastructureRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ImportFileRepository, ForeignTradeImportRepository>();
        }
    }
}
