using Import.Domain.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Import.Domain.Core.ImportFiles
{
    public sealed class ImportFileId : StronglyTypeId<ImportFileId>
    {
        public ImportFileId(Guid value) : base(value) { }
    }
}
