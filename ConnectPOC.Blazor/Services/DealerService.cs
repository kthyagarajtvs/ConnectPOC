using System.Net.Http.Headers;
using System.Net.Http.Json;
using ConnectPOC.Blazor.Models;

namespace ConnectPOC.Blazor.Services
{
    public class DealerService
    {
        private readonly HttpClient _httpClient;
        private readonly GlobalStateService _globalState;
        private readonly IConfiguration _configuration;
        private readonly string baseUrl;
        public DealerService(HttpClient httpClient, GlobalStateService globalState, IConfiguration configuration)
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

        public async Task<List<ICubeDealers>> GetDealersAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<ICubeDealers>>($"{baseUrl}/Dealer") ?? new List<ICubeDealers>();
        }
    }
}
