using Import.Application.Contract.DTO;
using Import.Application.Contract.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Import.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForeignTradeFileController : ControllerBase
    {
        private readonly IForeignTradeFileService foreignTradeFileService;

        public ForeignTradeFileController(IForeignTradeFileService foreignTradeFileService)
        {
            this.foreignTradeFileService = foreignTradeFileService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(ForeignTradeFileDTO model)
        {
            await foreignTradeFileService.Add(model);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> get(Guid id)
        {
            var result = foreignTradeFileService.GetById(id);
            return Ok(result);
        }
    }
}
