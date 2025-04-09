using ConnectPOC.DTOs.Response;
using ConnectPOC.Models;

namespace ConnectPOC.Repositories.Interfaces
{
    public interface IDealerRepository
    {
        Task<List<DealerDetailsDto>> GetAllAsync();
    }
}
