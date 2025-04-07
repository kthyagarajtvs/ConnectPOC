using ConnectPOC.Models;
using ConnectPOC.Repositories.Interfaces;
using MongoDB.Driver;

namespace ConnectPOC.Repositories.MongoImplementations
{
    public class UserRepository:IUserRepository
    {
        private readonly IMongoCollection<UserProfile> _users;
        public UserRepository(IMongoClient client)
        {
            var database = client.GetDatabase("ConnectPOC");
            _users = database.GetCollection<UserProfile>("Users");
        }
        public async Task<UserProfile?> GetByEmailAsync(string email)
        {
            return await _users.Find(u => u.EmailAddress == email).FirstOrDefaultAsync();
        }

        public async Task<UserProfile> CreateAsync(UserProfile user)
        {
            await _users.InsertOneAsync(user);
            return user;
        }

        public async Task<bool> ExistsAsync(string email)
        {
            return await _users.Find(u => u.EmailAddress == email).AnyAsync();
        }

        async Task<List<UserProfile>> IUserRepository.GetAllAsync()
        {
            return await _users.Find(_ => true).ToListAsync();
        }
    }
}
