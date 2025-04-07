using ConnectPOC.Models;
using ConnectPOC.Repositories.Interfaces;
using global::ConnectPOC.Data;
using Microsoft.EntityFrameworkCore;

namespace ConnectPOC.Repositories.SqlImplementations
{


    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<UserProfile>> GetAllAsync()
        {
            return await _context.UserProfiles.ToListAsync();
        }
        public async Task<UserProfile?> GetByEmailAsync(string email)
        {
            return await _context.UserProfiles.FirstOrDefaultAsync(u => u.EmailAddress == email);
        }

        public async Task<UserProfile> CreateAsync(UserProfile userProfile)
        {
            _context.UserProfiles.Add(userProfile);
            await _context.SaveChangesAsync();
            return userProfile;
        }

        public async Task<bool> ExistsAsync(string email)
        {
            return await _context.UserProfiles.AnyAsync(u => u.EmailAddress == email);
        }
    }
}


