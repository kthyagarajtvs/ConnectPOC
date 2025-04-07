using ConnectPOC.Configurations;
using ConnectPOC.Models;
using ConnectPOC.Repositories.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ConnectPOC.Repositories.SqlImplementations
{
    public class TokenService : ITokenService
    {
        public string GenerateToken(UserProfile user)
        {
            var secretKey = AuthConfig.JwtSettings_SecretKey;
            var issuer = AuthConfig.JwtSettings_Issuer;
            var audience = AuthConfig.JwtSettings_Audience;

            if (string.IsNullOrEmpty(secretKey))
                throw new ArgumentNullException(nameof(secretKey), "JWT SecretKey is missing.");

            var keyBytes = Encoding.UTF8.GetBytes(secretKey);
            if (keyBytes.Length < 32) // 256 bits = 32 bytes
                throw new ArgumentException("Secret key must be at least 32 bytes long.", nameof(secretKey));

            var key = new SymmetricSecurityKey(keyBytes);
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: issuer,
                audience: audience,
                claims: new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub, user.UserId.ToString()),
                    new Claim(JwtRegisteredClaimNames.Email, user.EmailAddress),
                },
                expires: DateTime.UtcNow.AddHours(2),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
