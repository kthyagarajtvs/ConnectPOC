using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConnectPOC.Models
{
    public class ApacheNONIOTCumulative
    {
        [Key]
        public long ApacheCumulativeId { get; set; }

        [ForeignKey("UserVehicle")]
        public long? UserVehicleId { get; set; }

        [ForeignKey("UserProfile")]
        public long? UserId { get; set; }
        public long? BikeTotalDrivenTime { get; set; }
        public long? TotalRides { get; set; }
        public decimal? TotalDistanceTravelled { get; set; }
        public decimal? BikeBestShortestTime { get; set; }
        public decimal? BikeTopSpeed { get; set; }
        public decimal? BikeAverageSpeed { get; set; }
        public decimal? BikeMaxGforce { get; set; }
        public decimal? BikeMaxLeanAngle { get; set; }
        public decimal? BikeMaxAltitude { get; set; }
        public bool? IsDeleted { get; set; }


        // Navigation Properties
        public UserProfile UserProfile { get; set; }
        public UserVehicle UserVehicle { get; set; }

    }
}
