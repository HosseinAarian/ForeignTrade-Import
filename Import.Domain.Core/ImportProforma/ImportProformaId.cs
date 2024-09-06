using Import.Domain.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Import.Domain.Core.ImportProforma
{
    public class ImportProformaId : StronglyTypeId<ImportProformaId>
    {
        public ImportProformaId(Guid value) : base(value) { }
    }
}
