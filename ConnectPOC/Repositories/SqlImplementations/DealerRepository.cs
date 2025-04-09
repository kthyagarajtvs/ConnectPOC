using ConnectPOC.Data;
using ConnectPOC.DTOs.Response;
using ConnectPOC.Models;
using ConnectPOC.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ConnectPOC.Repositories.SqlImplementations
{
    public class DealerRepository : IDealerRepository
    {
        readonly AppDbContext _context;

        public DealerRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<DealerDetailsDto>> GetAllAsync()
        {
            return await _context.Database.SqlQuery<DealerDetailsDto>($"exec GetAllDealerDetails").ToListAsync();
        }
    }
}
