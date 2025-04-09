
using ConnectPOC.Configurations;
using ConnectPOC.Repositories.Factories;
using ConnectPOC.Repositories.Interfaces;
using ConnectPOC.Repositories.MongoImplementations;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace ConnectPOC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var config = builder.Configuration;

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("BlazorCORSPolicy", builder =>
                {
                    builder.WithOrigins("https://localhost:7295") // The port for your Blazor WASM
                           .AllowAnyHeader()
                           .AllowAnyMethod();
                });
            });

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Register repositories (SQL or Mongo)
            RepositoryFactory.Register(builder.Services, config);

            // Register custom token service
            builder.Services.AddScoped<ITokenService, TokenService>();
            builder.Services.AddScoped<IUserRepository, Repositories.SqlImplementations.UserRepository>();
            builder.Services.AddScoped<IDealerRepository, Repositories.SqlImplementations.DealerRepository>();
            builder.Services.AddScoped<ICityRepository, Repositories.SqlImplementations.CityRepository>();

            // JWT Authentication Setup
            var secretKey = "D1A2B3C4E5F60718293A4B5C6D7E8F90G1H2I3J4K5L6M7N8O9P0Q1R2S3T4U5V6";

            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = config[AuthConfig.JwtSettings_Issuer],
                    ValidAudience = config[AuthConfig.JwtSettings_Audience],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
                };
            });

            builder.Services.AddControllers();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }


            app.UseCors("BlazorCORSPolicy");
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
