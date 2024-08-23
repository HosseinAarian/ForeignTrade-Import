using Import.Application.Contract.DTO;
using Import.Application.Contract.Interfaces;
using Import.Domain.Core.ImportFiles;
using Import.Infrastructure.Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Import.Application.Services
{
    public class ForeignTradeFileServices : IForeignTradeFileService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ImportFileRepository importFileRepository;

        public ForeignTradeFileServices(IUnitOfWork unitOfWork, ImportFileRepository importFileRepository)
        {
            this.unitOfWork = unitOfWork;
            this.importFileRepository = importFileRepository;
        }

        public async Task Add(ForeignTradeFileDTO model)
        {
            var file = ImportFile.CreateNew(model.Number, model.Date, model.Status, model.Description);
            await importFileRepository.Insert(file);
            await unitOfWork.SaveChanges();
        }

        public Task Edit(ForeignTradeFileDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<List<ForeignTradeFileDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<ForeignTradeFileDTO> GetById(Guid id)
        {
            var file = await importFileRepository.GetById(new ImportFileId(id));
            return new ForeignTradeFileDTO
            {
                Id = id,
                Number = file.Number,
                Date = file.Date,
                Status = file.Status,
                Description = file.Description
            };
        }

        public Task Remove(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
