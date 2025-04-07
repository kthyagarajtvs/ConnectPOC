using ConnectPOC.Blazor.Models;
using System.Buffers.Text;
using System.Net.Http.Headers;
using System.Net.Http.Json;


namespace ConnectPOC.Blazor.Services
{
    public class UserService
    {
        private readonly HttpClient _httpClient;
        private readonly GlobalStateService _globalState;
        private readonly IConfiguration _configuration;
        private readonly string baseUrl;
        public UserService(HttpClient httpClient, GlobalStateService globalState, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _globalState = globalState;
            _configuration = configuration;
            baseUrl = _configuration["ApiSettings:BaseUrl"];


            // Set Authorization Header
            if (!string.IsNullOrEmpty(_globalState.Token))
            {
                _httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", _globalState.Token);
            }
        }

        public async Task<List<UserProfile>> GetUsersAsync()
        {

            return await _httpClient.GetFromJsonAsync<List<UserProfile>>($"{baseUrl}/User") ?? new List<UserProfile>();
        }

        public async Task<bool> RegisterUserAsync(UserProfile user)
        {
            var response = await _httpClient.PostAsJsonAsync($"{baseUrl}/users/register", user);

            if (response.IsSuccessStatusCode)
                return true;

            return false;
        }
    }
}
