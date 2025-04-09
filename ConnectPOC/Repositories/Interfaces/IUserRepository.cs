using ConnectPOC.DTOs;
using ConnectPOC.Models;

namespace ConnectPOC.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<UserProfile?> GetByEmailAsync(string email);
        Task<UserProfile> CreateAsync(UserProfile user);
        Task<bool> ExistsAsync(string email);
        Task<List<UserProfile>> GetAllAsync();
        Task<List<UserDashboardBasicInfoDto>> GetUserDashboardDetailsAsync();
    }
}
