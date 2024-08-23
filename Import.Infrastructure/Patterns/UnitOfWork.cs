using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Import.Infrastructure.Patterns
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Import.Infrastructure.DataBase.Context.ImportContext importContext;

        public UnitOfWork(Import.Infrastructure.DataBase.Context.ImportContext importContext)
        {
            this.importContext = importContext;
        }

        public void Dispose()
        {
            importContext.Dispose();
        }

        public async Task SaveChanges()
        {
            await importContext.SaveChangesAsync();
        }
    }
}
