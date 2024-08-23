using Import.Domain.Core.ImportFiles;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Import.Infrastructure.Repositories
{
    public class ForeignTradeImportRepository : ImportFileRepository
    {
        private readonly Import.Infrastructure.DataBase.Context.ImportContext importContext;

        public ForeignTradeImportRepository(Import.Infrastructure.DataBase.Context.ImportContext importContext)
        {
            this.importContext = importContext;
        }

        

        public async Task<ImportFile> GetById(ImportFileId importFileId)
        {
            return await importContext.ImportFiles.FindAsync(importFileId);
        }

        public async Task<ImportFileId> Insert(ImportFile importFile)
        {
            await importContext.AddAsync(importFile);
            return importFile.Id;
        }

        public Task Update(ImportFile importFile)
        {
            throw new NotImplementedException();
        }

        public void Delete(ImportFileId importFileId)
        {
            throw new NotImplementedException();
        }   
    }
}
