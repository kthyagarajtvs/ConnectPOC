using ConnectPOC.Models;

namespace ConnectPOC.Repositories.Interfaces
{
    public interface ICityRepository
    {
        Task<List<City>> GetAllCitiesAsync();
    }
}
