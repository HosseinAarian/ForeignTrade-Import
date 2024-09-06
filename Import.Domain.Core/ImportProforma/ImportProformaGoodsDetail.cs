using Import.Domain.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Import.Domain.Core.ImportProforma
{
    public class ImportProformaGoodsDetail : ValueObject<ImportProformaGoodsDetail>
    {
        public string GoodsCode { get; set; }
        public string GoodsName { get; set; }
        public string MeasurementUnit { get; set; }
        public decimal Fee { get; set; }
        public double Number { get; set; }
        public decimal GrossWeight { get; set; }
        public decimal NetWeight { get; set; }
        public decimal FobAmount { get; set; }
        public string HsCode { get; set; }

        public ImportProformaId ImportProformaId { get; set; }
        public ImportProforma? ImportProforma { get; set; } = null;

        public ImportProformaGoodsDetail()
        {
                
        }

        protected override bool EqualsCore(ImportProformaGoodsDetail Other)
        {
            throw new NotImplementedException();
        }

        protected override int GetHashCodeCore()
        {
            throw new NotImplementedException();
        }
    }
}
