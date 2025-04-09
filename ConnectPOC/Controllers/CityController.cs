using ConnectPOC.Repositories.Interfaces;
using ConnectPOC.Repositories.SqlImplementations;
using Microsoft.AspNetCore.Mvc;

namespace ConnectPOC.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CityController : ControllerBase
    {
        private readonly ITokenService _tokenService;
        private readonly ICityRepository _cityRepository;

        public CityController(ITokenService tokenService, ICityRepository _city)
        {
            _tokenService = tokenService;
            _cityRepository = _city;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetCities()
        {
            var cities = await _cityRepository.GetAllCitiesAsync();
            return Ok(cities);
        }
    }
}
