using ConnectPOC.Data;
using ConnectPOC.Models;
using ConnectPOC.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ConnectPOC.Repositories.SqlImplementations
{
    public class CityRepository : ICityRepository
    {
        private readonly AppDbContext _context;
        

        public CityRepository(AppDbContext context)
        {
            _context = context;
           
        }

        public async Task<List<City>> GetAllCitiesAsync()
        {
            return await _context.Cities
                .FromSqlRaw("SELECT CityId, CityName FROM Cities")
                .ToListAsync();
        }
    }
}
