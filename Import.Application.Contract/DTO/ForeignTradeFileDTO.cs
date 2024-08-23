using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Import.Application.Contract.DTO
{
    public class ForeignTradeFileDTO
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public string Date { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
    }
}
