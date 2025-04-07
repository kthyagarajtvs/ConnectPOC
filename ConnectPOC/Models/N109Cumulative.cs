using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConnectPOC.Models
{
    public class N109Cumulative
    {
        [Key]
        public long N109CumulativeId { get; set; }

        [ForeignKey("UserProfile")]
        public long UserId { get; set; }

        [ForeignKey("UserVehicle")]
        public long UserVehicleId { get; set; }

        public bool IsDeleted { get; set; }
        public long Totalrides { get; set; }
        public long? TotalTime { get; set; }
        public long? RideTime { get; set; }
        public decimal? TotalTravelledDistance { get; set; }
        public decimal? BestShortestTime0to30 { get; set; }
        public decimal? TopSpeed { get; set; }
        public decimal? AverageSpeed { get; set; }
        public decimal? CO2Saved { get; set; }
        public int? LastFuelStatus { get; set; }
        public int? LastBatteryStatus { get; set; }
        public decimal? LastDistanceToEmpty { get; set; }
        public decimal? EcoModeTotalDistance { get; set; }
        public decimal? PowerModeTotalDistance { get; set; }
        public decimal? EcoModeBatteryDistance { get; set; }
        public decimal? EcoModeEngineDistance { get; set; }
        public decimal? PowerModeCombinedBEDistance { get; set; }
        public decimal? PowerModeOnlyEngDistance { get; set; }


        // Navigation Properties
        public UserProfile UserProfile { get; set; }
        public UserVehicle UserVehicle { get; set; }
    }

}
