using ConnectPOC.DTOs;

namespace ConnectPOC.Blazor.Models
{
    public class UserDashboardBasicInfoDto
    {
        public string FullName { get; set; }
        public string ProfileImagePath { get; set; }
        public string BloodGroup { get; set; }
        public string AllergicContent { get; set; }
        public string UserId { get; set; }
        public string? MobChangeStatus { get; set; }
        public string? MobChangeStatusMsg { get; set; }

        public List<UserVehicleDetailDto> Vehicles { get; set; } = new();
        public List<EmergencyContactDto> EmergencyContacts { get; set; } = new();
        public List<UserVideoDto> Videos { get; set; } = new();
    }
}
