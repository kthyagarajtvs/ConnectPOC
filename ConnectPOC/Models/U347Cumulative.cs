using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConnectPOC.Models
{
    public class U347Cumulative
    {
        [Key]
        public long U347CumulativeId { get; set; }

        [ForeignKey("UserProfile")]
        public long? UserId { get; set; }

        [ForeignKey("UserVehicle")]
        public long? UserVehicleId { get; set; }
        public long? TotalRides { get; set; }
        public long? TotalTime { get; set; }
        public long? RideTime { get; set; }
        public decimal? TotalTravelledDistance { get; set; }
        public decimal? BestShortestTime0to30 { get; set; }
        public long? TopSpeed { get; set; }
        public long? AverageSpeed { get; set; }
        public decimal? CO2Saved { get; set; }
        public int? LastBatteryStatus { get; set; }
        public decimal? LstDistanceToEmpty { get; set; }
        public decimal? EcoModeTotalDistance { get; set; }
        public decimal? PowerModeTotalDistance { get; set; }

        // Navigation Properties
        public UserProfile UserProfile { get; set; }
        public UserVehicle UserVehicle { get; set; }

    }
}
