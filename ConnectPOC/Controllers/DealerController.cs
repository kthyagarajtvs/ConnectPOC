using ConnectPOC.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConnectPOC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DealerController : ControllerBase
    {
        readonly IDealerRepository _dealerRepository;

        public DealerController(IDealerRepository dealerRepository)
        {
            _dealerRepository = dealerRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var dealers = await _dealerRepository.GetAllAsync();
            return Ok(dealers);
        }
    }
}
