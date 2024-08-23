using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Import.Domain.Core.ImportFiles
{
    public interface ImportFileRepository
    {
        Task<ImportFileId> Insert(ImportFile importFile);
        Task Update(ImportFile importFile);
        Task<ImportFile> GetById(ImportFileId importFileId);
        void Delete(ImportFileId importFileId);
    }
}
