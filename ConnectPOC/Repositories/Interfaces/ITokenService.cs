using ConnectPOC.Models;

namespace ConnectPOC.Repositories.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(UserProfile user);
    }
}
