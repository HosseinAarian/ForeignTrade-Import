using Import.Application.Contract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Import.Application.Contract.Interfaces
{
    public interface IForeignTradeFileService
    {
        Task<List<ForeignTradeFileDTO>> GetAll();
        Task<ForeignTradeFileDTO> GetById(Guid id);
        Task Add(ForeignTradeFileDTO model);
        Task Edit(ForeignTradeFileDTO model);
        Task Remove(Guid id);
    }
}
