using ConnectPOC.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ConnectPOC.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class DashboardController:ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public DashboardController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("user-dashboard")]
        public async Task<IActionResult> GetUserDashboard()
        {
            var userDashboardDetails = await _userRepository.GetUserDashboardDetailsAsync();
            return Ok(userDashboardDetails);
        }
    }
}
