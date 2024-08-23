using Import.Application.Contract.Interfaces;
using Import.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Import.Application
{
    public static class ApplicationServiceSetup
    {
        public static void AddApplicationService(this IServiceCollection services)
        {
            services.AddScoped<IForeignTradeFileService, ForeignTradeFileServices>();
        }
    }
}
