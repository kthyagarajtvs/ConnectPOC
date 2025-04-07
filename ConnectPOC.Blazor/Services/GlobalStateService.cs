using Microsoft.AspNetCore.Components;

namespace ConnectPOC.Blazor.Services
{
    public class GlobalStateService
    {
        private readonly NavigationManager _navManager;

        public GlobalStateService(NavigationManager navManager)
        {
            _navManager = navManager;
        }

        public string UserName { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;

        public void Logout()
        {
            // Clear user data
            UserName = string.Empty;
            Token = string.Empty;

            // Now we can safely call NavigationManager from an instance
            _navManager.NavigateTo("/");
        }
    }
}
