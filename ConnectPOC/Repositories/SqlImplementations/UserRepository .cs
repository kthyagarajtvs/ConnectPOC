using ConnectPOC.DTOs;
using ConnectPOC.Models;
using ConnectPOC.Repositories.Interfaces;
using global::ConnectPOC.Data;
using Microsoft.EntityFrameworkCore;
using System.Data;

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

        public async Task<List<UserDashboardBasicInfoDto>> GetUserDashboardDetailsAsync()
        {
            var result = new List<UserDashboardBasicInfoDto>();

            using (var connection = _context.Database.GetDbConnection())
            {
                await connection.OpenAsync();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "EXEC GetUserDashboardDetail";
                    command.CommandType = CommandType.Text;

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        // 1st Result Set: Users
                        var userList = new List<UserDashboardBasicInfoDto>();
                        while (await reader.ReadAsync())
                        {
                            userList.Add(new UserDashboardBasicInfoDto
                            {
                                FullName = reader["FullName"]?.ToString(),
                                ProfileImagePath = reader["ProfileImagePath"]?.ToString(),
                                BloodGroup = reader["BloodGroup"]?.ToString(),
                                AllergicContent = reader["AllergicContent"]?.ToString(),
                                UserId = reader["UserId"]?.ToString(),
                                MobChangeStatus = reader["MobChangeStatus"]?.ToString(),
                                MobChangeStatusMsg = reader["MobChangeStatusMsg"]?.ToString(),
                            });
                        }

                        // 2nd Result Set: Vehicles
                        await reader.NextResultAsync();
                        var vehicleList = new List<UserVehicleDetailDto>();
                        while (await reader.ReadAsync())
                        {
                            vehicleList.Add(new UserVehicleDetailDto
                            {
                                VehicleId = Convert.ToInt32(reader["VehicleId"]),
                                VehicalTypeId = Convert.ToInt32(reader["vehicalTypeid"]),
                                FrameNo = reader["FRAME_NO"]?.ToString(),
                                VehicleName = reader["VehicleName"]?.ToString(),
                                ContactNo = reader["CONTACT_NO"]?.ToString(),
                                UserId = reader["UserId"]?.ToString(),
                                Series = reader["SERIES"]?.ToString(),
                                IOT = reader["IOT"]?.ToString(),
                                InsertDate = Convert.ToDateTime(reader["insertDate"]),
                                NickName = reader["NickName"]?.ToString(),
                                TotalRides = Convert.ToInt32(reader["totalRides"]),
                                TotalDistanceTravelled = Convert.ToDecimal(reader["totalDistanceTravelled"]),
                                TopSpeed = Convert.ToDecimal(reader["topSpeed"]),
                                OdometerReading = reader["odometerReading"] as decimal?,
                                Theme = Convert.ToInt32(reader["theme"])
                            });
                        }

                        // 3rd Result Set: Emergency Contacts
                        await reader.NextResultAsync();
                        var contactList = new List<EmergencyContactDto>();
                        while (await reader.ReadAsync())
                        {
                            contactList.Add(new EmergencyContactDto
                            {
                                ContactName = reader["ContactName"]?.ToString(),
                                ContactImagePath = reader["ContactImagePath"]?.ToString(),
                                EmergencyContactNumber = reader["EmergencyContactNumber"]?.ToString(),
                                UserId = reader["UserId"]?.ToString(),
                                Email = reader["Email"]?.ToString(),
                            });
                        }

                        // 4th Result Set: Videos
                        await reader.NextResultAsync();
                        var videoList = new List<UserVideoDto>();
                        while (await reader.ReadAsync())
                        {
                            videoList.Add(new UserVideoDto
                            {
                                VideoLink = reader["VideoLink"]?.ToString(),
                                VideoThumbnailLink = reader["VideoThumbnailLink"]?.ToString()
                            });
                        }

                        // Link data back to users
                        foreach (var user in userList)
                        {
                            user.Vehicles = vehicleList.Where(v => v.UserId == user.UserId).ToList();
                            user.EmergencyContacts = contactList.Where(c => c.UserId == user.UserId).ToList();
                            user.Videos = videoList; // Assuming videos not user-specific
                        }

                        result = userList;
                    }
                }
            }

            return result;
        }

    }
}


