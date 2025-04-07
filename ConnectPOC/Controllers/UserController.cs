using ConnectPOC.Configurations;
using ConnectPOC.Models;
using ConnectPOC.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ConnectPOC.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepo;
        private readonly ITokenService _tokenService;

        public UserController(IUserRepository userRepo, ITokenService tokenService)
        {
            _userRepo = userRepo;
            _tokenService = tokenService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserProfile user)
        {
            if (await _userRepo.ExistsAsync(user.EmailAddress))
                return BadRequest(ControllerConfig.User_Already_Exists);

          //  user.PasswordHash = HashPassword(user.PasswordHash);
            var created = await _userRepo.CreateAsync(user);
            return Ok(created);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userRepo.GetAllAsync();
            return Ok(users);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserProfile user)
        {
            try
            {
                var existingUser = await _userRepo.GetByEmailAsync(user.EmailAddress);
                if (existingUser == null)
                    return Unauthorized(ControllerConfig.Invalid_credentials);

                //if (!VerifyPassword(user.PasswordHash, existingUser.PasswordHash))
                //    return Unauthorized(ControllerConfig.Invalid_credentials);

                // Generate JWT token
                var token = _tokenService.GenerateToken(existingUser);
                return Ok(new { Token = token });
            }
            catch (Exception ex)
            {
                // Log the error (you can use ILogger for better logging)
                Console.WriteLine($"❌ Error in Login: {ex.Message}");

                return StatusCode(500, "An unexpected error occurred. Please try again later.");
            }
        }


        private string HashPassword(string password)
        {
            using var sha256 = System.Security.Cryptography.SHA256.Create();
            var bytes = System.Text.Encoding.UTF8.GetBytes(password);
            return System.Convert.ToBase64String(sha256.ComputeHash(bytes));
        }

        private bool VerifyPassword(string raw, string storedHash)
        {
            return HashPassword(raw) == storedHash;
        }
    }
}
