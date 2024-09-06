using Import.Domain.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Import.Domain.Core.ImportProforma
{
    public class ImportProforma : AggregateRoot<ImportProformaId>
    {
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public string Buyer { get; set; }
        public string Seller { get; set; }
        public string ManufacturerCountry { get; set; }
        public string BeneficiaryCountry { get; set; }
        public string BeneficiaryBanck { get; set; }
        public DateTime ValidityDate { get; set; }
        public BuyingMethod BuyingMethod { get; set; }
        public string PaymentMethod { get; set; }
        public string Currency { get; set; }
        public string PackingMethod { get; set; }
        public bool PartialShipment { get; set; }
        public string TransShipment { get; set; }
        public string ShippingOrigin { get; set; }
        public string ShippingDestination { get; set; }
        public DateTime FromCarryPeriodDate { get; set; }
        public DateTime ToCarryPeriodDate { get; set; }
        public string Responsible { get; set; }


        public  ICollection<ImportProformaGoodsDetail> ImportProformaGoodsDetails { get; }
        = new List<ImportProformaGoodsDetail>();
    }

    public enum BuyingMethod : int
    {
        FOB,
        EXW,
        CPT,
        CFR,
        DDP,
        DAP,
        DPU
    }
}
