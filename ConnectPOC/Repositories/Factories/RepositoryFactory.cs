using ConnectPOC.Repositories.Interfaces;
using ConnectPOC.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using Microsoft.EntityFrameworkCore;
using ConnectPOC.Data;
using ConnectPOC.Configurations;

namespace ConnectPOC.Repositories.Factories
{
    public static class RepositoryFactory
    {
        public static void Register(IServiceCollection services, IConfiguration config)
        {
            string dbType = config[DatabaseConfig.DbTypeKey] ?? DatabaseConfig.SqlServer;
            if (dbType == DatabaseConfig.SqlServer)
            {
                var connectionString = config[DatabaseConfig.SqlConnectionKey];
                services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connectionString));
                services.AddScoped<IUserRepository, SqlImplementations.UserRepository>();
            }
            else
            {
                var mongoConn = config[DatabaseConfig.MongoConnectionKey];
                services.AddSingleton<IMongoClient>(new MongoClient(mongoConn));
               services.AddScoped<IUserRepository, MongoImplementations.UserRepository>();
            }
        }
    }
}
